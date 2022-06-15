namespace WindowsFormsApp1
{
    partial class ManageStudentForm
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
            this.label_fname = new System.Windows.Forms.Label();
            this.label_lname = new System.Windows.Forms.Label();
            this.label_bdate = new System.Windows.Forms.Label();
            this.label_gender = new System.Windows.Forms.Label();
            this.label_phone = new System.Windows.Forms.Label();
            this.label_address = new System.Windows.Forms.Label();
            this.label_picture = new System.Windows.Forms.Label();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.textBox_lname = new System.Windows.Forms.TextBox();
            this.textBox_fname = new System.Windows.Forms.TextBox();
            this.textBox_phone = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.radioButton_male = new System.Windows.Forms.RadioButton();
            this.radioButton_female = new System.Windows.Forms.RadioButton();
            this.textBox_address = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_upload = new System.Windows.Forms.Button();
            this.button_download = new System.Windows.Forms.Button();
            this.button_add = new System.Windows.Forms.Button();
            this.button_edit = new System.Windows.Forms.Button();
            this.button_reset = new System.Windows.Forms.Button();
            this.button_remove = new System.Windows.Forms.Button();
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.stdBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.viduDataSet1 = new WindowsFormsApp1.viduDataSet1();
            this.label_search = new System.Windows.Forms.Label();
            this.textBox_search = new System.Windows.Forms.TextBox();
            this.button_search = new System.Windows.Forms.Button();
            this.stdTableAdapter = new WindowsFormsApp1.viduDataSet1TableAdapters.stdTableAdapter();
            this.label_totalstudent = new System.Windows.Forms.Label();
            this.errorProvider_id = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider_phone = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider_fname = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider_lname = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stdBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viduDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_id)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_phone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_fname)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_lname)).BeginInit();
            this.SuspendLayout();
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_id.Location = new System.Drawing.Point(97, 39);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(32, 22);
            this.label_id.TabIndex = 0;
            this.label_id.Text = "ID:";
            // 
            // label_fname
            // 
            this.label_fname.AutoSize = true;
            this.label_fname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_fname.Location = new System.Drawing.Point(29, 88);
            this.label_fname.Name = "label_fname";
            this.label_fname.Size = new System.Drawing.Size(102, 22);
            this.label_fname.TabIndex = 1;
            this.label_fname.Text = "First Name:";
            // 
            // label_lname
            // 
            this.label_lname.AutoSize = true;
            this.label_lname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_lname.Location = new System.Drawing.Point(28, 146);
            this.label_lname.Name = "label_lname";
            this.label_lname.Size = new System.Drawing.Size(101, 22);
            this.label_lname.TabIndex = 2;
            this.label_lname.Text = "Last Name:";
            // 
            // label_bdate
            // 
            this.label_bdate.AutoSize = true;
            this.label_bdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_bdate.Location = new System.Drawing.Point(39, 202);
            this.label_bdate.Name = "label_bdate";
            this.label_bdate.Size = new System.Drawing.Size(90, 22);
            this.label_bdate.TabIndex = 3;
            this.label_bdate.Text = "BirthDate:";
            // 
            // label_gender
            // 
            this.label_gender.AutoSize = true;
            this.label_gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_gender.Location = new System.Drawing.Point(54, 263);
            this.label_gender.Name = "label_gender";
            this.label_gender.Size = new System.Drawing.Size(75, 22);
            this.label_gender.TabIndex = 4;
            this.label_gender.Text = "Gender:";
            // 
            // label_phone
            // 
            this.label_phone.AutoSize = true;
            this.label_phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_phone.Location = new System.Drawing.Point(58, 312);
            this.label_phone.Name = "label_phone";
            this.label_phone.Size = new System.Drawing.Size(67, 22);
            this.label_phone.TabIndex = 5;
            this.label_phone.Text = "Phone:";
            // 
            // label_address
            // 
            this.label_address.AutoSize = true;
            this.label_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_address.Location = new System.Drawing.Point(48, 374);
            this.label_address.Name = "label_address";
            this.label_address.Size = new System.Drawing.Size(81, 22);
            this.label_address.TabIndex = 6;
            this.label_address.Text = "Address:";
            // 
            // label_picture
            // 
            this.label_picture.AutoSize = true;
            this.label_picture.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_picture.Location = new System.Drawing.Point(58, 496);
            this.label_picture.Name = "label_picture";
            this.label_picture.Size = new System.Drawing.Size(71, 22);
            this.label_picture.TabIndex = 7;
            this.label_picture.Text = "Picture:";
            // 
            // textBox_id
            // 
            this.textBox_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_id.Location = new System.Drawing.Point(156, 33);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(266, 28);
            this.textBox_id.TabIndex = 8;
            this.textBox_id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_id_KeyPress);
            // 
            // textBox_lname
            // 
            this.textBox_lname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_lname.Location = new System.Drawing.Point(156, 140);
            this.textBox_lname.Name = "textBox_lname";
            this.textBox_lname.Size = new System.Drawing.Size(266, 28);
            this.textBox_lname.TabIndex = 9;
            this.textBox_lname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_lname_KeyPress);
            // 
            // textBox_fname
            // 
            this.textBox_fname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_fname.Location = new System.Drawing.Point(156, 82);
            this.textBox_fname.Name = "textBox_fname";
            this.textBox_fname.Size = new System.Drawing.Size(266, 28);
            this.textBox_fname.TabIndex = 10;
            this.textBox_fname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_fname_KeyPress);
            // 
            // textBox_phone
            // 
            this.textBox_phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_phone.Location = new System.Drawing.Point(156, 312);
            this.textBox_phone.Name = "textBox_phone";
            this.textBox_phone.Size = new System.Drawing.Size(266, 28);
            this.textBox_phone.TabIndex = 11;
            this.textBox_phone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_phone_KeyPress);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(156, 196);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(266, 28);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // radioButton_male
            // 
            this.radioButton_male.AutoSize = true;
            this.radioButton_male.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_male.Location = new System.Drawing.Point(156, 261);
            this.radioButton_male.Name = "radioButton_male";
            this.radioButton_male.Size = new System.Drawing.Size(69, 26);
            this.radioButton_male.TabIndex = 13;
            this.radioButton_male.TabStop = true;
            this.radioButton_male.Text = "Male";
            this.radioButton_male.UseVisualStyleBackColor = true;
            // 
            // radioButton_female
            // 
            this.radioButton_female.AutoSize = true;
            this.radioButton_female.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_female.Location = new System.Drawing.Point(318, 261);
            this.radioButton_female.Name = "radioButton_female";
            this.radioButton_female.Size = new System.Drawing.Size(90, 26);
            this.radioButton_female.TabIndex = 14;
            this.radioButton_female.TabStop = true;
            this.radioButton_female.Text = "Female";
            this.radioButton_female.UseVisualStyleBackColor = true;
            // 
            // textBox_address
            // 
            this.textBox_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_address.Location = new System.Drawing.Point(156, 374);
            this.textBox_address.Multiline = true;
            this.textBox_address.Name = "textBox_address";
            this.textBox_address.Size = new System.Drawing.Size(266, 85);
            this.textBox_address.TabIndex = 15;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(156, 496);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(266, 138);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // button_upload
            // 
            this.button_upload.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_upload.Location = new System.Drawing.Point(156, 636);
            this.button_upload.Name = "button_upload";
            this.button_upload.Size = new System.Drawing.Size(123, 29);
            this.button_upload.TabIndex = 17;
            this.button_upload.Text = "Upload";
            this.button_upload.UseVisualStyleBackColor = true;
            this.button_upload.Click += new System.EventHandler(this.button_upload_Click);
            // 
            // button_download
            // 
            this.button_download.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_download.Location = new System.Drawing.Point(294, 636);
            this.button_download.Name = "button_download";
            this.button_download.Size = new System.Drawing.Size(128, 29);
            this.button_download.TabIndex = 18;
            this.button_download.Text = "Download";
            this.button_download.UseVisualStyleBackColor = true;
            this.button_download.Click += new System.EventHandler(this.button_download_Click);
            // 
            // button_add
            // 
            this.button_add.BackColor = System.Drawing.Color.Cyan;
            this.button_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_add.Location = new System.Drawing.Point(43, 693);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(86, 38);
            this.button_add.TabIndex = 19;
            this.button_add.Text = "Add";
            this.button_add.UseVisualStyleBackColor = false;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // button_edit
            // 
            this.button_edit.BackColor = System.Drawing.Color.Yellow;
            this.button_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_edit.Location = new System.Drawing.Point(172, 693);
            this.button_edit.Name = "button_edit";
            this.button_edit.Size = new System.Drawing.Size(97, 38);
            this.button_edit.TabIndex = 20;
            this.button_edit.Text = "Edit";
            this.button_edit.UseVisualStyleBackColor = false;
            this.button_edit.Click += new System.EventHandler(this.button_edit_Click);
            // 
            // button_reset
            // 
            this.button_reset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button_reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_reset.Location = new System.Drawing.Point(471, 693);
            this.button_reset.Name = "button_reset";
            this.button_reset.Size = new System.Drawing.Size(88, 38);
            this.button_reset.TabIndex = 21;
            this.button_reset.Text = "Reset";
            this.button_reset.UseVisualStyleBackColor = false;
            this.button_reset.Click += new System.EventHandler(this.button_reset_Click);
            // 
            // button_remove
            // 
            this.button_remove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button_remove.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_remove.Location = new System.Drawing.Point(319, 693);
            this.button_remove.Name = "button_remove";
            this.button_remove.Size = new System.Drawing.Size(103, 38);
            this.button_remove.TabIndex = 22;
            this.button_remove.Text = "Remove";
            this.button_remove.UseVisualStyleBackColor = false;
            this.button_remove.Click += new System.EventHandler(this.button_remove_Click);
            // 
            // DataGridView1
            // 
            this.DataGridView1.AutoGenerateColumns = false;
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.fnameDataGridViewTextBoxColumn,
            this.lnameDataGridViewTextBoxColumn,
            this.bdateDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.pictureDataGridViewImageColumn});
            this.DataGridView1.DataSource = this.stdBindingSource;
            this.DataGridView1.Location = new System.Drawing.Point(509, 67);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.RowHeadersWidth = 51;
            this.DataGridView1.RowTemplate.Height = 24;
            this.DataGridView1.Size = new System.Drawing.Size(808, 583);
            this.DataGridView1.TabIndex = 23;
            this.DataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // fnameDataGridViewTextBoxColumn
            // 
            this.fnameDataGridViewTextBoxColumn.DataPropertyName = "fname";
            this.fnameDataGridViewTextBoxColumn.HeaderText = "First Name";
            this.fnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fnameDataGridViewTextBoxColumn.Name = "fnameDataGridViewTextBoxColumn";
            this.fnameDataGridViewTextBoxColumn.Width = 125;
            // 
            // lnameDataGridViewTextBoxColumn
            // 
            this.lnameDataGridViewTextBoxColumn.DataPropertyName = "lname";
            this.lnameDataGridViewTextBoxColumn.HeaderText = "Last Name";
            this.lnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lnameDataGridViewTextBoxColumn.Name = "lnameDataGridViewTextBoxColumn";
            this.lnameDataGridViewTextBoxColumn.Width = 125;
            // 
            // bdateDataGridViewTextBoxColumn
            // 
            this.bdateDataGridViewTextBoxColumn.DataPropertyName = "bdate";
            this.bdateDataGridViewTextBoxColumn.HeaderText = "BirthDate";
            this.bdateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bdateDataGridViewTextBoxColumn.Name = "bdateDataGridViewTextBoxColumn";
            this.bdateDataGridViewTextBoxColumn.Width = 125;
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.genderDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            this.genderDataGridViewTextBoxColumn.Width = 125;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.phoneDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.Width = 125;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.Width = 125;
            // 
            // pictureDataGridViewImageColumn
            // 
            this.pictureDataGridViewImageColumn.DataPropertyName = "picture";
            this.pictureDataGridViewImageColumn.HeaderText = "Picture";
            this.pictureDataGridViewImageColumn.MinimumWidth = 6;
            this.pictureDataGridViewImageColumn.Name = "pictureDataGridViewImageColumn";
            this.pictureDataGridViewImageColumn.Width = 125;
            // 
            // stdBindingSource
            // 
            this.stdBindingSource.DataMember = "std";
            this.stdBindingSource.DataSource = this.viduDataSet1;
            // 
            // viduDataSet1
            // 
            this.viduDataSet1.DataSetName = "viduDataSet1";
            this.viduDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label_search
            // 
            this.label_search.AutoSize = true;
            this.label_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_search.Location = new System.Drawing.Point(577, 39);
            this.label_search.Name = "label_search";
            this.label_search.Size = new System.Drawing.Size(215, 22);
            this.label_search.TabIndex = 24;
            this.label_search.Text = "Enter A Value To Search:";
            // 
            // textBox_search
            // 
            this.textBox_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_search.Location = new System.Drawing.Point(815, 33);
            this.textBox_search.Name = "textBox_search";
            this.textBox_search.Size = new System.Drawing.Size(347, 28);
            this.textBox_search.TabIndex = 25;
            // 
            // button_search
            // 
            this.button_search.BackColor = System.Drawing.Color.Wheat;
            this.button_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_search.Location = new System.Drawing.Point(1195, 33);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(122, 28);
            this.button_search.TabIndex = 26;
            this.button_search.Text = "SEARCH";
            this.button_search.UseVisualStyleBackColor = false;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // stdTableAdapter
            // 
            this.stdTableAdapter.ClearBeforeFill = true;
            // 
            // label_totalstudent
            // 
            this.label_totalstudent.AutoSize = true;
            this.label_totalstudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label_totalstudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_totalstudent.Location = new System.Drawing.Point(1152, 668);
            this.label_totalstudent.Name = "label_totalstudent";
            this.label_totalstudent.Size = new System.Drawing.Size(123, 22);
            this.label_totalstudent.TabIndex = 27;
            this.label_totalstudent.Text = "Total Student:";
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
            // ManageStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1329, 743);
            this.Controls.Add(this.label_totalstudent);
            this.Controls.Add(this.button_search);
            this.Controls.Add(this.textBox_search);
            this.Controls.Add(this.label_search);
            this.Controls.Add(this.DataGridView1);
            this.Controls.Add(this.button_remove);
            this.Controls.Add(this.button_reset);
            this.Controls.Add(this.button_edit);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.button_download);
            this.Controls.Add(this.button_upload);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox_address);
            this.Controls.Add(this.radioButton_female);
            this.Controls.Add(this.radioButton_male);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox_phone);
            this.Controls.Add(this.textBox_fname);
            this.Controls.Add(this.textBox_lname);
            this.Controls.Add(this.textBox_id);
            this.Controls.Add(this.label_picture);
            this.Controls.Add(this.label_address);
            this.Controls.Add(this.label_phone);
            this.Controls.Add(this.label_gender);
            this.Controls.Add(this.label_bdate);
            this.Controls.Add(this.label_lname);
            this.Controls.Add(this.label_fname);
            this.Controls.Add(this.label_id);
            this.Name = "ManageStudentForm";
            this.Text = "ManageStudentForm";
            this.Load += new System.EventHandler(this.ManageStudentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stdBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viduDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_id)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_phone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_fname)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_lname)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.Label label_fname;
        private System.Windows.Forms.Label label_lname;
        private System.Windows.Forms.Label label_bdate;
        private System.Windows.Forms.Label label_gender;
        private System.Windows.Forms.Label label_phone;
        private System.Windows.Forms.Label label_address;
        private System.Windows.Forms.Label label_picture;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.TextBox textBox_lname;
        private System.Windows.Forms.TextBox textBox_fname;
        private System.Windows.Forms.TextBox textBox_phone;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.RadioButton radioButton_male;
        private System.Windows.Forms.RadioButton radioButton_female;
        private System.Windows.Forms.TextBox textBox_address;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button_upload;
        private System.Windows.Forms.Button button_download;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Button button_edit;
        private System.Windows.Forms.Button button_reset;
        private System.Windows.Forms.Button button_remove;
        private System.Windows.Forms.DataGridView DataGridView1;
        private System.Windows.Forms.Label label_search;
        private System.Windows.Forms.TextBox textBox_search;
        private System.Windows.Forms.Button button_search;
        private viduDataSet1 viduDataSet1;
        private System.Windows.Forms.BindingSource stdBindingSource;
        private viduDataSet1TableAdapters.stdTableAdapter stdTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn pictureDataGridViewImageColumn;
        private System.Windows.Forms.Label label_totalstudent;
        private System.Windows.Forms.ErrorProvider errorProvider_id;
        private System.Windows.Forms.ErrorProvider errorProvider_phone;
        private System.Windows.Forms.ErrorProvider errorProvider_fname;
        private System.Windows.Forms.ErrorProvider errorProvider_lname;
    }
}