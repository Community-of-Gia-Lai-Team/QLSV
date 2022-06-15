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
    public partial class HumanResource : Form
    {
        public HumanResource()
        {
            InitializeComponent();
        }
        MY_DB db = new MY_DB();
        GroupClass group = new GroupClass();
        Contacts contacts = new Contacts();
        public void getImageandUser()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM hr WHERE Id = @id",db.getConnection);
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = Globals.GlobalUserID;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            if(dt.Rows.Count > 0)
            {
                byte[] pic = (byte[])dt.Rows[0]["fig"];
                MemoryStream picture = new MemoryStream(pic);
                pictureBox1.Image = Image.FromStream(picture);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

                label1.Text = "Welcome Back (" + dt.Rows[0]["uname"].ToString().Trim()+")";
            }
        }

        public void Reload()
        {
            comboBox1.DataSource = group.getGroup(Globals.GlobalUserID);
            comboBox1.DisplayMember = "name";
            comboBox1.ValueMember = "id";

            comboBox_selectgroup.DataSource = group.getGroup(Globals.GlobalUserID);
            comboBox_selectgroup.DisplayMember = "name";
            comboBox_selectgroup.ValueMember = "id";
        }

        private void HumanResource_Load(object sender, EventArgs e)
        {
            getImageandUser();
            Reload();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            AddContactForm addContactForm = new AddContactForm();
            addContactForm.Show(this);
        }
        private void button_addgroup_Click(object sender, EventArgs e)
        {
            if (textBox_entergroupname.Text.Trim() == "" || textBox_idgroup.Text.Trim() == "")
            {
                MessageBox.Show("Empty Fields", "Add Group", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                    int id = Convert.ToInt32(textBox_idgroup.Text);
                    string name = textBox_entergroupname.Text;
                    int userid = Globals.GlobalUserID;
                    string code = "Add";
                    if (group.GroupExist(name, code, userid, id) || group.IDGroupExist(id,name))
                    {
                        MessageBox.Show("Group already exists", "Add Group", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (group.insertGroup(id, name, userid))
                        {
                            MessageBox.Show("New Group Added", "Add Group", MessageBoxButtons.OK, MessageBoxIcon.Information);
                             Reload();
                            textBox_entergroupname.Text = "";
                            textBox_idgroup.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("Error", "Add Group", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
            }
        }

        private void button_remove_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(comboBox1.SelectedValue);
                if ((MessageBox.Show("Are You Sure You Want To Delete This Group ", "Delete Group", MessageBoxButtons.YesNo, MessageBoxIcon.Question)) == DialogResult.Yes)
                {
                    if (group.deleteGroup(id))
                    {
                        MessageBox.Show("Group Deleted", "Delete Group", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Reload();
                    }
                    else
                    {
                        MessageBox.Show("Group not Deleted", "Delete Group", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_editgroup_Click(object sender, EventArgs e)
        {
            if (textBox_enternewname.Text.Trim() == "")
            {
                MessageBox.Show("Empty Fields", "Edit Group", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    int id = Convert.ToInt32(comboBox_selectgroup.SelectedValue);
                    string name = textBox_enternewname.Text;
                    int userid = Globals.GlobalUserID;
                    string code = "Edit";
                    if (group.GroupExist(name, code,userid, id))
                    {
                        MessageBox.Show("Group already exists", "Edit Group", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (group.updateGroup(id,name))
                        {
                            MessageBox.Show("New Group Edited", "Edit Group", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Reload();
                            textBox_enternewname.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("Error", "Edit Group", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message,"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button_edit_Click(object sender, EventArgs e)
        {
            EditContactForm form = new EditContactForm();
            form.Show(this);
        }

        private void button_selectcontact_Click(object sender, EventArgs e)
        {
            SelectContactForm SelectContactF = new SelectContactForm();
            SelectContactF.ShowDialog();

            try
            {
                int contactId = Convert.ToInt32(SelectContactF.dataGridView1.CurrentRow.Cells[0].Value.ToString());

                DataTable table = contacts.GetContactByID(contactId);

                textBox_enterid.Text = table.Rows[0]["id"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_remove_Click(object sender, EventArgs e)
        {
            if(textBox_enterid.Text.Trim() == "")
            {
                MessageBox.Show("Empty Field", "Remove Contact", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            else 
            { 
                int id = Convert.ToInt32(textBox_enterid.Text.Trim());
                if ((MessageBox.Show("Are You Sure You Want To Delete This Contact ", "Delete Contact", MessageBoxButtons.YesNo, MessageBoxIcon.Question)) == DialogResult.Yes)
                {
                    if (contacts.deleteContact(id))
                    {
                        MessageBox.Show("Contact Deleted", "Delete Contact", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Reload();
                        textBox_enterid.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Contact not Deleted", "Delete Contact", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Contact_Full_List_Form cfl = new Contact_Full_List_Form();
            cfl.Show(this);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            UpdateHrForm hr = new UpdateHrForm();
            hr.Show(this);
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void textBox_idgroup_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                errorProvider_id.SetError(textBox_idgroup, "Do not use letter!");
            }
            else
            {
                errorProvider_id.SetError(textBox_idgroup, null);
            }
        }
    }
}
