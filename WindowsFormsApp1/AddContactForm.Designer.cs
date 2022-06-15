namespace WindowsFormsApp1
{
    partial class AddContactForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_address = new System.Windows.Forms.TextBox();
            this.textBox_email = new System.Windows.Forms.TextBox();
            this.textBox_fname = new System.Windows.Forms.TextBox();
            this.textBox_phone = new System.Windows.Forms.TextBox();
            this.textBox_lname = new System.Windows.Forms.TextBox();
            this.comboBox_group = new System.Windows.Forms.ComboBox();
            this.button_upload = new System.Windows.Forms.Button();
            this.button_add = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.errorProvider_id = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider_fname = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider_lname = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider_phone = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider_mail = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_id)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_fname)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_lname)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_phone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_mail)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fisrt name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(90, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Group:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(87, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Phone:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(96, 296);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 29);
            this.label5.TabIndex = 4;
            this.label5.Text = "Email:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(68, 351);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 29);
            this.label6.TabIndex = 5;
            this.label6.Text = "Address:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(82, 477);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 29);
            this.label7.TabIndex = 6;
            this.label7.Text = "Picture:";
            // 
            // textBox_address
            // 
            this.textBox_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_address.Location = new System.Drawing.Point(197, 351);
            this.textBox_address.Multiline = true;
            this.textBox_address.Name = "textBox_address";
            this.textBox_address.Size = new System.Drawing.Size(404, 105);
            this.textBox_address.TabIndex = 9;
            // 
            // textBox_email
            // 
            this.textBox_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_email.Location = new System.Drawing.Point(197, 293);
            this.textBox_email.Name = "textBox_email";
            this.textBox_email.Size = new System.Drawing.Size(404, 34);
            this.textBox_email.TabIndex = 10;
            this.textBox_email.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_email_Validating);
            // 
            // textBox_fname
            // 
            this.textBox_fname.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_fname.Location = new System.Drawing.Point(197, 54);
            this.textBox_fname.Name = "textBox_fname";
            this.textBox_fname.Size = new System.Drawing.Size(404, 34);
            this.textBox_fname.TabIndex = 11;
            this.textBox_fname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_fname_KeyPress);
            // 
            // textBox_phone
            // 
            this.textBox_phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_phone.Location = new System.Drawing.Point(197, 232);
            this.textBox_phone.Name = "textBox_phone";
            this.textBox_phone.Size = new System.Drawing.Size(404, 34);
            this.textBox_phone.TabIndex = 12;
            this.textBox_phone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_phone_KeyPress);
            // 
            // textBox_lname
            // 
            this.textBox_lname.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_lname.Location = new System.Drawing.Point(197, 108);
            this.textBox_lname.Name = "textBox_lname";
            this.textBox_lname.Size = new System.Drawing.Size(404, 34);
            this.textBox_lname.TabIndex = 13;
            this.textBox_lname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_lname_KeyPress);
            // 
            // comboBox_group
            // 
            this.comboBox_group.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_group.FormattingEnabled = true;
            this.comboBox_group.Location = new System.Drawing.Point(197, 168);
            this.comboBox_group.Name = "comboBox_group";
            this.comboBox_group.Size = new System.Drawing.Size(404, 37);
            this.comboBox_group.TabIndex = 14;
            // 
            // button_upload
            // 
            this.button_upload.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_upload.Location = new System.Drawing.Point(197, 637);
            this.button_upload.Name = "button_upload";
            this.button_upload.Size = new System.Drawing.Size(264, 29);
            this.button_upload.TabIndex = 16;
            this.button_upload.Text = "Upload";
            this.button_upload.UseVisualStyleBackColor = true;
            this.button_upload.Click += new System.EventHandler(this.button_upload_Click);
            // 
            // button_add
            // 
            this.button_add.BackColor = System.Drawing.Color.Lime;
            this.button_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_add.Location = new System.Drawing.Point(52, 682);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(165, 49);
            this.button_add.TabIndex = 18;
            this.button_add.Text = "Add Contact";
            this.button_add.UseVisualStyleBackColor = false;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // button_cancel
            // 
            this.button_cancel.BackColor = System.Drawing.Color.Lime;
            this.button_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_cancel.Location = new System.Drawing.Point(397, 682);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(165, 49);
            this.button_cancel.TabIndex = 19;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = false;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(197, 477);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(264, 154);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(134, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 29);
            this.label9.TabIndex = 20;
            this.label9.Text = "ID:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // textBox_id
            // 
            this.textBox_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_id.Location = new System.Drawing.Point(197, 6);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(188, 34);
            this.textBox_id.TabIndex = 21;
            this.textBox_id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_id_KeyPress);
            // 
            // errorProvider_id
            // 
            this.errorProvider_id.ContainerControl = this;
            // 
            // errorProvider_fname
            // 
            this.errorProvider_fname.ContainerControl = this;
            // 
            // errorProvider_lname
            // 
            this.errorProvider_lname.ContainerControl = this;
            // 
            // errorProvider_phone
            // 
            this.errorProvider_phone.ContainerControl = this;
            // 
            // errorProvider_mail
            // 
            this.errorProvider_mail.ContainerControl = this;
            // 
            // AddContactForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 752);
            this.Controls.Add(this.textBox_id);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.button_upload);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.comboBox_group);
            this.Controls.Add(this.textBox_lname);
            this.Controls.Add(this.textBox_phone);
            this.Controls.Add(this.textBox_fname);
            this.Controls.Add(this.textBox_email);
            this.Controls.Add(this.textBox_address);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddContactForm";
            this.Text = "AddContactForm";
            this.Load += new System.EventHandler(this.AddContactForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_id)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_fname)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_lname)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_phone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_mail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_address;
        private System.Windows.Forms.TextBox textBox_email;
        private System.Windows.Forms.TextBox textBox_fname;
        private System.Windows.Forms.TextBox textBox_phone;
        private System.Windows.Forms.TextBox textBox_lname;
        private System.Windows.Forms.ComboBox comboBox_group;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button_upload;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.ErrorProvider errorProvider_id;
        private System.Windows.Forms.ErrorProvider errorProvider_fname;
        private System.Windows.Forms.ErrorProvider errorProvider_lname;
        private System.Windows.Forms.ErrorProvider errorProvider_phone;
        private System.Windows.Forms.ErrorProvider errorProvider_mail;
    }
}