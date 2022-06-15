namespace WindowsFormsApp1
{
    partial class AddStudentForm
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
            this.lb_StudentID = new System.Windows.Forms.Label();
            this.lb_FirstName = new System.Windows.Forms.Label();
            this.lb_LastName = new System.Windows.Forms.Label();
            this.lb_birthdate = new System.Windows.Forms.Label();
            this.lb_Gender = new System.Windows.Forms.Label();
            this.lb_phone = new System.Windows.Forms.Label();
            this.lb_address = new System.Windows.Forms.Label();
            this.lb_picture = new System.Windows.Forms.Label();
            this.bt_upload = new System.Windows.Forms.Button();
            this.tB_address = new System.Windows.Forms.TextBox();
            this.tB_phone = new System.Windows.Forms.TextBox();
            this.tB_lastname = new System.Windows.Forms.TextBox();
            this.tB_firstname = new System.Windows.Forms.TextBox();
            this.tB_studentid = new System.Windows.Forms.TextBox();
            this.dateTime_birthdate = new System.Windows.Forms.DateTimePicker();
            this.rB_male = new System.Windows.Forms.RadioButton();
            this.rB_Female = new System.Windows.Forms.RadioButton();
            this.bt_cancel = new System.Windows.Forms.Button();
            this.bt_add = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.errorProvider_id = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider_phone = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider_fname = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider_lname = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_id)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_phone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_fname)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_lname)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_StudentID
            // 
            this.lb_StudentID.AutoSize = true;
            this.lb_StudentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_StudentID.Location = new System.Drawing.Point(62, 30);
            this.lb_StudentID.Name = "lb_StudentID";
            this.lb_StudentID.Size = new System.Drawing.Size(99, 22);
            this.lb_StudentID.TabIndex = 0;
            this.lb_StudentID.Text = "Student ID:";
            // 
            // lb_FirstName
            // 
            this.lb_FirstName.AutoSize = true;
            this.lb_FirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_FirstName.Location = new System.Drawing.Point(62, 76);
            this.lb_FirstName.Name = "lb_FirstName";
            this.lb_FirstName.Size = new System.Drawing.Size(102, 22);
            this.lb_FirstName.TabIndex = 1;
            this.lb_FirstName.Text = "First Name:";
            // 
            // lb_LastName
            // 
            this.lb_LastName.AutoSize = true;
            this.lb_LastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_LastName.Location = new System.Drawing.Point(62, 125);
            this.lb_LastName.Name = "lb_LastName";
            this.lb_LastName.Size = new System.Drawing.Size(101, 22);
            this.lb_LastName.TabIndex = 2;
            this.lb_LastName.Text = "Last Name:";
            // 
            // lb_birthdate
            // 
            this.lb_birthdate.AutoSize = true;
            this.lb_birthdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_birthdate.Location = new System.Drawing.Point(62, 177);
            this.lb_birthdate.Name = "lb_birthdate";
            this.lb_birthdate.Size = new System.Drawing.Size(90, 22);
            this.lb_birthdate.TabIndex = 3;
            this.lb_birthdate.Text = "BirthDate:";
            // 
            // lb_Gender
            // 
            this.lb_Gender.AutoSize = true;
            this.lb_Gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Gender.Location = new System.Drawing.Point(62, 225);
            this.lb_Gender.Name = "lb_Gender";
            this.lb_Gender.Size = new System.Drawing.Size(75, 22);
            this.lb_Gender.TabIndex = 4;
            this.lb_Gender.Text = "Gender:";
            // 
            // lb_phone
            // 
            this.lb_phone.AutoSize = true;
            this.lb_phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_phone.Location = new System.Drawing.Point(62, 275);
            this.lb_phone.Name = "lb_phone";
            this.lb_phone.Size = new System.Drawing.Size(67, 22);
            this.lb_phone.TabIndex = 5;
            this.lb_phone.Text = "Phone:";
            // 
            // lb_address
            // 
            this.lb_address.AutoSize = true;
            this.lb_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_address.Location = new System.Drawing.Point(62, 325);
            this.lb_address.Name = "lb_address";
            this.lb_address.Size = new System.Drawing.Size(81, 22);
            this.lb_address.TabIndex = 6;
            this.lb_address.Text = "Address:";
            // 
            // lb_picture
            // 
            this.lb_picture.AutoSize = true;
            this.lb_picture.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_picture.Location = new System.Drawing.Point(62, 410);
            this.lb_picture.Name = "lb_picture";
            this.lb_picture.Size = new System.Drawing.Size(71, 22);
            this.lb_picture.TabIndex = 7;
            this.lb_picture.Text = "Picture:";
            // 
            // bt_upload
            // 
            this.bt_upload.Location = new System.Drawing.Point(178, 535);
            this.bt_upload.Name = "bt_upload";
            this.bt_upload.Size = new System.Drawing.Size(396, 23);
            this.bt_upload.TabIndex = 8;
            this.bt_upload.Text = "Upload image";
            this.bt_upload.UseVisualStyleBackColor = true;
            this.bt_upload.Click += new System.EventHandler(this.bt_upload_Click);
            // 
            // tB_address
            // 
            this.tB_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tB_address.Location = new System.Drawing.Point(178, 322);
            this.tB_address.Multiline = true;
            this.tB_address.Name = "tB_address";
            this.tB_address.Size = new System.Drawing.Size(396, 63);
            this.tB_address.TabIndex = 9;
            // 
            // tB_phone
            // 
            this.tB_phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tB_phone.Location = new System.Drawing.Point(178, 272);
            this.tB_phone.Name = "tB_phone";
            this.tB_phone.Size = new System.Drawing.Size(396, 28);
            this.tB_phone.TabIndex = 10;
            this.tB_phone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tB_phone_KeyPress);
            // 
            // tB_lastname
            // 
            this.tB_lastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tB_lastname.Location = new System.Drawing.Point(178, 122);
            this.tB_lastname.Name = "tB_lastname";
            this.tB_lastname.Size = new System.Drawing.Size(396, 28);
            this.tB_lastname.TabIndex = 11;
            this.tB_lastname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tB_lastname_KeyPress);
            // 
            // tB_firstname
            // 
            this.tB_firstname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tB_firstname.Location = new System.Drawing.Point(178, 76);
            this.tB_firstname.Name = "tB_firstname";
            this.tB_firstname.Size = new System.Drawing.Size(396, 28);
            this.tB_firstname.TabIndex = 12;
            this.tB_firstname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tB_firstname_KeyPress);
            // 
            // tB_studentid
            // 
            this.tB_studentid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tB_studentid.Location = new System.Drawing.Point(178, 27);
            this.tB_studentid.Name = "tB_studentid";
            this.tB_studentid.Size = new System.Drawing.Size(396, 28);
            this.tB_studentid.TabIndex = 13;
            this.tB_studentid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tB_studentid_KeyPress);
            this.tB_studentid.Validating += new System.ComponentModel.CancelEventHandler(this.tB_studentid_Validating);
            // 
            // dateTime_birthdate
            // 
            this.dateTime_birthdate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTime_birthdate.CustomFormat = "dd/MM/yyyy";
            this.dateTime_birthdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTime_birthdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTime_birthdate.Location = new System.Drawing.Point(178, 171);
            this.dateTime_birthdate.Name = "dateTime_birthdate";
            this.dateTime_birthdate.Size = new System.Drawing.Size(396, 28);
            this.dateTime_birthdate.TabIndex = 15;
            this.dateTime_birthdate.Value = new System.DateTime(2022, 3, 14, 0, 0, 0, 0);
            // 
            // rB_male
            // 
            this.rB_male.AutoSize = true;
            this.rB_male.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rB_male.Location = new System.Drawing.Point(178, 225);
            this.rB_male.Name = "rB_male";
            this.rB_male.Size = new System.Drawing.Size(69, 26);
            this.rB_male.TabIndex = 16;
            this.rB_male.TabStop = true;
            this.rB_male.Text = "Male";
            this.rB_male.UseVisualStyleBackColor = true;
            // 
            // rB_Female
            // 
            this.rB_Female.AutoSize = true;
            this.rB_Female.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rB_Female.Location = new System.Drawing.Point(344, 221);
            this.rB_Female.Name = "rB_Female";
            this.rB_Female.Size = new System.Drawing.Size(90, 26);
            this.rB_Female.TabIndex = 17;
            this.rB_Female.TabStop = true;
            this.rB_Female.Text = "Female";
            this.rB_Female.UseVisualStyleBackColor = true;
            // 
            // bt_cancel
            // 
            this.bt_cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bt_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_cancel.Location = new System.Drawing.Point(84, 587);
            this.bt_cancel.Name = "bt_cancel";
            this.bt_cancel.Size = new System.Drawing.Size(125, 40);
            this.bt_cancel.TabIndex = 19;
            this.bt_cancel.Text = "Cancel";
            this.bt_cancel.UseVisualStyleBackColor = false;
            this.bt_cancel.Click += new System.EventHandler(this.bt_cancel_Click);
            // 
            // bt_add
            // 
            this.bt_add.BackColor = System.Drawing.Color.Cyan;
            this.bt_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_add.Location = new System.Drawing.Point(417, 587);
            this.bt_add.Name = "bt_add";
            this.bt_add.Size = new System.Drawing.Size(125, 40);
            this.bt_add.TabIndex = 20;
            this.bt_add.Text = "Add";
            this.bt_add.UseVisualStyleBackColor = false;
            this.bt_add.Click += new System.EventHandler(this.bt_add_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(178, 410);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(396, 119);
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            // 
            // errorProvider_id
            // 
            this.errorProvider_id.ContainerControl = this;
            // 
            // errorProvider_phone
            // 
            this.errorProvider_phone.ContainerControl = this;
            // 
            // errorProvider_fname
            // 
            this.errorProvider_fname.ContainerControl = this;
            // 
            // errorProvider_lname
            // 
            this.errorProvider_lname.ContainerControl = this;
            // 
            // AddStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(615, 635);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.bt_add);
            this.Controls.Add(this.bt_cancel);
            this.Controls.Add(this.rB_Female);
            this.Controls.Add(this.rB_male);
            this.Controls.Add(this.dateTime_birthdate);
            this.Controls.Add(this.tB_studentid);
            this.Controls.Add(this.tB_firstname);
            this.Controls.Add(this.tB_lastname);
            this.Controls.Add(this.tB_phone);
            this.Controls.Add(this.tB_address);
            this.Controls.Add(this.bt_upload);
            this.Controls.Add(this.lb_picture);
            this.Controls.Add(this.lb_address);
            this.Controls.Add(this.lb_phone);
            this.Controls.Add(this.lb_Gender);
            this.Controls.Add(this.lb_birthdate);
            this.Controls.Add(this.lb_LastName);
            this.Controls.Add(this.lb_FirstName);
            this.Controls.Add(this.lb_StudentID);
            this.Name = "AddStudentForm";
            this.Text = "AddStudentForm";
            this.Load += new System.EventHandler(this.AddStudentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_id)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_phone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_fname)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_lname)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_StudentID;
        private System.Windows.Forms.Label lb_FirstName;
        private System.Windows.Forms.Label lb_LastName;
        private System.Windows.Forms.Label lb_birthdate;
        private System.Windows.Forms.Label lb_Gender;
        private System.Windows.Forms.Label lb_phone;
        private System.Windows.Forms.Label lb_address;
        private System.Windows.Forms.Label lb_picture;
        private System.Windows.Forms.Button bt_upload;
        private System.Windows.Forms.TextBox tB_address;
        private System.Windows.Forms.TextBox tB_phone;
        private System.Windows.Forms.TextBox tB_lastname;
        private System.Windows.Forms.TextBox tB_firstname;
        private System.Windows.Forms.TextBox tB_studentid;
        private System.Windows.Forms.DateTimePicker dateTime_birthdate;
        private System.Windows.Forms.RadioButton rB_male;
        private System.Windows.Forms.RadioButton rB_Female;
        private System.Windows.Forms.Button bt_cancel;
        private System.Windows.Forms.Button bt_add;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ErrorProvider errorProvider_id;
        private System.Windows.Forms.ErrorProvider errorProvider_phone;
        private System.Windows.Forms.ErrorProvider errorProvider_fname;
        private System.Windows.Forms.ErrorProvider errorProvider_lname;
    }
}