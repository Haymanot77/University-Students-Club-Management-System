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
    public partial class Form8 : Form
    {
        private string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=mathClub.accdb;";

        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
           // dataGridView1.AutoGenerateColumns = false;
           
            // TODO: This line of code loads data into the 'mathClubDataSet1.minuteMeeting' table. You can move, or remove it, as needed.
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                string query = "SELECT * FROM minuteMeeting"; // Replace YourTableName with the actual table name
                OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection);

                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dataGridView1.DataSource = dataTable;
                
            }

        }
    }
}
