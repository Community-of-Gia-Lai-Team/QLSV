using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class RegisterHR : Form
    {
        public RegisterHR()
        {
            InitializeComponent();
        }
        User user = new User();

        public bool verif()
        {
            if(textBox_id.Text.Trim() == "" || textBox_fname.Text.Trim() == "" || textBox_lname.Text.Trim() == ""
                || textBox_user.Text.Trim() == "" || textBox_pass.Text.Trim() == "" || pictureBox1.Image == null ||
                textBox_email.Text.Trim() == "" || textBox_passemail.Text.Trim() == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!verif())
            {
                MessageBox.Show("Empty Fields", "Register", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                int id = Convert.ToInt32(textBox_id.Text);
                string fname = textBox_fname.Text;
                string lname = textBox_lname.Text;
                string username = textBox_user.Text;
                string pass = textBox_pass.Text;
                string email = textBox_email.Text;
                string passemail = textBox_passemail.Text;
                string register = "register";
                MemoryStream pic = new MemoryStream();
                if (user.usernameExist(username,register,id) || user.UsernameExistLogin(username))
                {
                    MessageBox.Show("Username already exists","Register", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if(user.EmailExist(email) || user.EmailExistLogin(email))
                {
                    MessageBox.Show("Email already exists", "Register", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }  
                else
                { 
                    pictureBox1.Image.Save(pic, pictureBox1.Image.RawFormat);
                    if (user.insertUser(id,fname,lname,username,pass,pic,email,passemail))
                    {
                        MessageBox.Show("New Account Added", "Register", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textBox_id.Text = "";
                        textBox_fname.Text = "";
                        textBox_lname.Text = "";
                        textBox_user.Text = "";
                        textBox_pass.Text = "";
                        pictureBox1.Image = null;
                        textBox_passemail.Text = "";
                        textBox_email.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Error", "Register", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
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

        private void label8_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox_pass.PasswordChar = (char)0;
            }
            else
            {
                textBox_pass.PasswordChar = '*';
            }
        }

        private void RegisterHR_Load(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
