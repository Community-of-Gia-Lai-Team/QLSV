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
    public partial class SelectContactForm : Form
    {
        public SelectContactForm()
        {
            InitializeComponent();
        }
        private void SelectContactForm_Load(object sender, EventArgs e)
        {
            Contacts contact = new Contacts();
            SqlCommand command = new SqlCommand("SELECT  id ,  fname,  lname,  group_id  FROM  Contact  WHERE  userid  = @uid");
            command.Parameters.Add("@uid", SqlDbType.Int).Value = Globals.GlobalUserID;
            dataGridView1.ReadOnly = true;
            dataGridView1.DataSource = contact.SelectContactList(command);
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[1].HeaderText = "First name";
            dataGridView1.Columns[2].HeaderText = "Last name";
            dataGridView1.Columns[3].HeaderText = "Group ID";
            dataGridView1.AllowUserToAddRows = false;
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            Close();
        }
    }
}
