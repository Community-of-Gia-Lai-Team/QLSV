using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class ManageCourseForm : Form
    {
        public ManageCourseForm()
        {
            InitializeComponent();
        }

        Course course = new Course();
        int pos;
        private void ManageCourseForm_Load(object sender, EventArgs e)
        {
            ReloadlistboxData();

            SqlCommand cmd = new SqlCommand("SELECT id, CONCAT(fname,' ',lname) as name FROM Contact");
            comboBox1.DataSource = course.getCourse(cmd);
            comboBox1.ValueMember = "id";
            comboBox1.DisplayMember = "name";
        }

        public void ReloadlistboxData()
        {
            listBox_totalcourse.DataSource = course.getAllCourses();
            listBox_totalcourse.ValueMember = "id";
            listBox_totalcourse.DisplayMember = "label";
            listBox_totalcourse.SelectedItem = null;
            label_totalcourse.Text = ("Total Course:" + course.totalCourse());
        }

        public void ShowData(int index)
        {
            DataRow dr = course.getAllCourses().Rows[index];
            listBox_totalcourse.SelectedIndex = index;
            textBox_id.Text = dr.ItemArray[0].ToString();
            textBox_name.Text = dr.ItemArray[1].ToString();
            numericUpDown_hours.Value = int.Parse(dr.ItemArray[2].ToString());
            textBox_description.Text = dr.ItemArray[3].ToString();
            comboBox1.SelectedValue = dr.ItemArray[4].ToString();   
        }

        private void listBox_totalcourse_Click(object sender, EventArgs e)
        {
            DataRowView drv = (DataRowView)listBox_totalcourse.SelectedItem;
            pos = listBox_totalcourse.SelectedIndex;
            ShowData(pos);
        }
        private bool kiemtratrungcourseid()
        {
            MY_DB db = new MY_DB();
            bool ktrid = false;
            SqlCommand cmd = new SqlCommand("SELECT * FROM course_table", db.getConnection);
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

        private void button_add_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox_id.Text);
            string name = textBox_name.Text;
            int period = (int)numericUpDown_hours.Value;
            string description = textBox_description.Text;
            int idcontact = Convert.ToInt32(comboBox1.SelectedValue);
            if (name.Trim() == "")
            {
                MessageBox.Show("Add a course", "Add course", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (period < 10)
            {
                MessageBox.Show("Study time must be more than 10", "Invalid Period", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (!kiemtratrungcourseid())
            {
                if (course.checkCourseName(name))
                {
                    if (course.insertCourse(id, name, period, description,idcontact))
                    {
                        MessageBox.Show("New Course Inserted", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textBox_id.Text = "";
                        textBox_name.Text = "";
                        textBox_description.Text = "";
                        ReloadlistboxData();
                    }
                    else
                    {
                        MessageBox.Show("Course Not Inserted", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Course Name Already Exists", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Course ID Already Exists", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button_edit_Click(object sender, EventArgs e)
        {
            string name = textBox_name.Text;
            int period = (int)numericUpDown_hours.Value;
            string description = textBox_description.Text;
            int id = int.Parse(textBox_id.Text);
            int idcontact = Convert.ToInt32(comboBox1.SelectedValue);

            if (!course.checkCourseName(name, Convert.ToInt32(textBox_id.Text)))
            {
                MessageBox.Show("This Course Name Already Exist", "Edit Course", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (course.updateCourse(id, name, period, description,idcontact))
            {
                MessageBox.Show("Course Updated", "Edit Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ReloadlistboxData();
            }
            else
            {
                MessageBox.Show("Course Not Update", "Edit Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button_remove_Click(object sender, EventArgs e)
        {
            try
            {
                int CourseID = Convert.ToInt32(textBox_id.Text);
                if ((MessageBox.Show("Are You Sure You Want To Delete This Course ", "Delete Course", MessageBoxButtons.YesNo, MessageBoxIcon.Question)) == DialogResult.Yes)
                {
                    if (course.deleteCourse(CourseID))
                    {
                        MessageBox.Show("Course Deleted", "Delete Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textBox_id.Text = "";
                        textBox_name.Text = "";
                        numericUpDown_hours.Value = 10;
                        textBox_description.Text = "";
                        ReloadlistboxData();
                    }
                    else
                    {
                        MessageBox.Show("Course Not Deleted", "Delete Course", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Please Enter A Valid Course ID", "Delete Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            pos = 0;
        }

        private void button_first_Click(object sender, EventArgs e)
        {
            pos = 0;
            ShowData(pos);
        }

        private void button_next_Click(object sender, EventArgs e)
        {
            if (pos < (course.getAllCourses().Rows.Count - 1))
            {
                pos = pos + 1;
                ShowData(pos);
            }
        }

        private void button_previous_Click(object sender, EventArgs e)
        {
            if (pos > 0)
            {
                pos = pos - 1;
                ShowData(pos);
            }
        }

        private void button_last_Click(object sender, EventArgs e)
        {
            pos = (course.getAllCourses().Rows.Count - 1);
            ShowData(pos);
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
    }
}
