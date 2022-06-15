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
    public partial class StaticResultForm : Form
    {
        public StaticResultForm()
        {
            InitializeComponent();
        }
        Score score = new Score();
        Student student = new Student();
        private void StaticResultForm_Load(object sender, EventArgs e)
        {
            DataTable dt = score.getAvg();
            label_CSharf.Text = "C#: " + Convert.ToDouble(dt.Rows[0]["AverageGrade"]).ToString("0.00");
            label_java.Text = "Java: " + Convert.ToDouble(dt.Rows[2]["AverageGrade"]).ToString("0.00");
            label_cloudcomputing.Text = "Cloud Computing: " + Convert.ToDouble(dt.Rows[1]["AverageGrade"]).ToString("0.00");
            label_machinelearning.Text = "Machine Learning: " + Convert.ToDouble(dt.Rows[3]["AverageGrade"]).ToString("0.00");

            double totalStudent = Convert.ToDouble(student.totalStudent());
            double pass = Convert.ToDouble(score.totalPasstudent());
            double fail = Convert.ToDouble(score.totalFailStudent());

            double passpercent = (pass * (100 / totalStudent));
            double failpercent = (fail * (100 / totalStudent));

            label_pass.Text = ("Pass: " + passpercent.ToString("0.00") + "%");
            label_fail.Text = ("Fail: " + failpercent.ToString("0.00") + "%");

            double passpercentchart = (pass * (1.0 / totalStudent));
            double failpercentchart = (fail * (1.0 / totalStudent));

            chart_result.Series["Charts"].IsValueShownAsLabel = true;
            chart_result.Series["Charts"].Points.AddXY("Pass", passpercentchart);
            chart_result.Series["Charts"].Points.AddXY("Fail", failpercentchart);

            double yeu = Convert.ToDouble(score.totalYstudent());
            double TB = Convert.ToDouble(score.totalTBstudent());
            double Kha = Convert.ToDouble(score.totalKstudent());
            double Gioi = Convert.ToDouble(score.totalGstudent());
            double XX = Convert.ToDouble(score.totalXXstudent());

            double yeulb = (yeu * (100 / totalStudent));
            double TBlb = (TB * (100 / totalStudent));
            double Khalb = (Kha * (100 / totalStudent));
            double Gioilb = (Gioi * (100 / totalStudent));
            double XXlb = (XX * (100 / totalStudent));

            label_xx.Text = ("Xuất xắc: " + XXlb.ToString("0.00") + "%");
            label_g.Text = ("Giỏi: " + Gioilb.ToString("0.00") + "%");
            label_k.Text = ("Khá: " + Khalb.ToString("0.00") + "%");
            label_tb.Text = ("Trung bình: " + TBlb.ToString("0.00") + "%");
            label_y.Text = ("Yếu: " + yeulb.ToString("0.00") + "%");


            double yeupercent = (yeu *(1.0 / totalStudent));
            double TBpercent = (TB * (1.0 / totalStudent));
            double Khapercent = (Kha * (1.0 / totalStudent));
            double Gioipercent = (Gioi * (1.0 / totalStudent));
            double XXpercent = (XX * (1.0 / totalStudent));

            chart_Classification.Series["Chart"].IsValueShownAsLabel = true;
            chart_Classification.Series["Chart"].Points.AddXY("Yếu", yeupercent);
            chart_Classification.Series["Chart"].Points.AddXY("Trung Bình", TBpercent);
            chart_Classification.Series["Chart"].Points.AddXY("Khá", Khapercent);
            chart_Classification.Series["Chart"].Points.AddXY("Giỏi", Gioipercent);
            chart_Classification.Series["Chart"].Points.AddXY("Xuất xắc", XXpercent);
        }
    }
}
