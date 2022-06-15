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
    public partial class RemoveScoreForm : Form
    {
        public RemoveScoreForm()
        {
            InitializeComponent();
        }
        int student_id, course_id;
        Score score = new Score();
        private void RemoveScoreForm_Load(object sender, EventArgs e)
        {
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 80;
            dataGridView1.DataSource = score.getStudentScore();
            dataGridView1.AllowUserToAddRows = false;
        }

        public void Refreshs()
        {
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 80;
            dataGridView1.DataSource = score.getStudentScore();
            dataGridView1.AllowUserToAddRows = false;
        }

        private void button_remove_Click(object sender, EventArgs e)
        {
            try
            {
                if ((MessageBox.Show("Are You Sure You Want To Delete This Course ", "Delete Course", MessageBoxButtons.YesNo, MessageBoxIcon.Question)) == DialogResult.Yes)
                {
                    if (score.deleteScore(student_id,course_id))
                    {
                        MessageBox.Show("Score Deleted", "Delete Score", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Refreshs();
                    }
                    else
                    {
                        MessageBox.Show("Score Not Deleted", "Delete Score", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Please Enter A Valid Course ID and Student ID", "Delete Score", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            student_id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            course_id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[3].Value.ToString());
        }
    }
}
