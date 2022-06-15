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
using System.Net.Mail;
using System.Net;
using System.Threading;

namespace WindowsFormsApp1
{
    public partial class Resetpass : Form
    {
        public Resetpass()
        {
            InitializeComponent();
        }

        public static string ss = Reset.Randd();

        public void Email(string from, string to)
        {
            DataTable dt = reset.getemaillog_in(textBox_user.Text, textBox_email.Text);
            string email = dt.Rows[0]["email"].ToString();
            string pass = dt.Rows[0]["pass_email"].ToString();

            string subject = "Verification";
            string message = "Your confirmation code is: " + ss;
            MailMessage mess = new MailMessage(from,to,subject,message);
            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com",587);
            smtpClient.EnableSsl = true;
            smtpClient.Credentials = new NetworkCredential(email,pass);
            smtpClient.Send(mess);
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        bool verif()
        {
            if ((textBox_user.Text.Trim() == "")
                || (textBox_email.Text.Trim() == "")
                || (textBox_newpass.Text.Trim() == ""))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        Reset reset = new Reset();
        private void button2_Click(object sender, EventArgs e)
        {
            string user = textBox_user.Text;
            string email = textBox_email.Text;
            string newpass = textBox_newpass.Text;
            if (verif())
            {
                    try
                    {
                        if (reset.getuser_email(user,email))
                        {
                        Thread thread = new Thread(() => Email(email, email));
                        thread.Start();
                            VerificationForm verificationForm = new VerificationForm();
                            if(verificationForm.ShowDialog() == DialogResult.OK)
                            {
                                 if (reset.updatepass(user, email, newpass))
                                 {
                                    MessageBox.Show("Password changed successfully", "Reset Password", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                textBox_user.Text = "";
                                textBox_email.Text = "";
                                textBox_newpass.Text = "";
                                 }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Invalid email or account", "Reset Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Reset Password", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }   
            else
            {
                MessageBox.Show("Empty Fields", "Reset Password", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void checkBox_show_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_show.Checked)
            {
                textBox_newpass.PasswordChar = (char)0;
            }
            else
            {
                textBox_newpass.PasswordChar = '*';
            }
        }

        private void textBox_newpass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar))
            {
                e.Handled = true;
                error_passnew.SetError(textBox_newpass, "Do not use special characters!");
            }
            else
            {
                error_passnew.SetError(textBox_newpass, null);
            }
        }

    }
}
