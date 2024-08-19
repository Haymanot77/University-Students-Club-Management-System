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
    public partial class Form2 : Form
    {
        static OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=mathClub.accdb");
        static OleDbCommand cmd = con.CreateCommand();
        static OleDbDataReader reader;
        private string placeholderText = "Enter 1.1,1.2,2.2...";
        public Form2()
        {
            InitializeComponent();
            txtYear.Text = placeholderText;
            txtYear.ForeColor = System.Drawing.SystemColors.GrayText;

            foreach (Control control in groupBox1.Controls)
            {
                if (control is TextBox)
                {
                    TextBox textBox = (TextBox)control;
                    textBox.Font = new Font(textBox.Font.FontFamily, 12, FontStyle.Regular);
                }
                if (control is ComboBox)
                {
                    ComboBox textBox = (ComboBox)control;
                    textBox.Font = new Font(textBox.Font.FontFamily, 12, FontStyle.Regular); 
                }
            }
        }

        private void txtYear_Enter(object sender, EventArgs e)
        {
            if (txtYear.Text == placeholderText)
            {
                txtYear.Text = "";
                txtYear.ForeColor = System.Drawing.SystemColors.WindowText;
            }
        }
        private void txtYear_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtYear.Text))
            {
                txtYear.Text = placeholderText;
                txtYear.ForeColor = System.Drawing.SystemColors.GrayText;
            }
        }




        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (con.State.Equals(System.Data.ConnectionState.Open))
                con.Close();
            con.Open();
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandText = "Insert into MemberInformation(StudentID, StudentName,Sex,Major,YearOfStudy) values ( '" + txtId.Text + "','" + txtFullName.Text + "','" + comBoxSex.Text + "','" + comBoxMajor.Text + "','" + txtYear.Text + "')";
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            MessageBox.Show("Member registered successfully ");
            con.Close();
            foreach (Control control in groupBox1.Controls)
            {
                if (control is TextBox textBox )
                {
                    textBox.Clear();
                   
                }
                
            }

        }

      

      
    }
}
