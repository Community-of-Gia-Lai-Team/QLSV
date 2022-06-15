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
    public partial class Searchfname : Form
    {
        public Searchfname()
        {
            InitializeComponent();
        }
        Student st = new Student();
        private void Searchfname_Load(object sender, EventArgs e)
        {
        //TODO: This line of code loads data into the 'viduDataSet.std' table.You can move, or remove it, as needed.
          //  this.stdTableAdapter.Fill(this.viduDataSet.std);
            SqlCommand command = new SqlCommand("SELECT * FROM std WHERE fname LIKE '%" + UpdateDeleteStudentForm.Thongtin.firstname + "%'");
            dataGridView1.ReadOnly = true;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            dataGridView1.RowTemplate.Height = 80;
            dataGridView1.DataSource = st.getStudent(command);
            picCol = (DataGridViewImageColumn)dataGridView1.Columns[7];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridView1.AllowUserToAddRows = false;

        }
    }
}
