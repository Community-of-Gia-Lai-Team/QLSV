namespace WindowsFormsApp1
{
    partial class MainForm1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuStrip_Student = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip_Addstudent = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip_Studentlist = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip_Statics = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip_EditRemove = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip_ManageStudentForm = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip_Print = new System.Windows.Forms.ToolStripMenuItem();
            this.chartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip_Course = new System.Windows.Forms.ToolStripMenuItem();
            this.addCourseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeCourseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editCourseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageCoursesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip_Score = new System.Windows.Forms.ToolStripMenuItem();
            this.addScoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeScoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageScoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.avgScoreByCourseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printResultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip_Result = new System.Windows.Forms.ToolStripMenuItem();
            this.aVGResultByScoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.staticResultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuStrip_Student,
            this.MenuStrip_Course,
            this.MenuStrip_Score,
            this.MenuStrip_Result,
            this.logOutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 36);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuStrip_Student
            // 
            this.MenuStrip_Student.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuStrip_Addstudent,
            this.MenuStrip_Studentlist,
            this.MenuStrip_Statics,
            this.MenuStrip_EditRemove,
            this.MenuStrip_ManageStudentForm,
            this.MenuStrip_Print,
            this.chartToolStripMenuItem});
            this.MenuStrip_Student.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuStrip_Student.Name = "MenuStrip_Student";
            this.MenuStrip_Student.Size = new System.Drawing.Size(112, 32);
            this.MenuStrip_Student.Text = "STUDENT";
            // 
            // MenuStrip_Addstudent
            // 
            this.MenuStrip_Addstudent.BackColor = System.Drawing.Color.Orange;
            this.MenuStrip_Addstudent.Name = "MenuStrip_Addstudent";
            this.MenuStrip_Addstudent.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.MenuStrip_Addstudent.Size = new System.Drawing.Size(329, 32);
            this.MenuStrip_Addstudent.Text = "Add New Student";
            this.MenuStrip_Addstudent.Click += new System.EventHandler(this.MenuStrip_Addstudent_Click);
            // 
            // MenuStrip_Studentlist
            // 
            this.MenuStrip_Studentlist.BackColor = System.Drawing.Color.Orange;
            this.MenuStrip_Studentlist.Name = "MenuStrip_Studentlist";
            this.MenuStrip_Studentlist.Size = new System.Drawing.Size(329, 32);
            this.MenuStrip_Studentlist.Text = "Student List";
            this.MenuStrip_Studentlist.Click += new System.EventHandler(this.MenuStrip_Studentlist_Click);
            // 
            // MenuStrip_Statics
            // 
            this.MenuStrip_Statics.BackColor = System.Drawing.Color.Orange;
            this.MenuStrip_Statics.Name = "MenuStrip_Statics";
            this.MenuStrip_Statics.Size = new System.Drawing.Size(329, 32);
            this.MenuStrip_Statics.Text = "Statistical";
            this.MenuStrip_Statics.Click += new System.EventHandler(this.MenuStrip_Statics_Click);
            // 
            // MenuStrip_EditRemove
            // 
            this.MenuStrip_EditRemove.BackColor = System.Drawing.Color.Orange;
            this.MenuStrip_EditRemove.Name = "MenuStrip_EditRemove";
            this.MenuStrip_EditRemove.Size = new System.Drawing.Size(329, 32);
            this.MenuStrip_EditRemove.Text = "Edit / Remove";
            this.MenuStrip_EditRemove.Click += new System.EventHandler(this.MenuStrip_EditRemove_Click);
            // 
            // MenuStrip_ManageStudentForm
            // 
            this.MenuStrip_ManageStudentForm.BackColor = System.Drawing.Color.Orange;
            this.MenuStrip_ManageStudentForm.Name = "MenuStrip_ManageStudentForm";
            this.MenuStrip_ManageStudentForm.Size = new System.Drawing.Size(329, 32);
            this.MenuStrip_ManageStudentForm.Text = "Manage Student Form";
            this.MenuStrip_ManageStudentForm.Click += new System.EventHandler(this.MenuStrip_ManageStudentForm_Click);
            // 
            // MenuStrip_Print
            // 
            this.MenuStrip_Print.BackColor = System.Drawing.Color.Orange;
            this.MenuStrip_Print.Name = "MenuStrip_Print";
            this.MenuStrip_Print.Size = new System.Drawing.Size(329, 32);
            this.MenuStrip_Print.Text = "Print";
            this.MenuStrip_Print.Click += new System.EventHandler(this.MenuStrip_Print_Click);
            // 
            // chartToolStripMenuItem
            // 
            this.chartToolStripMenuItem.BackColor = System.Drawing.Color.Orange;
            this.chartToolStripMenuItem.Name = "chartToolStripMenuItem";
            this.chartToolStripMenuItem.Size = new System.Drawing.Size(329, 32);
            this.chartToolStripMenuItem.Text = "Chart";
            this.chartToolStripMenuItem.Click += new System.EventHandler(this.chartToolStripMenuItem_Click);
            // 
            // MenuStrip_Course
            // 
            this.MenuStrip_Course.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCourseToolStripMenuItem,
            this.removeCourseToolStripMenuItem,
            this.editCourseToolStripMenuItem,
            this.manageCoursesToolStripMenuItem,
            this.printToolStripMenuItem});
            this.MenuStrip_Course.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuStrip_Course.Name = "MenuStrip_Course";
            this.MenuStrip_Course.Size = new System.Drawing.Size(100, 32);
            this.MenuStrip_Course.Text = "COURSE";
            // 
            // addCourseToolStripMenuItem
            // 
            this.addCourseToolStripMenuItem.Name = "addCourseToolStripMenuItem";
            this.addCourseToolStripMenuItem.Size = new System.Drawing.Size(249, 32);
            this.addCourseToolStripMenuItem.Text = "Add Course";
            this.addCourseToolStripMenuItem.Click += new System.EventHandler(this.addCourseToolStripMenuItem_Click);
            // 
            // removeCourseToolStripMenuItem
            // 
            this.removeCourseToolStripMenuItem.Name = "removeCourseToolStripMenuItem";
            this.removeCourseToolStripMenuItem.Size = new System.Drawing.Size(249, 32);
            this.removeCourseToolStripMenuItem.Text = "Remove Course";
            this.removeCourseToolStripMenuItem.Click += new System.EventHandler(this.removeCourseToolStripMenuItem_Click);
            // 
            // editCourseToolStripMenuItem
            // 
            this.editCourseToolStripMenuItem.Name = "editCourseToolStripMenuItem";
            this.editCourseToolStripMenuItem.Size = new System.Drawing.Size(249, 32);
            this.editCourseToolStripMenuItem.Text = "Edit Course";
            this.editCourseToolStripMenuItem.Click += new System.EventHandler(this.editCourseToolStripMenuItem_Click);
            // 
            // manageCoursesToolStripMenuItem
            // 
            this.manageCoursesToolStripMenuItem.Name = "manageCoursesToolStripMenuItem";
            this.manageCoursesToolStripMenuItem.Size = new System.Drawing.Size(249, 32);
            this.manageCoursesToolStripMenuItem.Text = "Manage Courses";
            this.manageCoursesToolStripMenuItem.Click += new System.EventHandler(this.manageCoursesToolStripMenuItem_Click);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(249, 32);
            this.printToolStripMenuItem.Text = "Print";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.printToolStripMenuItem_Click);
            // 
            // MenuStrip_Score
            // 
            this.MenuStrip_Score.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addScoreToolStripMenuItem,
            this.removeScoreToolStripMenuItem,
            this.manageScoreToolStripMenuItem,
            this.avgScoreByCourseToolStripMenuItem,
            this.printResultToolStripMenuItem});
            this.MenuStrip_Score.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuStrip_Score.Name = "MenuStrip_Score";
            this.MenuStrip_Score.Size = new System.Drawing.Size(86, 32);
            this.MenuStrip_Score.Text = "SCORE";
            // 
            // addScoreToolStripMenuItem
            // 
            this.addScoreToolStripMenuItem.Name = "addScoreToolStripMenuItem";
            this.addScoreToolStripMenuItem.Size = new System.Drawing.Size(286, 32);
            this.addScoreToolStripMenuItem.Text = "Add Score";
            this.addScoreToolStripMenuItem.Click += new System.EventHandler(this.addScoreToolStripMenuItem_Click);
            // 
            // removeScoreToolStripMenuItem
            // 
            this.removeScoreToolStripMenuItem.Name = "removeScoreToolStripMenuItem";
            this.removeScoreToolStripMenuItem.Size = new System.Drawing.Size(286, 32);
            this.removeScoreToolStripMenuItem.Text = "Remove Score";
            this.removeScoreToolStripMenuItem.Click += new System.EventHandler(this.removeScoreToolStripMenuItem_Click);
            // 
            // manageScoreToolStripMenuItem
            // 
            this.manageScoreToolStripMenuItem.Name = "manageScoreToolStripMenuItem";
            this.manageScoreToolStripMenuItem.Size = new System.Drawing.Size(286, 32);
            this.manageScoreToolStripMenuItem.Text = "Manage Score";
            this.manageScoreToolStripMenuItem.Click += new System.EventHandler(this.manageScoreToolStripMenuItem_Click);
            // 
            // avgScoreByCourseToolStripMenuItem
            // 
            this.avgScoreByCourseToolStripMenuItem.Name = "avgScoreByCourseToolStripMenuItem";
            this.avgScoreByCourseToolStripMenuItem.Size = new System.Drawing.Size(286, 32);
            this.avgScoreByCourseToolStripMenuItem.Text = "Avg Score By Course";
            this.avgScoreByCourseToolStripMenuItem.Click += new System.EventHandler(this.avgScoreByCourseToolStripMenuItem_Click);
            // 
            // printResultToolStripMenuItem
            // 
            this.printResultToolStripMenuItem.Name = "printResultToolStripMenuItem";
            this.printResultToolStripMenuItem.Size = new System.Drawing.Size(286, 32);
            this.printResultToolStripMenuItem.Text = "Print Result";
            this.printResultToolStripMenuItem.Click += new System.EventHandler(this.printResultToolStripMenuItem_Click);
            // 
            // MenuStrip_Result
            // 
            this.MenuStrip_Result.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aVGResultByScoreToolStripMenuItem,
            this.staticResultToolStripMenuItem});
            this.MenuStrip_Result.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuStrip_Result.Name = "MenuStrip_Result";
            this.MenuStrip_Result.Size = new System.Drawing.Size(93, 32);
            this.MenuStrip_Result.Text = "RESULT";
            // 
            // aVGResultByScoreToolStripMenuItem
            // 
            this.aVGResultByScoreToolStripMenuItem.Name = "aVGResultByScoreToolStripMenuItem";
            this.aVGResultByScoreToolStripMenuItem.Size = new System.Drawing.Size(282, 32);
            this.aVGResultByScoreToolStripMenuItem.Text = "AVG Result By Score";
            this.aVGResultByScoreToolStripMenuItem.Click += new System.EventHandler(this.aVGResultByScoreToolStripMenuItem_Click);
            // 
            // staticResultToolStripMenuItem
            // 
            this.staticResultToolStripMenuItem.Name = "staticResultToolStripMenuItem";
            this.staticResultToolStripMenuItem.Size = new System.Drawing.Size(282, 32);
            this.staticResultToolStripMenuItem.Text = "Statistical Result";
            this.staticResultToolStripMenuItem.Click += new System.EventHandler(this.staticResultToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(97, 32);
            this.logOutToolStripMenuItem.Text = "Log out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // MainForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm1";
            this.Text = "MainForm1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuStrip_Student;
        private System.Windows.Forms.ToolStripMenuItem MenuStrip_Addstudent;
        private System.Windows.Forms.ToolStripMenuItem MenuStrip_Course;
        private System.Windows.Forms.ToolStripMenuItem MenuStrip_Score;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuStrip_Studentlist;
        private System.Windows.Forms.ToolStripMenuItem MenuStrip_Statics;
        private System.Windows.Forms.ToolStripMenuItem MenuStrip_EditRemove;
        private System.Windows.Forms.ToolStripMenuItem MenuStrip_ManageStudentForm;
        private System.Windows.Forms.ToolStripMenuItem MenuStrip_Print;
        private System.Windows.Forms.ToolStripMenuItem MenuStrip_Result;
        private System.Windows.Forms.ToolStripMenuItem addCourseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeCourseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editCourseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageCoursesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addScoreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeScoreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageScoreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem avgScoreByCourseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printResultToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aVGResultByScoreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem staticResultToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
    }
}