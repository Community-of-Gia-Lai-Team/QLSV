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
    public partial class avgScoreByCourseForm : Form
    {
        public avgScoreByCourseForm()
        {
            InitializeComponent();
        }

        Score score = new Score();
        private void avgScoreByCourseForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = score.getAvg();
            dataGridView1.ReadOnly = true;
            dataGridView1.Columns[0].HeaderText = "Label";
            dataGridView1.Columns[1].HeaderText = "AverageGrade";
            dataGridView1.Columns[1].DefaultCellStyle.Format = "0.00";
            dataGridView1.AllowUserToAddRows = false;
        }
    }
}
