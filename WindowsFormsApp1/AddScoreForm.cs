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
    public partial class AddScoreForm : Form
    {
        public AddScoreForm()
        {
            InitializeComponent();
        }
        Score score = new Score();
        Course course = new Course();
        Student student = new Student();
        private void AddScoreForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'viduDataSet4.std' table. You can move, or remove it, as needed.
          //  this.stdTableAdapter.Fill(this.viduDataSet4.std);
            comboBox_course.DataSource = course.getAllCourses();
            comboBox_course.DisplayMember = "label";
            comboBox_course.ValueMember = "id";

            SqlCommand cmd = new SqlCommand("SELECT id,fname,lname FROM std");
            dataGridView1.DataSource = student.getStudent(cmd);
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ReadOnly = true;
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            textBox_studentid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            if (textBox_studentid.Text.Trim() == "" || textBox_score.Text.Trim() == "" || textBox_des.Text.Trim() == "")
            {
                MessageBox.Show("Empty Fields", "Add Contact", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    int studentid = Convert.ToInt32(textBox_studentid.Text);
                    int courseid = Convert.ToInt32(comboBox_course.SelectedValue);
                    float scores = Convert.ToInt32(textBox_score.Text);
                    string des = textBox_des.Text;

                    if (scores > 10)
                    {
                        MessageBox.Show("Score cannot exceed 10", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (!score.studentScoreExist(studentid, courseid))
                    {
                        if (score.insertScore(studentid, courseid, scores, des))
                        {
                            MessageBox.Show("Student Score Inserted", "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Student Score Not Inserted", "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        }
                    }
                    else
                    {
                        MessageBox.Show("The Score For This Course Are Already Set", "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox_studentid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                errorProvider_id.SetError(textBox_studentid, "Do not use letter!");
            }
            else
            {
                errorProvider_id.SetError(textBox_studentid, null);
            }
        }

        private void textBox_score_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                errorProvider_score.SetError(textBox_score, "Do not use letter!");
            }
            else
            {
                errorProvider_score.SetError(textBox_score, null);
            }
        }
    }
}
