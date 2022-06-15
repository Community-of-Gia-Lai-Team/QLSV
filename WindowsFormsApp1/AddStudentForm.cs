using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class AddStudentForm : Form
    {
        public AddStudentForm()
        {
            InitializeComponent();
        }

        private void bt_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        bool verif()
        {
            if ((tB_firstname.Text.Trim() == "")
                || (tB_lastname.Text.Trim() == "")
                || (tB_phone.Text.Trim() == "")
                || (tB_address.Text.Trim() == "")
                || (pictureBox2.Image == null))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void bt_add_Click(object sender, EventArgs e)
        {
            if (!verif())
            {
                MessageBox.Show("Empty Fields", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
            Student student = new Student();    
            int id = Convert.ToInt32(tB_studentid.Text);
            string fname = tB_firstname.Text;
            string lname = tB_lastname.Text;
            DateTime bdate = dateTime_birthdate.Value;
            string phone = tB_phone.Text;
            string address = tB_address.Text;
            string gender = "Male";

            if (rB_Female.Checked)
            {
                gender = "Female";
            }

            MemoryStream pic =  new MemoryStream();
            int born_year = dateTime_birthdate.Value.Year;
            int this_year = DateTime.Now.Year;

                if ((this_year - born_year) < 10 || (this_year - born_year) > 100)
                {
                    MessageBox.Show("The Student Age Must Be Between 10 and 100 year", "Invalid Birth Date", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (student.PhoneExist(phone))
                {
                    MessageBox.Show("Phone number already exists", "Invalid Phone", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    pictureBox2.Image.Save(pic, pictureBox2.Image.RawFormat);
                    if (student.insertStudent(id, fname, lname, bdate, gender, phone, address, pic))
                    {
                        MessageBox.Show("New Student Added", "Add student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        tB_studentid.Text = "";
                        tB_firstname.Text = "";
                        tB_lastname.Text = "";
                        tB_address.Text = "";
                        tB_phone.Text = "";
                        dateTime_birthdate.Value = DateTime.Now;
                        pictureBox2.Image = null;
                    }
                    else
                    {
                        MessageBox.Show("Error", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void bt_upload_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image (*.jpg;*.png;*.gif) | *.jpg;*.png;*.gif";

            if(opf.ShowDialog() == DialogResult.OK)
            {
                pictureBox2.Image = Image.FromFile(opf.FileName);
            } 
        }
        private bool kiemtraid()
        {
            MY_DB db = new MY_DB();
            bool ktrid = false;
            SqlCommand cmd = new SqlCommand("SELECT * FROM std", db.getConnection);
            db.openConnection();
            SqlDataReader sqlDataReader = cmd.ExecuteReader();
            int id = Int32.Parse(tB_studentid.Text);
            while (sqlDataReader.Read())
                {
                    if (id == sqlDataReader.GetInt32(0))
                    {
                        ktrid = true;
                    }
                }
            db.closeConnection();
            return ktrid;
        }
        private void tB_studentid_Validating(object sender, CancelEventArgs e)
        {
            if (tB_studentid.Text == "")
            {
                errorProvider_id.SetError(tB_studentid, "Empty Field");
            }
            else
            {
                if (kiemtraid())
                {
                    e.Cancel = true;
                    errorProvider_id.SetError(tB_studentid, "Student ID already exists");
                }
                else
                {
                    e.Cancel = false;
                    errorProvider_id.SetError(tB_studentid, null);
                }
            }
        }

        private void tB_studentid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                errorProvider_id.SetError(tB_studentid, "Do not use letter!");
            }
            else
            {
                errorProvider_id.SetError(tB_studentid, null);
            }
        }

        private void tB_phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                errorProvider_phone.SetError(tB_phone, "Do not use letter!");
            }
            else
            {
                errorProvider_phone.SetError(tB_phone, null);
            }
        }

        private void tB_firstname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                errorProvider_fname.SetError(tB_firstname, "Do not use number!");
            }
            else
            {
                errorProvider_fname.SetError(tB_firstname, null);
            }
        }

        private void tB_lastname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                errorProvider_lname.SetError(tB_lastname, "Do not use number!");
            }
            else
            {
                errorProvider_lname.SetError(tB_lastname, null);
            }
        }

        private void AddStudentForm_Load(object sender, EventArgs e)
        {
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
