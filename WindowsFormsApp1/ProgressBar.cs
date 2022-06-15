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
    public partial class ProgressBar : Form
    {
        public ProgressBar()
        {
            InitializeComponent();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            MainForm1 mainForm1 = new MainForm1();
            progressBar1.Increment(10);
            label_progressbar.Text = "Connecting to from " + progressBar1.Value.ToString();
            if (progressBar1.Value == progressBar1.Maximum)
            {
                timer1.Enabled = false;
                this.Visible = false;
                mainForm1.ShowDialog();
                this.Close();
            }
            
        }

        private void ProgressBar_Load(object sender, EventArgs e)
        {
            if (progressBar1.Enabled == true)
            {
                progressBar1.Enabled = false;
                timer1.Start();
            }
            else
            {
                progressBar1.Enabled = true;
                timer1.Stop();
            }
        }
    }
}
