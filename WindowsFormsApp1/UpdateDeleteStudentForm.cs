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
using System.IO;

namespace WindowsFormsApp1
{
    public partial class UpdateDeleteStudentForm : Form
    {
        public UpdateDeleteStudentForm()
        {
            InitializeComponent();
        }

        Student st = new Student();
        private void button_find_Click(object sender, EventArgs e)
        {
            if (textBox_ID.Text == "")
            {
                MessageBox.Show("Empty Fields", "Find", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int id = int.Parse(textBox_ID.Text);
                SqlCommand command = new SqlCommand("SELECT id, fname, lname, bdate, gender,phone,address,picture FROM std WHERE id =" + id);
                DataTable dt = st.getStudent(command);
                if (dt.Rows.Count > 0)
                {
                    textBox_firstname.Text = dt.Rows[0]["fname"].ToString();
                    textBox_lastname.Text = dt.Rows[0]["lname"].ToString();

                    if (dt.Rows[0]["gender"].ToString() == "Female")
                    {
                        radioButton_female.Checked = true;
                    }
                    else
                    {
                        radioButton_Male.Checked = true;
                    }
                    dateTimePicker1.Value = Convert.ToDateTime(dt.Rows[0]["bdate"].ToString());
                    textBox_phone.Text = dt.Rows[0]["phone"].ToString();
                    textBox_address.Text = dt.Rows[0]["address"].ToString();

                    byte[] pic = (byte[])dt.Rows[0]["picture"];
                    MemoryStream picture = new MemoryStream(pic);
                    pictureBox_student.Image = Image.FromStream(picture);
                }
                else
                {
                    MessageBox.Show("Not found", "Find Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void textBox_ID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                error_ID.SetError(textBox_ID, "Do not use letter!");
            }
            else
            {
                error_ID.SetError(textBox_ID, null);
            }
        }

        private void textBox_phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                error_phone.SetError(textBox_phone, "Do not use letter!");
            }
            else
            {
                error_phone.SetError(textBox_phone, null);
            }
        }

        private void button_findphone_Click(object sender, EventArgs e)
        {
            if (textBox_phone.Text == "")
            {
                MessageBox.Show("Empty Fields", "Find", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string phone = textBox_phone.Text;
                SqlCommand command = new SqlCommand("SELECT id, fname, lname, bdate, gender,phone,address,picture FROM std WHERE phone =" + phone);
                DataTable dt = st.getStudent(command);
                if (dt.Rows.Count > 0)
                {
                    textBox_ID.Text = dt.Rows[0]["id"].ToString();
                    textBox_firstname.Text = dt.Rows[0]["fname"].ToString();
                    textBox_lastname.Text = dt.Rows[0]["lname"].ToString();

                    if (dt.Rows[0]["gender"].ToString() == "Female")
                    {
                        radioButton_female.Checked = true;
                    }
                    else
                    {
                        radioButton_Male.Checked = true;
                    }
                    textBox_address.Text = dt.Rows[0]["address"].ToString();

                    byte[] pic = (byte[])dt.Rows[0]["picture"];
                    MemoryStream picture = new MemoryStream(pic);
                    pictureBox_student.Image = Image.FromStream(picture);
                }
                else
                {
                    MessageBox.Show("Not found", "Find Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        public class Thongtin{
           public static string firstname;
            }
        private void button_search_Click(object sender, EventArgs e)
        {
            if (textBox_firstname.Text == "")
            {
                MessageBox.Show("Empty Fields", "Search", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Thongtin.firstname = textBox_firstname.Text;
                Searchfname searchfname = new Searchfname();
                searchfname.Show(this);
            }
        }

        bool verif()
        {
            if ((textBox_firstname.Text.Trim() == "")
                || (textBox_lastname.Text.Trim() == "")
                || (textBox_phone.Text.Trim() == "")
                || (textBox_address.Text.Trim() == "")
                || (pictureBox_student.Image == null))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void button_uploadimage_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image (*.jpg;*.png;*.gif) | *.jpg;*.png;*.gif";

            if (opf.ShowDialog() == DialogResult.OK)
            {
                pictureBox_student.Image = Image.FromFile(opf.FileName);
            }
        }

        Student student = new Student();
        private void button_remove_Click(object sender, EventArgs e)
        {
            try
            {
                int Studentid = Convert.ToInt32(textBox_ID.Text);
                if((MessageBox.Show("Are You Sure You Want To Delete This Student","Delete Student",MessageBoxButtons.YesNo,MessageBoxIcon.Question)) == DialogResult.Yes)
                {
                    if (student.deleteStudent(Studentid))
                    {
                        MessageBox.Show("Student Deleted", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textBox_ID.Text = "";
                        textBox_firstname.Text = "";
                        textBox_lastname.Text = "";
                        textBox_address.Text = "";
                        textBox_phone.Text = "";
                        dateTimePicker1.Value = DateTime.Now;
                        pictureBox_student.Image = null;
                    }
                    else
                    {
                        MessageBox.Show("Student Not Deleted", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch 
            {
                MessageBox.Show("Please Enter A Valid ID","Delete Student",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button_edit_Click(object sender, EventArgs e)
        {
            if (!verif())
            {
                MessageBox.Show("Empty Fields", "Edit Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                //if (kiemtraid())
                //{
                //    MessageBox.Show("Can't change id", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //}
                //else
                //{
                    int id;
                    string fname = textBox_firstname.Text;
                    string lname = textBox_lastname.Text;
                    DateTime bdate = dateTimePicker1.Value;
                    string phone = textBox_phone.Text;
                    string address = textBox_address.Text;
                    string gender = "Male";

                    if (radioButton_female.Checked)
                    {
                        gender = "Female";
                    }

                    MemoryStream pic = new MemoryStream();
                    int born_year = dateTimePicker1.Value.Year;
                    int this_year = DateTime.Now.Year;

                    if ((this_year - born_year) < 10 || (this_year - born_year) > 100)
                    {
                        MessageBox.Show("The Student Age Must Be Between 10 and 100 year", "Birth Date Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        try
                        {
                            id = Convert.ToInt32(textBox_ID.Text);
                            pictureBox_student.Image.Save(pic, pictureBox_student.Image.RawFormat);
                            if (student.updateStudent(id, fname, lname, bdate, gender, phone, address, pic))
                            {
                                MessageBox.Show("Student Information Update", "Edit Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Error", "Edit Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Edit Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
               // }
            }
        }

        private bool kiemtraid()
        {
            MY_DB db = new MY_DB();
            bool ktrid = false;
            SqlCommand cmd = new SqlCommand("SELECT * FROM std", db.getConnection);
            db.openConnection();
            SqlDataReader sqlDataReader = cmd.ExecuteReader();
            int id = Int32.Parse(textBox_ID.Text);
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
    }
}
