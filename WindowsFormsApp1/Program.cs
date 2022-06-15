using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
         //  Application.Run(new Login_Form());
            Login_Form login = new Login_Form();
            if (login.ShowDialog() == DialogResult.OK)
            {
                if (login.radioButton_student.Checked)
                {
                    Application.Run(new ProgressBar());
                }
                else if (login.radioButton_human.Checked)
                {
                    Application.Run(new HumanResource());
                }
            }
            else
            {
                Application.Exit();
            }
        }
    }
}
