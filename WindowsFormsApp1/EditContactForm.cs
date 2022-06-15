using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class EditContactForm : Form
    {
        public EditContactForm()
        {
            InitializeComponent();
        }
        public bool verif()
        {
            if (textBox_id.Text.Trim() == "" || textBox_fname.Text.Trim() == "" || textBox_lname.Text.Trim() == "" ||
                textBox_phone.Text.Trim() == "" || textBox_email.Text.Trim() == "" || pictureBox1.Image == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        Contacts contacts = new Contacts();
        GroupClass Group = new GroupClass();
        private void button_edit_Click(object sender, EventArgs e)
        {
            if (!verif())
            {
                MessageBox.Show("Empty Fields", "Edit Contact", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    int id = Convert.ToInt32(textBox_id.Text);
                    string fname = textBox_fname.Text;
                    string lname = textBox_lname.Text;
                    int group = Convert.ToInt32(comboBox_group.SelectedValue);
                    string phone = textBox_phone.Text;
                    string email = textBox_email.Text;
                    string address = textBox_address.Text;
                    MemoryStream pic = new MemoryStream();
                    pictureBox1.Image.Save(pic, pictureBox1.Image.RawFormat);
                    if (contacts.updateContact(id, fname, lname, phone, address, email, group, pic))
                    {
                        MessageBox.Show("Contact Inormation UpDated", "Edit Contact", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (contacts.Checkemail(email))
                    {
                        MessageBox.Show("This Email Already Exists", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (contacts.Checkphone(phone))
                    {
                        MessageBox.Show("This Phone Already Exists", "Invalid Phone", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show("Error", "Edit Contact", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message,"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void EditContactForm_Load(object sender, EventArgs e)
        {
            comboBox_group.DataSource = Group.getGroup(Globals.GlobalUserID);
            comboBox_group.DisplayMember = "name";
            comboBox_group.ValueMember = "id";

            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SelectContactForm SelectContactF = new SelectContactForm();
            SelectContactF.ShowDialog();

            try
            {

                int contactId = Convert.ToInt32(SelectContactF.dataGridView1.CurrentRow.Cells[0].Value.ToString());

                DataTable table = contacts.GetContactByID(contactId);

                textBox_id.Text = table.Rows[0]["id"].ToString();
                textBox_fname.Text = table.Rows[0]["fname"].ToString();
                textBox_lname.Text = table.Rows[0]["lname"].ToString();
                comboBox_group.SelectedValue = table.Rows[0]["group_id"];
                textBox_phone.Text = table.Rows[0]["phone"].ToString();
                textBox_email.Text = table.Rows[0]["email"].ToString();
                textBox_address.Text = table.Rows[0]["address"].ToString();

                byte[] pic = (byte[])table.Rows[0]["pic"];
                MemoryStream picture = new MemoryStream(pic);
                pictureBox1.Image = Image.FromStream(picture);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button_upload_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image (*.jpg;*.png;*.gif) | *.jpg;*.png;*.gif";

            if (opf.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(opf.FileName);
            }
        }

        private void textBox_id_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                errorProvider_id.SetError(textBox_id, "Do not use letter!");
            }
            else
            {
                errorProvider_id.SetError(textBox_id, null);
            }
        }

        private void textBox_fname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                errorProvider_fname.SetError(textBox_fname, "Do not use number!");
            }
            else
            {
                errorProvider_fname.SetError(textBox_fname, null);
            }
        }

        private void textBox_lname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                errorProvider_lname.SetError(textBox_lname, "Do not use number!");
            }
            else
            {
                errorProvider_lname.SetError(textBox_lname, null);
            }
        }

        private void textBox_phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                errorProvider_phone.SetError(textBox_phone, "Do not use letter!");
            }
            else
            {
                errorProvider_phone.SetError(textBox_phone, null);
            }
        }

        private void textBox_email_Validating(object sender, CancelEventArgs e)
        {
            if (textBox_email.Text.EndsWith("@gmail.com"))
            {
                e.Cancel = false;
                errorProvider_email.SetError(textBox_email, "Invalid Email");
            }
            else
            {
                e.Cancel = true;
                errorProvider_email.SetError(textBox_email, null);
            }
        }
    }
}
