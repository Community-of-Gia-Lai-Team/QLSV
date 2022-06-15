namespace WindowsFormsApp1
{
    partial class AddCourse
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
            this.label_courseId = new System.Windows.Forms.Label();
            this.label_label = new System.Windows.Forms.Label();
            this.label_description = new System.Windows.Forms.Label();
            this.label_period = new System.Windows.Forms.Label();
            this.textBox_courseid = new System.Windows.Forms.TextBox();
            this.textBox_period = new System.Windows.Forms.TextBox();
            this.textBox_description = new System.Windows.Forms.TextBox();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.errorProvider_id = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider_period = new System.Windows.Forms.ErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_id)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_period)).BeginInit();
            this.SuspendLayout();
            // 
            // label_courseId
            // 
            this.label_courseId.AutoSize = true;
            this.label_courseId.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_courseId.Location = new System.Drawing.Point(65, 65);
            this.label_courseId.Name = "label_courseId";
            this.label_courseId.Size = new System.Drawing.Size(126, 29);
            this.label_courseId.TabIndex = 0;
            this.label_courseId.Text = "Course ID:";
            // 
            // label_label
            // 
            this.label_label.AutoSize = true;
            this.label_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_label.Location = new System.Drawing.Point(112, 121);
            this.label_label.Name = "label_label";
            this.label_label.Size = new System.Drawing.Size(79, 29);
            this.label_label.TabIndex = 1;
            this.label_label.Text = "Label:";
            // 
            // label_description
            // 
            this.label_description.AutoSize = true;
            this.label_description.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_description.Location = new System.Drawing.Point(50, 241);
            this.label_description.Name = "label_description";
            this.label_description.Size = new System.Drawing.Size(141, 29);
            this.label_description.TabIndex = 2;
            this.label_description.Text = "Description:";
            // 
            // label_period
            // 
            this.label_period.AutoSize = true;
            this.label_period.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_period.Location = new System.Drawing.Point(100, 183);
            this.label_period.Name = "label_period";
            this.label_period.Size = new System.Drawing.Size(91, 29);
            this.label_period.TabIndex = 3;
            this.label_period.Text = "Period:";
            // 
            // textBox_courseid
            // 
            this.textBox_courseid.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_courseid.Location = new System.Drawing.Point(220, 60);
            this.textBox_courseid.Name = "textBox_courseid";
            this.textBox_courseid.Size = new System.Drawing.Size(303, 34);
            this.textBox_courseid.TabIndex = 4;
            this.textBox_courseid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_courseid_KeyPress);
            // 
            // textBox_period
            // 
            this.textBox_period.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_period.Location = new System.Drawing.Point(220, 178);
            this.textBox_period.Name = "textBox_period";
            this.textBox_period.Size = new System.Drawing.Size(303, 34);
            this.textBox_period.TabIndex = 5;
            this.textBox_period.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_period_KeyPress);
            // 
            // textBox_description
            // 
            this.textBox_description.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_description.Location = new System.Drawing.Point(220, 241);
            this.textBox_description.Multiline = true;
            this.textBox_description.Name = "textBox_description";
            this.textBox_description.Size = new System.Drawing.Size(303, 108);
            this.textBox_description.TabIndex = 6;
            // 
            // textBox_name
            // 
            this.textBox_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_name.Location = new System.Drawing.Point(220, 118);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(303, 34);
            this.textBox_name.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Aquamarine;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(50, 433);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(473, 42);
            this.button1.TabIndex = 8;
            this.button1.Text = "ADD";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // errorProvider_id
            // 
            this.errorProvider_id.ContainerControl = this;
            // 
            // errorProvider_period
            // 
            this.errorProvider_period.ContainerControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 382);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 29);
            this.label1.TabIndex = 9;
            this.label1.Text = "Contact ID:";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(220, 374);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(303, 37);
            this.comboBox1.TabIndex = 10;
            // 
            // AddCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 487);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.textBox_description);
            this.Controls.Add(this.textBox_period);
            this.Controls.Add(this.textBox_courseid);
            this.Controls.Add(this.label_period);
            this.Controls.Add(this.label_description);
            this.Controls.Add(this.label_label);
            this.Controls.Add(this.label_courseId);
            this.Name = "AddCourse";
            this.Text = "AddCourse";
            this.Load += new System.EventHandler(this.AddCourse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_id)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_period)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_courseId;
        private System.Windows.Forms.Label label_label;
        private System.Windows.Forms.Label label_description;
        private System.Windows.Forms.Label label_period;
        private System.Windows.Forms.TextBox textBox_courseid;
        private System.Windows.Forms.TextBox textBox_period;
        private System.Windows.Forms.TextBox textBox_description;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ErrorProvider errorProvider_id;
        private System.Windows.Forms.ErrorProvider errorProvider_period;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}