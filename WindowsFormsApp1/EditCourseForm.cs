using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class EditCourseForm : Form
    {
        public EditCourseForm()
        {
            InitializeComponent();
        }

        Course course = new Course();
        private void EditCourseForm_Load(object sender, EventArgs e)
        {
            comboBox_course.DisplayMember = "label";
            comboBox_course.ValueMember = "id";
            comboBox_course.SelectedItem = null;
            comboBox_course.DataSource = course.getAllCourses();

            SqlCommand cmd = new SqlCommand("SELECT id, CONCAT(fname,' ',lname) as name FROM Contact");
            comboBox1.DataSource = course.getCourse(cmd);
            comboBox1.ValueMember = "id";
            comboBox1.DisplayMember = "name";
        }

        public void fillcombo(int index)
        {
            comboBox_course.DataSource = course.getAllCourses();
            comboBox_course.DisplayMember = "label";
            comboBox_course.ValueMember = "id";
            comboBox_course.SelectedIndex = index;
        }

        private void comboBox_course_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(comboBox_course.SelectedValue);
                DataTable dt = new DataTable();
                dt = course.getCourseID(id);
                textBox_label.Text = dt.Rows[0][1].ToString();
                numericUpDown_period.Value = Int32.Parse(dt.Rows[0][2].ToString());
                textBox_description.Text = dt.Rows[0][3].ToString();
                comboBox1.SelectedValue = dt.Rows[0][4].ToString();
            }
            catch
            {
            }
        }

        private void button_edit_Click(object sender, EventArgs e)
        {
            string name = textBox_label.Text;
            int period = (int) numericUpDown_period.Value;
            string description = textBox_description.Text;
            int id = (int) comboBox_course.SelectedValue;
            int idcontact = Convert.ToInt32(comboBox1.SelectedValue);

            if (!course.checkCourseName(name, Convert.ToInt32(comboBox_course.SelectedValue))){
                MessageBox.Show("This Course Name Already Exist","Edit Course",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
            else if (course.updateCourse(id, name, period, description,idcontact))
            {
                MessageBox.Show("Course Updated", "Edit Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                fillcombo(comboBox_course.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Course Not Update", "Edit Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
