using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class UpdateHrForm : Form
    {
        public UpdateHrForm()
        {
            InitializeComponent();
        }

        public static string dd = Reset.Randd();

        Reset reset = new Reset();
        public void Email(string from, string to)
        {
            DataTable dt = reset.getemailhr(textBox_user.Text, textBox_email.Text);
            string email = dt.Rows[0]["email"].ToString();
            string pass = dt.Rows[0]["pass_email"].ToString();

            string subject = "Verification";
            string message = "Your confirmation code is: " + dd;
            MailMessage mess = new MailMessage(from, to, subject, message);
            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);
            smtpClient.EnableSsl = true;
            smtpClient.Credentials = new NetworkCredential(email, pass);
            smtpClient.Send(mess);
        }

        private void UpdateHrForm_Load(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button_upload_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image (*.jpg;*.png;*.gif) | *.jpg;*.png;*.gif";

            if (opf.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(opf.FileName);
            }
        }

        public bool verif()
        {
            if(textBox_id.Text.Trim() == "" || textBox_fname.Text.Trim() == "" || textBox_lname.Text.Trim() == "" 
                || textBox_user.Text.Trim() == "" || textBox_pass.Text.Trim() == "" || pictureBox1.Image == null || textBox_email.Text.Trim() == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        User user = new User();
        private void button_edit_Click(object sender, EventArgs e)
        {
            if (verif())
            {
                try
                {
                    int id = Convert.ToInt32(textBox_id.Text);
                    string fname = textBox_fname.Text;
                    string lname = textBox_lname.Text;
                    string users = textBox_user.Text;
                    string pass = textBox_pass.Text;
                    string email = textBox_email.Text;
                    MemoryStream pic = new MemoryStream();
                    pictureBox1.Image.Save(pic, pictureBox1.Image.RawFormat);
                    if (reset.getuser_emailHR(users, email,id))
                    {
                        Thread thread = new Thread(() => Email(email, email));
                        thread.Start();
                        CodeHrform code = new CodeHrform();
                        if (code.ShowDialog() == DialogResult.OK)
                        {
                            if (user.updateUser(id,fname,lname,pass,pic))
                            {
                                MessageBox.Show("Information has been updated", "Edit User", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                textBox_user.Text = "";
                                textBox_email.Text = "";
                                textBox_id.Text = "";
                                textBox_fname.Text = "";
                                textBox_lname.Text = "";
                                textBox_pass.Text = "";
                                pictureBox1.Image = null;
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid email or account or ID", "Edit User", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Edit User", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Empty Fields", "Reset Password", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
