namespace WindowsFormsApp1
{
    partial class HumanResource
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1_remove = new System.Windows.Forms.Button();
            this.button_selectcontact = new System.Windows.Forms.Button();
            this.textBox_enterid = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button_add = new System.Windows.Forms.Button();
            this.button_edit = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.button_remove = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.button_editgroup = new System.Windows.Forms.Button();
            this.textBox_enternewname = new System.Windows.Forms.TextBox();
            this.comboBox_selectgroup = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.textBox_idgroup = new System.Windows.Forms.TextBox();
            this.button_addgroup = new System.Windows.Forms.Button();
            this.textBox_entergroupname = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.errorProvider_id = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_id)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(952, 66);
            this.panel1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(202, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Log out";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(186, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(10, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "|";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(95, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Edit my info";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(95, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 18);
            this.label1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(4, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(85, 49);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.button_add);
            this.panel2.Controls.Add(this.button_edit);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(2, 67);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(464, 380);
            this.panel2.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Yellow;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(10, 315);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(448, 39);
            this.button1.TabIndex = 5;
            this.button1.Text = "Show Full List ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button1_remove);
            this.panel3.Controls.Add(this.button_selectcontact);
            this.panel3.Controls.Add(this.textBox_enterid);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Location = new System.Drawing.Point(10, 176);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(451, 113);
            this.panel3.TabIndex = 4;
            // 
            // button1_remove
            // 
            this.button1_remove.BackColor = System.Drawing.Color.Cyan;
            this.button1_remove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1_remove.Location = new System.Drawing.Point(7, 63);
            this.button1_remove.Name = "button1_remove";
            this.button1_remove.Size = new System.Drawing.Size(441, 39);
            this.button1_remove.TabIndex = 3;
            this.button1_remove.Text = "Remove";
            this.button1_remove.UseVisualStyleBackColor = false;
            this.button1_remove.Click += new System.EventHandler(this.button1_remove_Click);
            // 
            // button_selectcontact
            // 
            this.button_selectcontact.BackColor = System.Drawing.Color.Yellow;
            this.button_selectcontact.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_selectcontact.Location = new System.Drawing.Point(288, 13);
            this.button_selectcontact.Name = "button_selectcontact";
            this.button_selectcontact.Size = new System.Drawing.Size(160, 30);
            this.button_selectcontact.TabIndex = 2;
            this.button_selectcontact.Text = "Select Contact";
            this.button_selectcontact.UseVisualStyleBackColor = false;
            this.button_selectcontact.Click += new System.EventHandler(this.button_selectcontact_Click);
            // 
            // textBox_enterid
            // 
            this.textBox_enterid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_enterid.Location = new System.Drawing.Point(167, 13);
            this.textBox_enterid.Name = "textBox_enterid";
            this.textBox_enterid.Size = new System.Drawing.Size(115, 30);
            this.textBox_enterid.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(158, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "Enter Contact Id:";
            // 
            // button_add
            // 
            this.button_add.BackColor = System.Drawing.Color.SkyBlue;
            this.button_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_add.Location = new System.Drawing.Point(17, 69);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(100, 40);
            this.button_add.TabIndex = 2;
            this.button_add.Text = "Add";
            this.button_add.UseVisualStyleBackColor = false;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // button_edit
            // 
            this.button_edit.BackColor = System.Drawing.Color.SkyBlue;
            this.button_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_edit.Location = new System.Drawing.Point(17, 130);
            this.button_edit.Name = "button_edit";
            this.button_edit.Size = new System.Drawing.Size(100, 40);
            this.button_edit.TabIndex = 3;
            this.button_edit.Text = "Edit";
            this.button_edit.UseVisualStyleBackColor = false;
            this.button_edit.Click += new System.EventHandler(this.button_edit_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 38);
            this.label5.TabIndex = 0;
            this.label5.Text = "Contact";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel7);
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Location = new System.Drawing.Point(473, 67);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(480, 481);
            this.panel4.TabIndex = 2;
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.button_remove);
            this.panel7.Controls.Add(this.comboBox1);
            this.panel7.Controls.Add(this.label12);
            this.panel7.Location = new System.Drawing.Point(18, 360);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(459, 115);
            this.panel7.TabIndex = 4;
            // 
            // button_remove
            // 
            this.button_remove.BackColor = System.Drawing.Color.YellowGreen;
            this.button_remove.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_remove.Location = new System.Drawing.Point(123, 60);
            this.button_remove.Name = "button_remove";
            this.button_remove.Size = new System.Drawing.Size(118, 40);
            this.button_remove.TabIndex = 7;
            this.button_remove.Text = "Remove";
            this.button_remove.UseVisualStyleBackColor = false;
            this.button_remove.Click += new System.EventHandler(this.button_remove_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(189, 11);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(239, 33);
            this.comboBox1.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(36, 19);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(132, 25);
            this.label12.TabIndex = 2;
            this.label12.Text = "Select Group:";
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.button_editgroup);
            this.panel6.Controls.Add(this.textBox_enternewname);
            this.panel6.Controls.Add(this.comboBox_selectgroup);
            this.panel6.Controls.Add(this.label10);
            this.panel6.Controls.Add(this.label9);
            this.panel6.Location = new System.Drawing.Point(14, 189);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(463, 165);
            this.panel6.TabIndex = 3;
            // 
            // button_editgroup
            // 
            this.button_editgroup.BackColor = System.Drawing.Color.YellowGreen;
            this.button_editgroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_editgroup.Location = new System.Drawing.Point(127, 107);
            this.button_editgroup.Name = "button_editgroup";
            this.button_editgroup.Size = new System.Drawing.Size(118, 40);
            this.button_editgroup.TabIndex = 7;
            this.button_editgroup.Text = "Edit";
            this.button_editgroup.UseVisualStyleBackColor = false;
            this.button_editgroup.Click += new System.EventHandler(this.button_editgroup_Click);
            // 
            // textBox_enternewname
            // 
            this.textBox_enternewname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_enternewname.Location = new System.Drawing.Point(189, 58);
            this.textBox_enternewname.Name = "textBox_enternewname";
            this.textBox_enternewname.Size = new System.Drawing.Size(239, 30);
            this.textBox_enternewname.TabIndex = 6;
            // 
            // comboBox_selectgroup
            // 
            this.comboBox_selectgroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_selectgroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_selectgroup.FormattingEnabled = true;
            this.comboBox_selectgroup.Location = new System.Drawing.Point(189, 11);
            this.comboBox_selectgroup.Name = "comboBox_selectgroup";
            this.comboBox_selectgroup.Size = new System.Drawing.Size(239, 33);
            this.comboBox_selectgroup.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(3, 63);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(165, 25);
            this.label10.TabIndex = 4;
            this.label10.Text = "Enter New Name:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(36, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(132, 25);
            this.label9.TabIndex = 2;
            this.label9.Text = "Select Group:";
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.textBox_idgroup);
            this.panel5.Controls.Add(this.button_addgroup);
            this.panel5.Controls.Add(this.textBox_entergroupname);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Location = new System.Drawing.Point(14, 69);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(463, 100);
            this.panel5.TabIndex = 2;
            // 
            // textBox_idgroup
            // 
            this.textBox_idgroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_idgroup.Location = new System.Drawing.Point(339, 9);
            this.textBox_idgroup.Name = "textBox_idgroup";
            this.textBox_idgroup.Size = new System.Drawing.Size(79, 30);
            this.textBox_idgroup.TabIndex = 5;
            this.textBox_idgroup.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_idgroup_KeyPress);
            // 
            // button_addgroup
            // 
            this.button_addgroup.BackColor = System.Drawing.Color.YellowGreen;
            this.button_addgroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_addgroup.Location = new System.Drawing.Point(127, 55);
            this.button_addgroup.Name = "button_addgroup";
            this.button_addgroup.Size = new System.Drawing.Size(118, 40);
            this.button_addgroup.TabIndex = 4;
            this.button_addgroup.Text = "Add";
            this.button_addgroup.UseVisualStyleBackColor = false;
            this.button_addgroup.Click += new System.EventHandler(this.button_addgroup_Click);
            // 
            // textBox_entergroupname
            // 
            this.textBox_entergroupname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_entergroupname.Location = new System.Drawing.Point(189, 9);
            this.textBox_entergroupname.Name = "textBox_entergroupname";
            this.textBox_entergroupname.Size = new System.Drawing.Size(121, 30);
            this.textBox_entergroupname.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(180, 25);
            this.label8.TabIndex = 1;
            this.label8.Text = "Enter Group Name:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 38);
            this.label7.TabIndex = 1;
            this.label7.Text = "Group";
            // 
            // errorProvider_id
            // 
            this.errorProvider_id.ContainerControl = this;
            // 
            // HumanResource
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 549);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial", 8.25F);
            this.Name = "HumanResource";
            this.Text = "HumanResource";
            this.Load += new System.EventHandler(this.HumanResource_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_id)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button1_remove;
        private System.Windows.Forms.Button button_selectcontact;
        private System.Windows.Forms.TextBox textBox_enterid;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Button button_edit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button_addgroup;
        private System.Windows.Forms.TextBox textBox_entergroupname;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button button_remove;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button_editgroup;
        private System.Windows.Forms.TextBox textBox_enternewname;
        private System.Windows.Forms.ComboBox comboBox_selectgroup;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox_idgroup;
        private System.Windows.Forms.ErrorProvider errorProvider_id;
    }
}