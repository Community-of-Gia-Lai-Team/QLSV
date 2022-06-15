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
    public partial class Chart : Form
    {
        public Chart()
        {
            InitializeComponent();
        }
        Student student = new Student();
        private void Chart_Load(object sender, EventArgs e)
        {
            double total = Convert.ToDouble(student.totalStudent());
            double male = Convert.ToDouble(student.totalMaleStudent());
            double female = Convert.ToDouble(student.totalFemaleStudent());

            double malestudentpercent = (male * (1.0 / total));
            double femalestudentpercent = (female * (1.0 / total));

            chart1.Series["ChartS"].IsValueShownAsLabel = true;
            chart1.Series["ChartS"].Points.AddXY("Male", malestudentpercent);
            chart1.Series["ChartS"].Points.AddXY("Female", femalestudentpercent);
        }
    }
}
