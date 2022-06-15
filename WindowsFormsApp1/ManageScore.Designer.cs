namespace WindowsFormsApp1
{
    partial class ManageScore
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
            this.label_id = new System.Windows.Forms.Label();
            this.label_course = new System.Windows.Forms.Label();
            this.label_score = new System.Windows.Forms.Label();
            this.label_description = new System.Windows.Forms.Label();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.textBox_score = new System.Windows.Forms.TextBox();
            this.textBox_des = new System.Windows.Forms.TextBox();
            this.comboBox_course = new System.Windows.Forms.ComboBox();
            this.button_avgscore = new System.Windows.Forms.Button();
            this.button_add = new System.Windows.Forms.Button();
            this.button_remove = new System.Windows.Forms.Button();
            this.button_showscore = new System.Windows.Forms.Button();
            this.button_showstudent = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_contact = new System.Windows.Forms.ComboBox();
            this.button_find = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.errorProvider_id = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider_score = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_id)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_score)).BeginInit();
            this.SuspendLayout();
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_id.Location = new System.Drawing.Point(56, 36);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(141, 29);
            this.label_id.TabIndex = 0;
            this.label_id.Text = "Student ID:";
            // 
            // label_course
            // 
            this.label_course.AutoSize = true;
            this.label_course.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_course.Location = new System.Drawing.Point(12, 100);
            this.label_course.Name = "label_course";
            this.label_course.Size = new System.Drawing.Size(185, 29);
            this.label_course.TabIndex = 1;
            this.label_course.Text = "Select Course:";
            // 
            // label_score
            // 
            this.label_score.AutoSize = true;
            this.label_score.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_score.Location = new System.Drawing.Point(108, 167);
            this.label_score.Name = "label_score";
            this.label_score.Size = new System.Drawing.Size(89, 29);
            this.label_score.TabIndex = 2;
            this.label_score.Text = "Score:";
            // 
            // label_description
            // 
            this.label_description.AutoSize = true;
            this.label_description.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_description.Location = new System.Drawing.Point(44, 226);
            this.label_description.Name = "label_description";
            this.label_description.Size = new System.Drawing.Size(153, 29);
            this.label_description.TabIndex = 3;
            this.label_description.Text = "Description:";
            // 
            // textBox_id
            // 
            this.textBox_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_id.Location = new System.Drawing.Point(203, 31);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(141, 34);
            this.textBox_id.TabIndex = 4;
            this.textBox_id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_id_KeyPress);
            // 
            // textBox_score
            // 
            this.textBox_score.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_score.Location = new System.Drawing.Point(203, 164);
            this.textBox_score.Name = "textBox_score";
            this.textBox_score.Size = new System.Drawing.Size(146, 34);
            this.textBox_score.TabIndex = 6;
            this.textBox_score.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_score_KeyPress);
            // 
            // textBox_des
            // 
            this.textBox_des.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_des.Location = new System.Drawing.Point(203, 233);
            this.textBox_des.Multiline = true;
            this.textBox_des.Name = "textBox_des";
            this.textBox_des.Size = new System.Drawing.Size(268, 105);
            this.textBox_des.TabIndex = 7;
            // 
            // comboBox_course
            // 
            this.comboBox_course.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_course.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_course.FormattingEnabled = true;
            this.comboBox_course.Location = new System.Drawing.Point(203, 92);
            this.comboBox_course.Name = "comboBox_course";
            this.comboBox_course.Size = new System.Drawing.Size(268, 37);
            this.comboBox_course.TabIndex = 8;
            // 
            // button_avgscore
            // 
            this.button_avgscore.BackColor = System.Drawing.Color.Cyan;
            this.button_avgscore.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_avgscore.Location = new System.Drawing.Point(1045, 559);
            this.button_avgscore.Name = "button_avgscore";
            this.button_avgscore.Size = new System.Drawing.Size(367, 55);
            this.button_avgscore.TabIndex = 9;
            this.button_avgscore.Text = "Average Score By Course";
            this.button_avgscore.UseVisualStyleBackColor = false;
            this.button_avgscore.Click += new System.EventHandler(this.button_avgscore_Click);
            // 
            // button_add
            // 
            this.button_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_add.Location = new System.Drawing.Point(34, 455);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(96, 46);
            this.button_add.TabIndex = 10;
            this.button_add.Text = "Add";
            this.button_add.UseVisualStyleBackColor = false;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // button_remove
            // 
            this.button_remove.BackColor = System.Drawing.Color.Red;
            this.button_remove.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_remove.Location = new System.Drawing.Point(352, 455);
            this.button_remove.Name = "button_remove";
            this.button_remove.Size = new System.Drawing.Size(149, 46);
            this.button_remove.TabIndex = 11;
            this.button_remove.Text = "Remove";
            this.button_remove.UseVisualStyleBackColor = false;
            this.button_remove.Click += new System.EventHandler(this.button_remove_Click);
            // 
            // button_showscore
            // 
            this.button_showscore.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_showscore.Location = new System.Drawing.Point(1003, 22);
            this.button_showscore.Name = "button_showscore";
            this.button_showscore.Size = new System.Drawing.Size(409, 32);
            this.button_showscore.TabIndex = 12;
            this.button_showscore.Text = "Show Scores";
            this.button_showscore.UseVisualStyleBackColor = true;
            this.button_showscore.Click += new System.EventHandler(this.button_showscore_Click);
            // 
            // button_showstudent
            // 
            this.button_showstudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_showstudent.Location = new System.Drawing.Point(561, 22);
            this.button_showstudent.Name = "button_showstudent";
            this.button_showstudent.Size = new System.Drawing.Size(424, 32);
            this.button_showstudent.TabIndex = 13;
            this.button_showstudent.Text = "Show Students";
            this.button_showstudent.UseVisualStyleBackColor = true;
            this.button_showstudent.Click += new System.EventHandler(this.button_showstudent_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(561, 75);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(851, 474);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 377);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 29);
            this.label1.TabIndex = 15;
            this.label1.Text = "Name Contact:";
            // 
            // comboBox_contact
            // 
            this.comboBox_contact.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_contact.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_contact.FormattingEnabled = true;
            this.comboBox_contact.Location = new System.Drawing.Point(202, 369);
            this.comboBox_contact.Name = "comboBox_contact";
            this.comboBox_contact.Size = new System.Drawing.Size(172, 37);
            this.comboBox_contact.TabIndex = 16;
            // 
            // button_find
            // 
            this.button_find.BackColor = System.Drawing.Color.Cyan;
            this.button_find.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_find.Location = new System.Drawing.Point(380, 369);
            this.button_find.Name = "button_find";
            this.button_find.Size = new System.Drawing.Size(91, 37);
            this.button_find.TabIndex = 17;
            this.button_find.Text = "Find";
            this.button_find.UseVisualStyleBackColor = false;
            this.button_find.Click += new System.EventHandler(this.button_find_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(202, 455);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 46);
            this.button1.TabIndex = 18;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // errorProvider_id
            // 
            this.errorProvider_id.ContainerControl = this;
            // 
            // errorProvider_score
            // 
            this.errorProvider_score.ContainerControl = this;
            // 
            // ManageScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1424, 626);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_find);
            this.Controls.Add(this.comboBox_contact);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button_showstudent);
            this.Controls.Add(this.button_showscore);
            this.Controls.Add(this.button_remove);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.button_avgscore);
            this.Controls.Add(this.comboBox_course);
            this.Controls.Add(this.textBox_des);
            this.Controls.Add(this.textBox_score);
            this.Controls.Add(this.textBox_id);
            this.Controls.Add(this.label_description);
            this.Controls.Add(this.label_score);
            this.Controls.Add(this.label_course);
            this.Controls.Add(this.label_id);
            this.Name = "ManageScore";
            this.Text = "ManageScore";
            this.Load += new System.EventHandler(this.ManageScore_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_id)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_score)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.Label label_course;
        private System.Windows.Forms.Label label_score;
        private System.Windows.Forms.Label label_description;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.TextBox textBox_score;
        private System.Windows.Forms.TextBox textBox_des;
        private System.Windows.Forms.ComboBox comboBox_course;
        private System.Windows.Forms.Button button_avgscore;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Button button_remove;
        private System.Windows.Forms.Button button_showscore;
        private System.Windows.Forms.Button button_showstudent;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_contact;
        private System.Windows.Forms.Button button_find;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ErrorProvider errorProvider_id;
        private System.Windows.Forms.ErrorProvider errorProvider_score;
    }
}