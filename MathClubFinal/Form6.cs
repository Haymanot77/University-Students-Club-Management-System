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
    public partial class Form6 : Form
    {
        private string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=mathClub.accdb;";

        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mathClubDataSet5.MemberInformation' table. You can move, or remove it, as needed.

            // TODO: This line of code loads data into the 'mathClubDataSet4.MemberInformation' table. You can move, or remove it, as needed.

            // TODO: This line of code loads data into the 'mathClubDataSet.MemberInformation' table. You can move, or remove it, as needed.

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                string query = "SELECT * FROM MemberInformation"; // Replace YourTableName with the actual table name
                OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection);

                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dataGridView1.DataSource = dataTable;

            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
