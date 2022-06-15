using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }
        Register rg = new Register();
        bool verif()
        {
            if ((textBox_user.Text.Trim() == "")
                || (textBox_pass.Text.Trim() == "")
                || (textBox_email.Text.Trim() == "")
                || (textBox_pass_email.Text.Trim() == ""))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            string user = textBox_user.Text;
            string pass = textBox_pass.Text;
            string email = textBox_email.Text;
            string pass_email = textBox_pass_email.Text;
            if (verif())
            {
                if (rg.insertLog_in(user, pass,email,pass_email))
                {
                    MessageBox.Show("Registered successfully", "Register", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error", "Register", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Empty Fields", "Register", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private bool kiemtra_user()
        {
            bool ktr = false;
            MY_DB db = new MY_DB();
            SqlCommand cmd = new SqlCommand("SELECT * FROM log_in", db.getConnection);
            db.openConnection();
            SqlDataReader sqlDataReader = cmd.ExecuteReader();
            while (sqlDataReader.Read())
            {
                if (textBox_user.Text == sqlDataReader.GetString(0))
                {
                    ktr = true;
                }
            }
            db.closeConnection();
            return ktr;
        }

        private void textBox_user_Validating(object sender, CancelEventArgs e)
        {

                if (kiemtra_user() || rg.usernameExistContact(textBox_user.Text))
                {
                    e.Cancel = true;
                    error_user.SetError(textBox_user, "Account already exists");
                }
                else
                {
                    e.Cancel = false;
                    error_user.SetError(textBox_user, null);
                }
        }

        private void checkBox_showpass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_showpass.Checked)
            {
                textBox_pass.PasswordChar = (char)0;
            }
            else
            {
                textBox_pass.PasswordChar = '*';
            }
        }

        private void checkBox_Showpassemail_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Showpassemail.Checked)
            {
                textBox_pass_email.PasswordChar = (char)0;
            }
            else
            {
                textBox_pass_email.PasswordChar = '*';
            }
        }

        private bool kiemtra_email_trung()
        {
            bool ktre = false;
            MY_DB db = new MY_DB();
            SqlCommand cmd = new SqlCommand("SELECT * FROM log_in", db.getConnection);
            db.openConnection();
            SqlDataReader sqlDataReader = cmd.ExecuteReader();
            while (sqlDataReader.Read())
            {
                if (textBox_email.Text == sqlDataReader.GetString(2))
                {
                    ktre = true;
                }
            }
            db.closeConnection();
            return ktre;
        }

        private bool Kiemtra_cautruc_email()
        {
            bool kiemtra = textBox_email.Text.EndsWith("@gmail.com");
            return kiemtra;
        }

        private void textBox_email_Validating(object sender, CancelEventArgs e)
        {
            if (kiemtra_email_trung() == true)
            {
                e.Cancel = true;
                error_email.SetError(textBox_email, "Email already exists");
            }
            else if(Kiemtra_cautruc_email() == false)
            {
                e.Cancel = true;
                error_email.SetError(textBox_email, "Wrong structure");
            }
            else if(kiemtra_email_trung() == false && Kiemtra_cautruc_email() == true)
            {
                e.Cancel = false;
                error_email.SetError(textBox_email, null);
            }
        }

        private void textBox_pass_KeyPress(object sender, KeyPressEventArgs e)
        {
                if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar))
                {
                    e.Handled = true;
                    error_pass.SetError(textBox_pass, "Do not use special characters!");
                }
                else
                {
                    error_pass.SetError(textBox_pass, null);
                }
        }

        private void textBox_pass_email_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar))
            {
                e.Handled = true;
                error_passemail.SetError(textBox_pass_email, "Do not use special characters!");
            }
            else
            {
                error_passemail.SetError(textBox_pass_email, null);
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
