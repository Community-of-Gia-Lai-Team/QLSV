namespace WindowsFormsApp1
{
    partial class UpdateDeleteStudentForm
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
            this.textBox_ID = new System.Windows.Forms.TextBox();
            this.tableAdapterManager1 = new WindowsFormsApp1.viduDataSetTableAdapters.TableAdapterManager();
            this.label_ID = new System.Windows.Forms.Label();
            this.label_Firstname = new System.Windows.Forms.Label();
            this.label_Lastname = new System.Windows.Forms.Label();
            this.label_Birthdate = new System.Windows.Forms.Label();
            this.label_gender = new System.Windows.Forms.Label();
            this.label_phone = new System.Windows.Forms.Label();
            this.textBox_phone = new System.Windows.Forms.TextBox();
            this.textBox_lastname = new System.Windows.Forms.TextBox();
            this.textBox_firstname = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.radioButton_Male = new System.Windows.Forms.RadioButton();
            this.radioButton_female = new System.Windows.Forms.RadioButton();
            this.button_find = new System.Windows.Forms.Button();
            this.label_address = new System.Windows.Forms.Label();
            this.label_picture = new System.Windows.Forms.Label();
            this.textBox_address = new System.Windows.Forms.TextBox();
            this.pictureBox_student = new System.Windows.Forms.PictureBox();
            this.button_uploadimage = new System.Windows.Forms.Button();
            this.button_edit = new System.Windows.Forms.Button();
            this.button_remove = new System.Windows.Forms.Button();
            this.button_findphone = new System.Windows.Forms.Button();
            this.button_search = new System.Windows.Forms.Button();
            this.viduDataSet = new WindowsFormsApp1.viduDataSet();
            this.viduDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stdBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.stdTableAdapter = new WindowsFormsApp1.viduDataSetTableAdapters.stdTableAdapter();
            this.stdBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.error_phone = new System.Windows.Forms.ErrorProvider(this.components);
            this.error_ID = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_student)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viduDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viduDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stdBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stdBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_phone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_ID)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_ID
            // 
            this.textBox_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_ID.Location = new System.Drawing.Point(159, 43);
            this.textBox_ID.Name = "textBox_ID";
            this.textBox_ID.Size = new System.Drawing.Size(116, 28);
            this.textBox_ID.TabIndex = 0;
            this.textBox_ID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_ID_KeyPress);
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Connection = null;
            this.tableAdapterManager1.stdTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = WindowsFormsApp1.viduDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // label_ID
            // 
            this.label_ID.AutoSize = true;
            this.label_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ID.Location = new System.Drawing.Point(101, 49);
            this.label_ID.Name = "label_ID";
            this.label_ID.Size = new System.Drawing.Size(32, 22);
            this.label_ID.TabIndex = 1;
            this.label_ID.Text = "ID:";
            // 
            // label_Firstname
            // 
            this.label_Firstname.AutoSize = true;
            this.label_Firstname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Firstname.Location = new System.Drawing.Point(31, 97);
            this.label_Firstname.Name = "label_Firstname";
            this.label_Firstname.Size = new System.Drawing.Size(102, 22);
            this.label_Firstname.TabIndex = 2;
            this.label_Firstname.Text = "First Name:";
            // 
            // label_Lastname
            // 
            this.label_Lastname.AutoSize = true;
            this.label_Lastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Lastname.Location = new System.Drawing.Point(32, 146);
            this.label_Lastname.Name = "label_Lastname";
            this.label_Lastname.Size = new System.Drawing.Size(101, 22);
            this.label_Lastname.TabIndex = 3;
            this.label_Lastname.Text = "Last Name:";
            // 
            // label_Birthdate
            // 
            this.label_Birthdate.AutoSize = true;
            this.label_Birthdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Birthdate.Location = new System.Drawing.Point(43, 196);
            this.label_Birthdate.Name = "label_Birthdate";
            this.label_Birthdate.Size = new System.Drawing.Size(90, 22);
            this.label_Birthdate.TabIndex = 4;
            this.label_Birthdate.Text = "BirthDate:";
            // 
            // label_gender
            // 
            this.label_gender.AutoSize = true;
            this.label_gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_gender.Location = new System.Drawing.Point(58, 250);
            this.label_gender.Name = "label_gender";
            this.label_gender.Size = new System.Drawing.Size(75, 22);
            this.label_gender.TabIndex = 5;
            this.label_gender.Text = "Gender:";
            // 
            // label_phone
            // 
            this.label_phone.AutoSize = true;
            this.label_phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_phone.Location = new System.Drawing.Point(66, 307);
            this.label_phone.Name = "label_phone";
            this.label_phone.Size = new System.Drawing.Size(67, 22);
            this.label_phone.TabIndex = 6;
            this.label_phone.Text = "Phone:";
            // 
            // textBox_phone
            // 
            this.textBox_phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_phone.Location = new System.Drawing.Point(159, 307);
            this.textBox_phone.Name = "textBox_phone";
            this.textBox_phone.Size = new System.Drawing.Size(116, 28);
            this.textBox_phone.TabIndex = 8;
            this.textBox_phone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_phone_KeyPress);
            // 
            // textBox_lastname
            // 
            this.textBox_lastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_lastname.Location = new System.Drawing.Point(159, 140);
            this.textBox_lastname.Name = "textBox_lastname";
            this.textBox_lastname.Size = new System.Drawing.Size(259, 28);
            this.textBox_lastname.TabIndex = 10;
            // 
            // textBox_firstname
            // 
            this.textBox_firstname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_firstname.Location = new System.Drawing.Point(159, 91);
            this.textBox_firstname.Name = "textBox_firstname";
            this.textBox_firstname.Size = new System.Drawing.Size(116, 28);
            this.textBox_firstname.TabIndex = 11;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(159, 191);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(259, 28);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // radioButton_Male
            // 
            this.radioButton_Male.AutoSize = true;
            this.radioButton_Male.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_Male.Location = new System.Drawing.Point(179, 246);
            this.radioButton_Male.Name = "radioButton_Male";
            this.radioButton_Male.Size = new System.Drawing.Size(69, 26);
            this.radioButton_Male.TabIndex = 13;
            this.radioButton_Male.TabStop = true;
            this.radioButton_Male.Text = "Male";
            this.radioButton_Male.UseVisualStyleBackColor = true;
            // 
            // radioButton_female
            // 
            this.radioButton_female.AutoSize = true;
            this.radioButton_female.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_female.Location = new System.Drawing.Point(307, 246);
            this.radioButton_female.Name = "radioButton_female";
            this.radioButton_female.Size = new System.Drawing.Size(90, 26);
            this.radioButton_female.TabIndex = 14;
            this.radioButton_female.TabStop = true;
            this.radioButton_female.Text = "Female";
            this.radioButton_female.UseVisualStyleBackColor = true;
            // 
            // button_find
            // 
            this.button_find.BackColor = System.Drawing.Color.SpringGreen;
            this.button_find.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_find.Location = new System.Drawing.Point(307, 43);
            this.button_find.Name = "button_find";
            this.button_find.Size = new System.Drawing.Size(111, 31);
            this.button_find.TabIndex = 15;
            this.button_find.Text = "Find";
            this.button_find.UseVisualStyleBackColor = false;
            this.button_find.Click += new System.EventHandler(this.button_find_Click);
            // 
            // label_address
            // 
            this.label_address.AutoSize = true;
            this.label_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_address.Location = new System.Drawing.Point(511, 49);
            this.label_address.Name = "label_address";
            this.label_address.Size = new System.Drawing.Size(81, 22);
            this.label_address.TabIndex = 16;
            this.label_address.Text = "Address:";
            // 
            // label_picture
            // 
            this.label_picture.AutoSize = true;
            this.label_picture.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_picture.Location = new System.Drawing.Point(521, 146);
            this.label_picture.Name = "label_picture";
            this.label_picture.Size = new System.Drawing.Size(71, 22);
            this.label_picture.TabIndex = 17;
            this.label_picture.Text = "Picture:";
            // 
            // textBox_address
            // 
            this.textBox_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_address.Location = new System.Drawing.Point(616, 46);
            this.textBox_address.Multiline = true;
            this.textBox_address.Name = "textBox_address";
            this.textBox_address.Size = new System.Drawing.Size(268, 73);
            this.textBox_address.TabIndex = 18;
            // 
            // pictureBox_student
            // 
            this.pictureBox_student.Location = new System.Drawing.Point(616, 146);
            this.pictureBox_student.Name = "pictureBox_student";
            this.pictureBox_student.Size = new System.Drawing.Size(268, 150);
            this.pictureBox_student.TabIndex = 19;
            this.pictureBox_student.TabStop = false;
            // 
            // button_uploadimage
            // 
            this.button_uploadimage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_uploadimage.Location = new System.Drawing.Point(616, 302);
            this.button_uploadimage.Name = "button_uploadimage";
            this.button_uploadimage.Size = new System.Drawing.Size(268, 33);
            this.button_uploadimage.TabIndex = 20;
            this.button_uploadimage.Text = "Upload Image";
            this.button_uploadimage.UseVisualStyleBackColor = true;
            this.button_uploadimage.Click += new System.EventHandler(this.button_uploadimage_Click);
            // 
            // button_edit
            // 
            this.button_edit.BackColor = System.Drawing.Color.Yellow;
            this.button_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_edit.Location = new System.Drawing.Point(236, 380);
            this.button_edit.Name = "button_edit";
            this.button_edit.Size = new System.Drawing.Size(99, 36);
            this.button_edit.TabIndex = 21;
            this.button_edit.Text = "Edit";
            this.button_edit.UseVisualStyleBackColor = false;
            this.button_edit.Click += new System.EventHandler(this.button_edit_Click);
            // 
            // button_remove
            // 
            this.button_remove.BackColor = System.Drawing.SystemColors.Highlight;
            this.button_remove.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_remove.Location = new System.Drawing.Point(581, 380);
            this.button_remove.Name = "button_remove";
            this.button_remove.Size = new System.Drawing.Size(127, 36);
            this.button_remove.TabIndex = 22;
            this.button_remove.Text = "Remove";
            this.button_remove.UseVisualStyleBackColor = false;
            this.button_remove.Click += new System.EventHandler(this.button_remove_Click);
            // 
            // button_findphone
            // 
            this.button_findphone.BackColor = System.Drawing.Color.Yellow;
            this.button_findphone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_findphone.Location = new System.Drawing.Point(307, 305);
            this.button_findphone.Name = "button_findphone";
            this.button_findphone.Size = new System.Drawing.Size(111, 33);
            this.button_findphone.TabIndex = 23;
            this.button_findphone.Text = "Find";
            this.button_findphone.UseVisualStyleBackColor = false;
            this.button_findphone.Click += new System.EventHandler(this.button_findphone_Click);
            // 
            // button_search
            // 
            this.button_search.BackColor = System.Drawing.SystemColors.Highlight;
            this.button_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_search.Location = new System.Drawing.Point(307, 91);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(111, 28);
            this.button_search.TabIndex = 24;
            this.button_search.Text = "Search";
            this.button_search.UseVisualStyleBackColor = false;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // viduDataSet
            // 
            this.viduDataSet.DataSetName = "viduDataSet";
            this.viduDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // viduDataSetBindingSource
            // 
            this.viduDataSetBindingSource.DataSource = this.viduDataSet;
            this.viduDataSetBindingSource.Position = 0;
            // 
            // stdBindingSource1
            // 
            this.stdBindingSource1.DataMember = "std";
            this.stdBindingSource1.DataSource = this.viduDataSetBindingSource;
            // 
            // stdTableAdapter
            // 
            this.stdTableAdapter.ClearBeforeFill = true;
            // 
            // error_phone
            // 
            this.error_phone.ContainerControl = this;
            // 
            // error_ID
            // 
            this.error_ID.ContainerControl = this;
            // 
            // UpdateDeleteStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(896, 485);
            this.Controls.Add(this.button_search);
            this.Controls.Add(this.button_findphone);
            this.Controls.Add(this.button_remove);
            this.Controls.Add(this.button_edit);
            this.Controls.Add(this.button_uploadimage);
            this.Controls.Add(this.pictureBox_student);
            this.Controls.Add(this.textBox_address);
            this.Controls.Add(this.label_picture);
            this.Controls.Add(this.label_address);
            this.Controls.Add(this.button_find);
            this.Controls.Add(this.radioButton_female);
            this.Controls.Add(this.radioButton_Male);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox_firstname);
            this.Controls.Add(this.textBox_lastname);
            this.Controls.Add(this.textBox_phone);
            this.Controls.Add(this.label_phone);
            this.Controls.Add(this.label_gender);
            this.Controls.Add(this.label_Birthdate);
            this.Controls.Add(this.label_Lastname);
            this.Controls.Add(this.label_Firstname);
            this.Controls.Add(this.label_ID);
            this.Controls.Add(this.textBox_ID);
            this.Name = "UpdateDeleteStudentForm";
            this.Text = "UpdateDeleteStudentForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_student)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viduDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viduDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stdBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stdBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_phone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_ID)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private viduDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.Label label_ID;
        private System.Windows.Forms.Label label_Firstname;
        private System.Windows.Forms.Label label_Lastname;
        private System.Windows.Forms.Label label_Birthdate;
        private System.Windows.Forms.Label label_gender;
        private System.Windows.Forms.Label label_phone;
        private System.Windows.Forms.RadioButton radioButton_Male;
        private System.Windows.Forms.Button button_find;
        private System.Windows.Forms.Label label_address;
        private System.Windows.Forms.Label label_picture;
        private System.Windows.Forms.Button button_uploadimage;
        private System.Windows.Forms.Button button_edit;
        private System.Windows.Forms.Button button_remove;
        internal System.Windows.Forms.TextBox textBox_ID;
        internal System.Windows.Forms.TextBox textBox_lastname;
        internal System.Windows.Forms.DateTimePicker dateTimePicker1;
        internal System.Windows.Forms.RadioButton radioButton_female;
        internal System.Windows.Forms.TextBox textBox_phone;
        internal System.Windows.Forms.TextBox textBox_address;
        internal System.Windows.Forms.PictureBox pictureBox_student;
        private System.Windows.Forms.Button button_findphone;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.BindingSource viduDataSetBindingSource;
        private viduDataSet viduDataSet;
        private System.Windows.Forms.BindingSource stdBindingSource;
        private System.Windows.Forms.BindingSource stdBindingSource1;
        private viduDataSetTableAdapters.stdTableAdapter stdTableAdapter;
        internal System.Windows.Forms.TextBox textBox_firstname;
        private System.Windows.Forms.ErrorProvider error_phone;
        private System.Windows.Forms.ErrorProvider error_ID;
    }
}