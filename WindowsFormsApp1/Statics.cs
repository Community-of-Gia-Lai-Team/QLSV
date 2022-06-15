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
    public partial class Statics : Form
    {
        public Statics()
        {
            InitializeComponent();
        }
        Student student = new Student();

        Color PanTotalStudentColor;
        Color PanMaleColor;
        Color PanFemaleColor;
        private void Statics_Load(object sender, EventArgs e)
        {
            PanTotalStudentColor = panel_total.BackColor;
            PanMaleColor = panel_male.BackColor;
            PanFemaleColor = panel_female.BackColor;

            double total = Convert.ToDouble(student.totalStudent());
            double male = Convert.ToDouble(student.totalMaleStudent());
            double female = Convert.ToDouble(student.totalFemaleStudent());

            double malestudentpercent = (male * (100/total));
            double femalestudentpercent = (female * (100/total));

            label_total.Text = ("Total Student:" + total.ToString());
            label_male.Text = ("Male:" + (malestudentpercent.ToString("0.00") + "%"));
            label_female.Text = ("Female:" + (femalestudentpercent.ToString("0.00") +"%"));


        }

        private void label_total_MouseEnter(object sender, EventArgs e)
        {
            label_total.ForeColor = PanTotalStudentColor;
            panel_total.BackColor = Color.White;
        }

        private void label_male_MouseEnter(object sender, EventArgs e)
        {
            label_male.ForeColor = PanMaleColor;
            panel_male.BackColor = Color.White;
        }

        private void label_female_MouseEnter(object sender, EventArgs e)
        {
            label_female.ForeColor = PanFemaleColor;
            panel_female.BackColor = Color.White;
        }

        private void label_total_MouseLeave(object sender, EventArgs e)
        {
            label_total.ForeColor = Color.White;
            panel_total.BackColor = PanTotalStudentColor;
        }

        private void label_male_MouseLeave(object sender, EventArgs e)
        {
            label_male.ForeColor = Color.White;
            panel_male.BackColor = PanMaleColor;
        }

        private void label_female_MouseLeave(object sender, EventArgs e)
        {
            label_female.ForeColor = Color.White;
            panel_female.BackColor = PanFemaleColor;
        }
    }
}
