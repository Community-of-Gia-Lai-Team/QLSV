using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;


namespace WindowsFormsApp1
{
    public partial class Studentlistform : Form
    {
        public Studentlistform()
        {
            InitializeComponent();
        }
        Student st = new Student();
        private void Studentlistform_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'viduDataSet.std' table. You can move, or remove it, as needed.
           // this.stdTableAdapter.Fill(this.viduDataSet.std);
            SqlCommand cmd = new SqlCommand("SELECT * FROM std ORDER BY id");
            DataGridView1.ReadOnly = true;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            DataGridView1.RowTemplate.Height = 80;
            DataGridView1.DataSource = st.getStudent(cmd);
            picCol = (DataGridViewImageColumn)DataGridView1.Columns[7];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            DataGridView1.AllowUserToAddRows = false;
            DataGridView1.Columns[3].DefaultCellStyle.Format = "dd/MM/yyyy";
        }

        private void Bt_Refresh_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM std ORDER BY id");
            DataGridView1.ReadOnly = true;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            DataGridView1.RowTemplate.Height = 80;
            DataGridView1.DataSource = st.getStudent(cmd);
            picCol = (DataGridViewImageColumn)DataGridView1.Columns[7];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            DataGridView1.AllowUserToAddRows = false;
        }

        private void DataGridView1_DoubleClick(object sender, EventArgs e)
        {
            UpdateDeleteStudentForm updateDeletestdf = new UpdateDeleteStudentForm();
            updateDeletestdf.textBox_ID.Text = DataGridView1.CurrentRow.Cells[0].Value.ToString();
            updateDeletestdf.textBox_firstname.Text = DataGridView1.CurrentRow.Cells[1].Value.ToString();
            updateDeletestdf.textBox_lastname.Text = DataGridView1.CurrentRow.Cells[2].Value.ToString();
            updateDeletestdf.dateTimePicker1.Value = (DateTime)DataGridView1.CurrentRow.Cells[3].Value;

            if(DataGridView1.CurrentRow.Cells[4].ToString() == "Female")
            {
                updateDeletestdf.radioButton_female.Checked = true;
            }

            updateDeletestdf.textBox_phone.Text = DataGridView1.CurrentRow.Cells[5].Value.ToString();
            updateDeletestdf.textBox_address.Text = DataGridView1.CurrentRow.Cells[6].Value.ToString();

            byte[] pic;

            pic = (byte[])DataGridView1.CurrentRow.Cells [7].Value;
            MemoryStream picture = new MemoryStream(pic);
            updateDeletestdf.pictureBox_student.Image = Image.FromStream(picture);
            updateDeletestdf.Show();
        }
    }
}
