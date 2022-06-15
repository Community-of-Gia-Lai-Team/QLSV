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
    public partial class CodeHrform : Form
    {
        public CodeHrform()
        {
            InitializeComponent();
        }

        private void button_confirm_Click(object sender, EventArgs e)
        {
            int veri = Convert.ToInt32(textBox_code.Text);
            int code = Convert.ToInt32(UpdateHrForm.dd);
            if (veri == code)
            {
                MessageBox.Show("Verification code correct", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Confirmation code is incorrect,Please re-enter", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                textBox_code.Text = "";
            }
        }
    }
}
