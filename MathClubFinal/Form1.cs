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
    public partial class Form1 : Form
    {


        static OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=mathClub.accdb");


        static OleDbCommand cmd = con.CreateCommand();
        static OleDbDataReader reader;
        int count = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {

            mainPanel.Controls.Clear();

            // Add Form2 to mainPanel

            Form2 register = new Form2();
            register.MdiParent = this;

            mainPanel.Controls.Add(register);
            register.Show();
        }

        private void btnAttendance_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();
            Form3 attendance = new Form3();
            attendance.MdiParent = this;

            mainPanel.Controls.Add(attendance);

            attendance.Show();

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();

            Form5 meeting = new Form5();
            meeting.MdiParent = this;

            mainPanel.Controls.Add(meeting);
            meeting.Show();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Visible = true;
        }

        private void btnMember_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();

            Form6 vMember = new Form6();
            vMember.MdiParent = this;

            mainPanel.Controls.Add(vMember);
            vMember.Show();
        }

        private void btnViewAttendance_Click(object sender, EventArgs e)
        {

            mainPanel.Controls.Clear();

            Form7 vAttendance = new Form7();
            vAttendance.MdiParent = this;

            mainPanel.Controls.Add(vAttendance);
            vAttendance.Show();
        }

        private void btnViewMeeting_Click(object sender, EventArgs e)
        {
            mainPanel.Controls.Clear();

            Form8 vNotes = new Form8();
            vNotes.MdiParent = this;

            mainPanel.Controls.Add(vNotes);
            vNotes.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
        }
    }
}
