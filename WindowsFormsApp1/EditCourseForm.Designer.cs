namespace WindowsFormsApp1
{
    partial class EditCourseForm
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
            this.label_selectcourse = new System.Windows.Forms.Label();
            this.label_label = new System.Windows.Forms.Label();
            this.label_period = new System.Windows.Forms.Label();
            this.label_description = new System.Windows.Forms.Label();
            this.textBox_description = new System.Windows.Forms.TextBox();
            this.textBox_label = new System.Windows.Forms.TextBox();
            this.button_edit = new System.Windows.Forms.Button();
            this.comboBox_course = new System.Windows.Forms.ComboBox();
            this.numericUpDown_period = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_period)).BeginInit();
            this.SuspendLayout();
            // 
            // label_selectcourse
            // 
            this.label_selectcourse.AutoSize = true;
            this.label_selectcourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_selectcourse.Location = new System.Drawing.Point(39, 63);
            this.label_selectcourse.Name = "label_selectcourse";
            this.label_selectcourse.Size = new System.Drawing.Size(235, 29);
            this.label_selectcourse.TabIndex = 0;
            this.label_selectcourse.Text = "SELECT COURSE:";
            // 
            // label_label
            // 
            this.label_label.AutoSize = true;
            this.label_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_label.Location = new System.Drawing.Point(176, 127);
            this.label_label.Name = "label_label";
            this.label_label.Size = new System.Drawing.Size(98, 29);
            this.label_label.TabIndex = 1;
            this.label_label.Text = "LABEL:";
            // 
            // label_period
            // 
            this.label_period.AutoSize = true;
            this.label_period.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_period.Location = new System.Drawing.Point(157, 189);
            this.label_period.Name = "label_period";
            this.label_period.Size = new System.Drawing.Size(117, 29);
            this.label_period.TabIndex = 2;
            this.label_period.Text = "PERIOD:";
            // 
            // label_description
            // 
            this.label_description.AutoSize = true;
            this.label_description.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_description.Location = new System.Drawing.Point(79, 255);
            this.label_description.Name = "label_description";
            this.label_description.Size = new System.Drawing.Size(195, 29);
            this.label_description.TabIndex = 3;
            this.label_description.Text = "DESCRIPTION:";
            // 
            // textBox_description
            // 
            this.textBox_description.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_description.Location = new System.Drawing.Point(306, 255);
            this.textBox_description.Multiline = true;
            this.textBox_description.Name = "textBox_description";
            this.textBox_description.Size = new System.Drawing.Size(259, 100);
            this.textBox_description.TabIndex = 4;
            // 
            // textBox_label
            // 
            this.textBox_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_label.Location = new System.Drawing.Point(306, 124);
            this.textBox_label.Name = "textBox_label";
            this.textBox_label.Size = new System.Drawing.Size(259, 34);
            this.textBox_label.TabIndex = 6;
            // 
            // button_edit
            // 
            this.button_edit.BackColor = System.Drawing.Color.Yellow;
            this.button_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_edit.Location = new System.Drawing.Point(44, 450);
            this.button_edit.Name = "button_edit";
            this.button_edit.Size = new System.Drawing.Size(521, 47);
            this.button_edit.TabIndex = 9;
            this.button_edit.Text = "EDIT";
            this.button_edit.UseVisualStyleBackColor = false;
            this.button_edit.Click += new System.EventHandler(this.button_edit_Click);
            // 
            // comboBox_course
            // 
            this.comboBox_course.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_course.FormattingEnabled = true;
            this.comboBox_course.Location = new System.Drawing.Point(306, 60);
            this.comboBox_course.Name = "comboBox_course";
            this.comboBox_course.Size = new System.Drawing.Size(259, 37);
            this.comboBox_course.TabIndex = 10;
            this.comboBox_course.SelectedIndexChanged += new System.EventHandler(this.comboBox_course_SelectedIndexChanged);
            // 
            // numericUpDown_period
            // 
            this.numericUpDown_period.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown_period.Location = new System.Drawing.Point(306, 184);
            this.numericUpDown_period.Name = "numericUpDown_period";
            this.numericUpDown_period.Size = new System.Drawing.Size(136, 34);
            this.numericUpDown_period.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(97, 395);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 29);
            this.label1.TabIndex = 12;
            this.label1.Text = "ID CONTACT:";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(306, 387);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(259, 37);
            this.comboBox1.TabIndex = 13;
            // 
            // EditCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 509);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown_period);
            this.Controls.Add(this.comboBox_course);
            this.Controls.Add(this.button_edit);
            this.Controls.Add(this.textBox_label);
            this.Controls.Add(this.textBox_description);
            this.Controls.Add(this.label_description);
            this.Controls.Add(this.label_period);
            this.Controls.Add(this.label_label);
            this.Controls.Add(this.label_selectcourse);
            this.Name = "EditCourseForm";
            this.Text = "EditCourseForm";
            this.Load += new System.EventHandler(this.EditCourseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_period)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_selectcourse;
        private System.Windows.Forms.Label label_label;
        private System.Windows.Forms.Label label_period;
        private System.Windows.Forms.Label label_description;
        private System.Windows.Forms.TextBox textBox_description;
        private System.Windows.Forms.TextBox textBox_label;
        private System.Windows.Forms.Button button_edit;
        private System.Windows.Forms.ComboBox comboBox_course;
        private System.Windows.Forms.NumericUpDown numericUpDown_period;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}