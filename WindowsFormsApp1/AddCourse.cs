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
    public partial class AddCourse : Form
    {
        public AddCourse()
        {
            InitializeComponent();
        }

        bool verif()
        {
            if ((textBox_courseid.Text.Trim() =="")
                || (textBox_name.Text.Trim() == "")
                || (textBox_period.Text.Trim() == "")
                || (textBox_description.Text.Trim() == "")
                || (comboBox1.SelectedItem == null))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool kiemtra_courseid()
        {
            MY_DB db = new MY_DB();
            bool ktrid = false;
            SqlCommand cmd = new SqlCommand("SELECT * FROM course_table", db.getConnection);
            db.openConnection();
            SqlDataReader sqlDataReader = cmd.ExecuteReader();
                int id = Int32.Parse(textBox_courseid.Text);
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (!verif())
            {
                MessageBox.Show("Empty Fields", "Add course", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (kiemtra_courseid())
                {
                    MessageBox.Show("Course ID Already Exists", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    Course course = new Course();
                    string name = textBox_name.Text;
                    int id = Convert.ToInt32(textBox_courseid.Text);
                    int period = Convert.ToInt32(textBox_period.Text);
                    string description = textBox_description.Text;
                    int idcontact = Convert.ToInt32(comboBox1.SelectedValue);
                    if (period < 10)
                    {
                        MessageBox.Show("Study time must be more than 10", "Invalid Period", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (course.checkCourseName(name))
                    {
                        if (course.insertCourse(id, name, period, description,idcontact))
                        {
                            MessageBox.Show("New Course Inserted", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            textBox_courseid.Text = "";
                            textBox_name.Text = "";
                            textBox_period.Text = "";
                            textBox_description.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("Course Not Inserted", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("This Course Name Already Exists", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void textBox_courseid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                errorProvider_id.SetError(textBox_courseid, "Do not use letter!");
            }
            else
            {
                errorProvider_id.SetError(textBox_courseid, null);
            }
        }

        private void textBox_period_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                errorProvider_period.SetError(textBox_period, "Do not use letter!");
            }
            else
            {
                errorProvider_period.SetError(textBox_period, null);
            }
        }

        private void AddCourse_Load(object sender, EventArgs e)
        {
            Course course = new Course();   
            SqlCommand cmd = new SqlCommand("SELECT id, CONCAT(fname,' ',lname) as name FROM Contact");
            comboBox1.DataSource = course.getCourse(cmd);
            comboBox1.ValueMember = "id";
            comboBox1.DisplayMember = "name";
            comboBox1.SelectedItem = null;
        }
    }
}
