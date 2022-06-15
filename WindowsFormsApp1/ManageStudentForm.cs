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
using System.Drawing.Imaging;

namespace WindowsFormsApp1
{
    public partial class ManageStudentForm : Form
    {
        public ManageStudentForm()
        {
            InitializeComponent();
        }
        Student student = new Student();
        private void ManageStudentForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'viduDataSet1.std' table. You can move, or remove it, as needed.
           // this.stdTableAdapter.Fill(this.viduDataSet1.std);
            FillGrid(new SqlCommand("SELECT * FROM std ORDER BY id ASC"));
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            DataGridView1.Columns[3].DefaultCellStyle.Format = "dd/MM/yyyy";
        }

        public void FillGrid(SqlCommand cmd)
        {
            DataGridView1.ReadOnly = true;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            DataGridView1.RowTemplate.Height = 80;
            DataGridView1.DataSource = student.getStudent(cmd);
            picCol = (DataGridViewImageColumn)DataGridView1.Columns[7];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            DataGridView1.AllowUserToAddRows = false;

            label_totalstudent.Text =  ("Total Student: " + DataGridView1.Rows.Count);
        }

        bool verif()
        {
            if ((textBox_fname.Text.Trim() == "")
                || (textBox_lname.Text.Trim() == "")
                || (textBox_phone.Text.Trim() == "")
                || (textBox_address.Text.Trim() == "")
                || (pictureBox1.Image == null))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            if (!verif())
            {
                MessageBox.Show("Empty Fields", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (kiemtraid())
                {
                    MessageBox.Show("Course ID Already Exists", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    Student student = new Student();
                    int id = Convert.ToInt32(textBox_id.Text);
                    string fname = textBox_fname.Text;
                    string lname = textBox_lname.Text;
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
                        MessageBox.Show("The Student Age Must Be Between 10 and 100 year", "Invalid Birth Date", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        pictureBox1.Image.Save(pic, pictureBox1.Image.RawFormat);
                        if (student.insertStudent(id, fname, lname, bdate, gender, phone, address, pic))
                        {
                            MessageBox.Show("New Student Added", "Add student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            FillGrid(new SqlCommand("Select * from std"));
                        }
                        else
                        {
                            MessageBox.Show("Error", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
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
                    string fname = textBox_fname.Text;
                    string lname = textBox_lname.Text;
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
                            id = Convert.ToInt32(textBox_id.Text);
                            pictureBox1.Image.Save(pic, pictureBox1.Image.RawFormat);
                            if (student.updateStudent(id, fname, lname, bdate, gender, phone, address, pic))
                            {
                                MessageBox.Show("Student Information Update", "Edit Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                FillGrid(new SqlCommand("Select * from std"));
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
                //}
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

        private void button_download_Click(object sender, EventArgs e)
        {
            SaveFileDialog opf = new SaveFileDialog();
            opf.FileName = ("student_"+textBox_id.Text);
            if(pictureBox1.Image == null)
            {
                MessageBox.Show("No Image In The PictureBox");
            }
            else if(opf.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image.Save((opf.FileName + ("." + ImageFormat.Jpeg.ToString())));
            }
        }

        private void button_remove_Click(object sender, EventArgs e)
        {
            try
            {
                int Studentid = Convert.ToInt32(textBox_id.Text);
                if ((MessageBox.Show("Are You Sure You Want To Delete This Student", "Delete Student", MessageBoxButtons.YesNo, MessageBoxIcon.Question)) == DialogResult.Yes)
                {
                    if (student.deleteStudent(Studentid))
                    {
                        MessageBox.Show("Student Deleted", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textBox_id.Text = "";
                        textBox_fname.Text = "";
                        textBox_lname.Text = "";
                        textBox_address.Text = "";
                        textBox_phone.Text = "";
                        dateTimePicker1.Value = DateTime.Now;
                        pictureBox1.Image = null;
                    }
                    else
                    {
                        MessageBox.Show("Student Not Deleted", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Please Enter A Valid ID", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button_reset_Click(object sender, EventArgs e)
        {
            textBox_id.Text = "";
            textBox_fname.Text = "";
            textBox_lname.Text = "";
            textBox_phone.Text = "";
            textBox_address.Text = "";
            pictureBox1.Image= null;
            dateTimePicker1.Value= DateTime.Now;
            radioButton_male.Checked = true;
        }


        private void button_search_Click(object sender, EventArgs e)
        {
            if (textBox_search.Text.Trim() == "")
            {
                MessageBox.Show("Empty Field", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM std WHERE id = "+Convert.ToInt32(textBox_search.Text));
                FillGrid(cmd);
            }
        }

        private bool kiemtraid()
        {
            MY_DB db = new MY_DB();
            bool ktrid = false;
            SqlCommand cmd = new SqlCommand("SELECT * FROM std", db.getConnection);
            db.openConnection();
            SqlDataReader sqlDataReader = cmd.ExecuteReader();
            int id = Int32.Parse(textBox_id.Text);
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

        private void textBox_id_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                errorProvider_id.SetError(textBox_id, "Do not use letter!");
            }
            else
            {
                errorProvider_id.SetError(textBox_id, null);
            }
        }

        private void textBox_phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                errorProvider_phone.SetError(textBox_phone, "Do not use letter!");
            }
            else
            {
                errorProvider_phone.SetError(textBox_phone, null);
            }
        }

        private void textBox_fname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                errorProvider_fname.SetError(textBox_fname, "Do not use number!");
            }
            else
            {
                errorProvider_fname.SetError(textBox_fname, null);
            }
        }

        private void textBox_lname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                errorProvider_lname.SetError(textBox_lname, "Do not use number!");
            }
            else
            {
                errorProvider_lname.SetError(textBox_lname, null);
            }
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox_id.Text = DataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox_fname.Text = DataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox_lname.Text = DataGridView1.CurrentRow.Cells[2].Value.ToString();
            dateTimePicker1.Value = (DateTime)DataGridView1.CurrentRow.Cells[3].Value;

            if (DataGridView1.CurrentRow.Cells[4].Value.ToString() == "Female")
            {
                radioButton_female.Checked = true;
            }
            else if (DataGridView1.CurrentRow.Cells[4].Value.ToString() == "Male")
            {
                radioButton_male.Checked = true;
            }

            textBox_phone.Text = DataGridView1.CurrentRow.Cells[5].Value.ToString();
            textBox_address.Text = DataGridView1.CurrentRow.Cells[6].Value.ToString();

            byte[] pic;

            pic = (byte[])DataGridView1.CurrentRow.Cells[7].Value;
            MemoryStream picture = new MemoryStream(pic);
            pictureBox1.Image = Image.FromStream(picture);
        }
    }
}
   
