using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathClubFinal
{
    public partial class Form3 : Form
    {
        static OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=mathClub.accdb");


        static OleDbCommand cmd = con.CreateCommand();
        static OleDbDataReader reader;
      
        public Form3()
        {
            InitializeComponent();
        }

       

        private void btnAttendance_Click(object sender, EventArgs e)
        {

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {


                if (con.State.Equals(System.Data.ConnectionState.Open))
                    con.Close();
                con.Open();
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandText = "Insert into Attendance( AttendanceDate,StudentID,StudentName,Status) values ( '" + row.Cells[0].Value + "','" + row.Cells[2].Value + "','" + row.Cells[3].Value + "','" + row.Cells[1].Value + "')";
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
              

            }
            MessageBox.Show("Attendance taken!");
            con.Close();
            
        }
            

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mathClubDataSet.MemberInformation' table. You can move, or remove it, as needed.


            try
            {
                con.Open();
                OleDbDataAdapter adapter = new OleDbDataAdapter("SELECT StudentID, StudentName FROM MemberInformation", con);
                dataGridView1.Columns.Add("date", "Date");
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
                dataGridView1.Columns.Add("status", "Status");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
            finally
            {
                con.Close();
            }

        }
    }
}
