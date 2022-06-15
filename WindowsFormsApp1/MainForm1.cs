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
    public partial class MainForm1 : Form
    {
        public MainForm1()
        {
            InitializeComponent();
        }

        private void MenuStrip_Addstudent_Click(object sender, EventArgs e)
        {
            AddStudentForm astd = new AddStudentForm();
            astd.Show(this);
        }

        private void MenuStrip_Studentlist_Click(object sender, EventArgs e)
        {
            Studentlistform stdlist = new Studentlistform();
            stdlist.Show(this);
        }

        private void MenuStrip_EditRemove_Click(object sender, EventArgs e)
        {
            UpdateDeleteStudentForm updateDeleteStudentForm = new UpdateDeleteStudentForm();
            updateDeleteStudentForm.Show(this);
        }

        private void MenuStrip_ManageStudentForm_Click(object sender, EventArgs e)
        {
            ManageStudentForm manageStudentForm = new ManageStudentForm();
            manageStudentForm.Show(this);
        }

        private void MenuStrip_Statics_Click(object sender, EventArgs e)
        {
            Statics statics = new Statics();
            statics.Show(this);
        }

        private void MenuStrip_Print_Click(object sender, EventArgs e)
        {
            Print print = new Print();
            print.Show(this);
        }

        private void addCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCourse addcourse = new AddCourse();
            addcourse.Show(this);
        }

        private void removeCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveCourseForm removecourseForm = new RemoveCourseForm();
            removecourseForm.Show(this);
        }

        private void editCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditCourseForm editCourseForm = new EditCourseForm();
            editCourseForm.Show(this);
        }

        private void manageCoursesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageCourseForm manageCourse = new ManageCourseForm();
            manageCourse.Show(this);    
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintCourseForm printCourse = new PrintCourseForm();
            printCourse.Show(this);
        }

        private void addScoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddScoreForm addScoreForm = new AddScoreForm();
            addScoreForm.Show(this);
        }

        private void removeScoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveScoreForm removeScoreForm = new RemoveScoreForm();
            removeScoreForm.Show(this);
        }

        private void manageScoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageScore manageScore = new ManageScore();
            manageScore.Show(this);
        }

        private void chartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Chart chart = new Chart();  
            chart.Show(this);
        }

        private void avgScoreByCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            avgScoreByCourseForm avgScoreByCourseForm = new avgScoreByCourseForm();
            avgScoreByCourseForm.Show(this);
        }

        private void aVGResultByScoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            avgResultByScoreForm avgResultByScoreForm = new avgResultByScoreForm();
            avgResultByScoreForm.Show(this);
        }

        private void staticResultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StaticResultForm staticResultForm = new StaticResultForm();
            staticResultForm.Show(this);
        }

        private void printResultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintResultScore printResultScore = new PrintResultScore();
            printResultScore.Show(this);
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
