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

namespace WindowsFormsApp1
{
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
        }
        private void Login_Form_Load(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.IsBalloon = true;
            toolTip.SetToolTip(tB_username, "Nhập user");
            toolTip.SetToolTip(tB_password, "Nhập pass");
        }
        MY_DB db = new MY_DB();
        private void bt_login_Click(object sender, EventArgs e)
        {
            if (radioButton_student.Checked)
            {
                SqlDataAdapter adapter = new SqlDataAdapter();

                DataTable dt = new DataTable();

                SqlCommand cmd = new SqlCommand("SELECT username,password FROM log_in WHERE username = @User and password = @Pass", db.getConnection);

                cmd.Parameters.Add("@User", SqlDbType.VarChar).Value = tB_username.Text;
                cmd.Parameters.Add("@Pass", SqlDbType.VarChar).Value = tB_password.Text;

                adapter.SelectCommand = cmd;

                adapter.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Invalid Username or PassWord", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (radioButton_human.Checked)
            {
                SqlDataAdapter adapter = new SqlDataAdapter();

                DataTable dt = new DataTable();

                SqlCommand cmd = new SqlCommand("SELECT Id,uname,pwd FROM hr WHERE uname = @User and pwd = @Pass", db.getConnection);

                cmd.Parameters.Add("@User", SqlDbType.NChar).Value = tB_username.Text;
                cmd.Parameters.Add("@Pass", SqlDbType.NChar).Value = tB_password.Text;

                adapter.SelectCommand = cmd;

                adapter.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    int id = Convert.ToInt32(dt.Rows[0]["ID"].ToString());
                    Globals.SetGlobalUserID(id);
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Invalid Username or PassWord", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        RegisterForm registerForm = new RegisterForm();
        RegisterHR registerHR = new RegisterHR();
        private void button_register_Click(object sender, EventArgs e)
        {
            if (radioButton_student.Checked)
            {
                registerForm.Show(this);
            }
            else if (radioButton_human.Checked)
            {
                registerHR.Show(this);
            }
        }

        private void bt_cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tB_username_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tB_username.Text))
            {
                e.Cancel = true;
                tB_username.Focus();
                error_user.SetError(tB_username, "Please enter your user!");
            }
            else
            {
                e.Cancel = false;
                error_user.SetError(tB_username, null);
            }
        }

        private void button_Resetpassword_Click(object sender, EventArgs e)
        {
            if (radioButton_student.Checked)
            {
                Resetpass reset = new Resetpass();
                reset.Show(this);
            }
            else if (radioButton_human.Checked)
            {
                UpdateHrForm hr = new UpdateHrForm();
                hr.Show(this);
            }
        }

        private void checkBox_hienthimk_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_hienthimk.Checked)
            {
                tB_password.PasswordChar = (char)0;
            }
            else
            {
                tB_password.PasswordChar = '*';
            }
        }

        private void tB_password_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar))
            {
                e.Handled = true;
                error_pass.SetError(tB_password, "Do not use special characters!");
            }
            else
            {
                error_pass.SetError(tB_password, null);
            }
        }

        private void tB_password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bt_login.PerformClick();
            }
        }
    }
}
