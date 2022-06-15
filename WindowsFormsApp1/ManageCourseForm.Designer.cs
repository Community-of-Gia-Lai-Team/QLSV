namespace WindowsFormsApp1
{
    partial class ManageCourseForm
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
            this.label_ID = new System.Windows.Forms.Label();
            this.label_name = new System.Windows.Forms.Label();
            this.label_hours = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_description = new System.Windows.Forms.TextBox();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.numericUpDown_hours = new System.Windows.Forms.NumericUpDown();
            this.button_first = new System.Windows.Forms.Button();
            this.button_next = new System.Windows.Forms.Button();
            this.button_previous = new System.Windows.Forms.Button();
            this.button_last = new System.Windows.Forms.Button();
            this.button_add = new System.Windows.Forms.Button();
            this.button_edit = new System.Windows.Forms.Button();
            this.button_remove = new System.Windows.Forms.Button();
            this.listBox_totalcourse = new System.Windows.Forms.ListBox();
            this.label_totalcourse = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider_id = new System.Windows.Forms.ErrorProvider(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_hours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_id)).BeginInit();
            this.SuspendLayout();
            // 
            // label_ID
            // 
            this.label_ID.AutoSize = true;
            this.label_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ID.Location = new System.Drawing.Point(156, 49);
            this.label_ID.Name = "label_ID";
            this.label_ID.Size = new System.Drawing.Size(45, 29);
            this.label_ID.TabIndex = 0;
            this.label_ID.Text = "ID:";
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_name.Location = new System.Drawing.Point(116, 108);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(85, 29);
            this.label_name.TabIndex = 1;
            this.label_name.Text = "Label:";
            // 
            // label_hours
            // 
            this.label_hours.AutoSize = true;
            this.label_hours.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_hours.Location = new System.Drawing.Point(12, 168);
            this.label_hours.Name = "label_hours";
            this.label_hours.Size = new System.Drawing.Size(189, 29);
            this.label_hours.TabIndex = 2;
            this.label_hours.Text = "Hours Number:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(48, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Description:";
            // 
            // textBox_description
            // 
            this.textBox_description.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_description.Location = new System.Drawing.Point(229, 227);
            this.textBox_description.Multiline = true;
            this.textBox_description.Name = "textBox_description";
            this.textBox_description.Size = new System.Drawing.Size(234, 100);
            this.textBox_description.TabIndex = 4;
            // 
            // textBox_name
            // 
            this.textBox_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_name.Location = new System.Drawing.Point(229, 103);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(234, 34);
            this.textBox_name.TabIndex = 6;
            // 
            // textBox_id
            // 
            this.textBox_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_id.Location = new System.Drawing.Point(229, 44);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(125, 34);
            this.textBox_id.TabIndex = 7;
            this.textBox_id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_id_KeyPress);
            // 
            // numericUpDown_hours
            // 
            this.numericUpDown_hours.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown_hours.Location = new System.Drawing.Point(229, 163);
            this.numericUpDown_hours.Name = "numericUpDown_hours";
            this.numericUpDown_hours.Size = new System.Drawing.Size(144, 34);
            this.numericUpDown_hours.TabIndex = 8;
            // 
            // button_first
            // 
            this.button_first.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_first.Location = new System.Drawing.Point(33, 407);
            this.button_first.Name = "button_first";
            this.button_first.Size = new System.Drawing.Size(85, 41);
            this.button_first.TabIndex = 9;
            this.button_first.Text = "First";
            this.button_first.UseVisualStyleBackColor = true;
            this.button_first.Click += new System.EventHandler(this.button_first_Click);
            // 
            // button_next
            // 
            this.button_next.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_next.Location = new System.Drawing.Point(161, 407);
            this.button_next.Name = "button_next";
            this.button_next.Size = new System.Drawing.Size(85, 41);
            this.button_next.TabIndex = 10;
            this.button_next.Text = "Next";
            this.button_next.UseVisualStyleBackColor = true;
            this.button_next.Click += new System.EventHandler(this.button_next_Click);
            // 
            // button_previous
            // 
            this.button_previous.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_previous.Location = new System.Drawing.Point(292, 407);
            this.button_previous.Name = "button_previous";
            this.button_previous.Size = new System.Drawing.Size(143, 41);
            this.button_previous.TabIndex = 11;
            this.button_previous.Text = "Previous";
            this.button_previous.UseVisualStyleBackColor = true;
            this.button_previous.Click += new System.EventHandler(this.button_previous_Click);
            // 
            // button_last
            // 
            this.button_last.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_last.Location = new System.Drawing.Point(476, 407);
            this.button_last.Name = "button_last";
            this.button_last.Size = new System.Drawing.Size(84, 41);
            this.button_last.TabIndex = 12;
            this.button_last.Text = "Last";
            this.button_last.UseVisualStyleBackColor = true;
            this.button_last.Click += new System.EventHandler(this.button_last_Click);
            // 
            // button_add
            // 
            this.button_add.BackColor = System.Drawing.Color.Yellow;
            this.button_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_add.Location = new System.Drawing.Point(94, 480);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(92, 42);
            this.button_add.TabIndex = 13;
            this.button_add.Text = "Add";
            this.button_add.UseVisualStyleBackColor = false;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // button_edit
            // 
            this.button_edit.BackColor = System.Drawing.Color.Lime;
            this.button_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_edit.Location = new System.Drawing.Point(260, 480);
            this.button_edit.Name = "button_edit";
            this.button_edit.Size = new System.Drawing.Size(94, 42);
            this.button_edit.TabIndex = 14;
            this.button_edit.Text = "Edit";
            this.button_edit.UseVisualStyleBackColor = false;
            this.button_edit.Click += new System.EventHandler(this.button_edit_Click);
            // 
            // button_remove
            // 
            this.button_remove.BackColor = System.Drawing.Color.Cyan;
            this.button_remove.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_remove.Location = new System.Drawing.Point(429, 480);
            this.button_remove.Name = "button_remove";
            this.button_remove.Size = new System.Drawing.Size(131, 42);
            this.button_remove.TabIndex = 15;
            this.button_remove.Text = "Remove";
            this.button_remove.UseVisualStyleBackColor = false;
            this.button_remove.Click += new System.EventHandler(this.button_remove_Click);
            // 
            // listBox_totalcourse
            // 
            this.listBox_totalcourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox_totalcourse.FormattingEnabled = true;
            this.listBox_totalcourse.ItemHeight = 29;
            this.listBox_totalcourse.Location = new System.Drawing.Point(648, 44);
            this.listBox_totalcourse.Name = "listBox_totalcourse";
            this.listBox_totalcourse.Size = new System.Drawing.Size(509, 381);
            this.listBox_totalcourse.TabIndex = 16;
            this.listBox_totalcourse.Click += new System.EventHandler(this.listBox_totalcourse_Click);
            // 
            // label_totalcourse
            // 
            this.label_totalcourse.AutoSize = true;
            this.label_totalcourse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label_totalcourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_totalcourse.Location = new System.Drawing.Point(970, 453);
            this.label_totalcourse.Name = "label_totalcourse";
            this.label_totalcourse.Size = new System.Drawing.Size(158, 29);
            this.label_totalcourse.TabIndex = 17;
            this.label_totalcourse.Text = "Total Course:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 349);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 29);
            this.label1.TabIndex = 18;
            this.label1.Text = "ID Contact:";
            // 
            // errorProvider_id
            // 
            this.errorProvider_id.ContainerControl = this;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(229, 341);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(234, 37);
            this.comboBox1.TabIndex = 19;
            // 
            // ManageCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1169, 534);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_totalcourse);
            this.Controls.Add(this.listBox_totalcourse);
            this.Controls.Add(this.button_remove);
            this.Controls.Add(this.button_edit);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.button_last);
            this.Controls.Add(this.button_previous);
            this.Controls.Add(this.button_next);
            this.Controls.Add(this.button_first);
            this.Controls.Add(this.numericUpDown_hours);
            this.Controls.Add(this.textBox_id);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.textBox_description);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label_hours);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.label_ID);
            this.Name = "ManageCourseForm";
            this.Text = "ManageCourseForm";
            this.Load += new System.EventHandler(this.ManageCourseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_hours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_id)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_ID;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label_hours;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_description;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.NumericUpDown numericUpDown_hours;
        private System.Windows.Forms.Button button_first;
        private System.Windows.Forms.Button button_next;
        private System.Windows.Forms.Button button_previous;
        private System.Windows.Forms.Button button_last;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Button button_edit;
        private System.Windows.Forms.Button button_remove;
        private System.Windows.Forms.ListBox listBox_totalcourse;
        private System.Windows.Forms.Label label_totalcourse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider_id;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}