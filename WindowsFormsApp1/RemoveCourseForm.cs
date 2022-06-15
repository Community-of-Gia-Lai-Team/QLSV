using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class RemoveCourseForm : Form
    {
        public RemoveCourseForm()
        {
            InitializeComponent();
        }

        Course course = new Course();

        private void button_remove_Click(object sender, EventArgs e)
        {
            try
            {
                int CourseID = Convert.ToInt32(textBox_enter_id.Text);
                if ((MessageBox.Show("Are You Sure You Want To Delete This Course ", "Delete Course", MessageBoxButtons.YesNo, MessageBoxIcon.Question)) == DialogResult.Yes)
                {
                    if (course.deleteCourse(CourseID))
                    {
                        MessageBox.Show("Course Deleted", "Delete Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textBox_enter_id.Text = "";
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
        }

        private void textBox_enter_id_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                errorProvider_id.SetError(textBox_enter_id, "Do not use letter!");
            }
            else
            {
                errorProvider_id.SetError(textBox_enter_id, null);
            }
        }
    }
}
