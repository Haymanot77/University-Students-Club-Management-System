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
    public partial class Form5 : Form
    {
        static OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=mathClub.accdb");


        static OleDbCommand cmd = con.CreateCommand();
        static OleDbDataReader reader;
        int count = 0;


        public Form5()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (con.State.Equals(System.Data.ConnectionState.Open))
                con.Close();
            con.Open();
            OleDbCommand cmd = con.CreateCommand();
            DateTime selectedDate = dateMeeting.Value;

            // Combine day, month, and year into a single DateTime object
            DateTime combinedDate = new DateTime(selectedDate.Year, selectedDate.Month, selectedDate.Day);

            cmd.CommandText = "Insert into minuteMeeting( Author , MeetingDate,MeetingDescription) values ( '" + txtAuthor.Text + "','" +  combinedDate + "','" + richtxtMeeting.Text + "')";
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            MessageBox.Show("Minute meeting saved successfully ");
            con.Close();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}

