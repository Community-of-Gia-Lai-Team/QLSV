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
    public partial class Contact_Full_List_Form : Form
    {
        public Contact_Full_List_Form()
        {
            InitializeComponent();
        }
        public static int idcontact = 0;

        public bool IsOdd(int value)
        {
            return value % 2 != 0;
        }

        Contacts contact = new Contacts();
        GroupClass gp = new GroupClass();
        private void Contact_Full_List_Form_Load(object sender, EventArgs e)
        {
            DataGridViewImageColumn picol = new DataGridViewImageColumn();
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 80;
            dataGridView1.AllowUserToAddRows = false;
            SqlCommand cmd = new SqlCommand(@"SELECT Contact.id,fname, lname, gp.name, phone, email, address, pic FROM Contact INNER JOIN 
                                                gp ON Contact.group_id = gp.id WHERE Contact.userid = @userid");
            cmd.Parameters.Add("@userid", SqlDbType.Int).Value = Globals.GlobalUserID;
            dataGridView1.DataSource = contact.SelectContactList(cmd);
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows=false;
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[1].HeaderText = "Fisrt name";
            dataGridView1.Columns[2].HeaderText = "Last name";
            dataGridView1.Columns[3].HeaderText = "Group name";
            dataGridView1.Columns[4].HeaderText = "SĐT";
            dataGridView1.Columns[5].HeaderText = "Email";
            dataGridView1.Columns[6].HeaderText = "Address";
            dataGridView1.Columns[7].HeaderText = "Picture";
            picol = (DataGridViewImageColumn)dataGridView1.Columns[7];
            picol.ImageLayout = DataGridViewImageCellLayout.Stretch;

            for(int i = 0;i < dataGridView1.Rows.Count; i++)
            {
                if (IsOdd(i))
                {
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.WhiteSmoke;
                }
            }

            listBox1.DataSource = gp.getGroup(Globals.GlobalUserID);
            listBox1.DisplayMember = "name";
            listBox1.ValueMember = "id";
            listBox1.SelectedItem = null;
            dataGridView1.ClearSelection();
        }

        private void dataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (IsOdd(i))
                {
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.WhiteSmoke;
                }
            }
        }

        private void listBox1_Click(object sender, EventArgs e)
        {
            try
            {
                int group_id = (Int32)listBox1.SelectedValue;
                SqlCommand cmd = new SqlCommand(@"SELECT fname, lname, gp.name, phone, email, address, pic FROM Contact INNER JOIN
                                                    gp ON Contact.group_id = gp.id WHERE Contact.userid = @user_id AND Contact.group_id = @group_id");
                cmd.Parameters.Add("@user_id", SqlDbType.Int).Value = Globals.GlobalUserID;
                cmd.Parameters.Add("@group_id",SqlDbType.Int).Value = group_id;
                dataGridView1.DataSource = contact.SelectContactList(cmd);

                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    if (IsOdd(i))
                    {
                        dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.WhiteSmoke;
                    }
                }
            }
            catch (Exception) {  }
            dataGridView1.ClearSelection();
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            try
            {
                textBox_fulladdress.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                idcontact = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                ManageScore frm = new ManageScore();
                frm.ShowDialog();
            }
            catch(Exception) { }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Contact_Full_List_Form_Load(null, null);
        }
    }
}
