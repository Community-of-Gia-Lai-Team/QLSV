namespace WindowsFormsApp1
{
    partial class Print
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
            this.radioButton_all = new System.Windows.Forms.RadioButton();
            this.radioButton_male = new System.Windows.Forms.RadioButton();
            this.radioButton_female = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_check = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.radioButton_No = new System.Windows.Forms.RadioButton();
            this.radioButton_yes = new System.Windows.Forms.RadioButton();
            this.label_birthdate_between = new System.Windows.Forms.Label();
            this.label_dateranger = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.stdBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.viduDataSet2 = new WindowsFormsApp1.viduDataSet2();
            this.stdTableAdapter = new WindowsFormsApp1.viduDataSet2TableAdapters.stdTableAdapter();
            this.button_savetofile = new System.Windows.Forms.Button();
            this.button_toprinter = new System.Windows.Forms.Button();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_file = new System.Windows.Forms.ComboBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stdBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viduDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // radioButton_all
            // 
            this.radioButton_all.AutoSize = true;
            this.radioButton_all.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_all.Location = new System.Drawing.Point(25, 71);
            this.radioButton_all.Name = "radioButton_all";
            this.radioButton_all.Size = new System.Drawing.Size(54, 26);
            this.radioButton_all.TabIndex = 0;
            this.radioButton_all.TabStop = true;
            this.radioButton_all.Text = "All";
            this.radioButton_all.UseVisualStyleBackColor = true;
            // 
            // radioButton_male
            // 
            this.radioButton_male.AutoSize = true;
            this.radioButton_male.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_male.Location = new System.Drawing.Point(123, 71);
            this.radioButton_male.Name = "radioButton_male";
            this.radioButton_male.Size = new System.Drawing.Size(73, 26);
            this.radioButton_male.TabIndex = 1;
            this.radioButton_male.TabStop = true;
            this.radioButton_male.Text = "Male";
            this.radioButton_male.UseVisualStyleBackColor = true;
            // 
            // radioButton_female
            // 
            this.radioButton_female.AutoSize = true;
            this.radioButton_female.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_female.Location = new System.Drawing.Point(240, 71);
            this.radioButton_female.Name = "radioButton_female";
            this.radioButton_female.Size = new System.Drawing.Size(96, 26);
            this.radioButton_female.TabIndex = 2;
            this.radioButton_female.TabStop = true;
            this.radioButton_female.Text = "Female";
            this.radioButton_female.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.groupBox1.Controls.Add(this.button_check);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.radioButton_all);
            this.groupBox1.Controls.Add(this.radioButton_female);
            this.groupBox1.Controls.Add(this.radioButton_male);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1116, 162);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // button_check
            // 
            this.button_check.BackColor = System.Drawing.Color.Tomato;
            this.button_check.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_check.Location = new System.Drawing.Point(955, 61);
            this.button_check.Name = "button_check";
            this.button_check.Size = new System.Drawing.Size(155, 39);
            this.button_check.TabIndex = 4;
            this.button_check.Text = "CHECK";
            this.button_check.UseVisualStyleBackColor = false;
            this.button_check.Click += new System.EventHandler(this.button_check_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dateTimePicker2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Controls.Add(this.radioButton_No);
            this.groupBox2.Controls.Add(this.radioButton_yes);
            this.groupBox2.Controls.Add(this.label_birthdate_between);
            this.groupBox2.Controls.Add(this.label_dateranger);
            this.groupBox2.Location = new System.Drawing.Point(369, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(562, 121);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(407, 65);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(131, 28);
            this.dateTimePicker2.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(356, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "And";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(218, 66);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(131, 28);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // radioButton_No
            // 
            this.radioButton_No.AutoSize = true;
            this.radioButton_No.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_No.Location = new System.Drawing.Point(345, 25);
            this.radioButton_No.Name = "radioButton_No";
            this.radioButton_No.Size = new System.Drawing.Size(56, 26);
            this.radioButton_No.TabIndex = 8;
            this.radioButton_No.TabStop = true;
            this.radioButton_No.Text = "No";
            this.radioButton_No.UseVisualStyleBackColor = true;
            this.radioButton_No.CheckedChanged += new System.EventHandler(this.radioButton_No_CheckedChanged);
            // 
            // radioButton_yes
            // 
            this.radioButton_yes.AutoSize = true;
            this.radioButton_yes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_yes.Location = new System.Drawing.Point(229, 25);
            this.radioButton_yes.Name = "radioButton_yes";
            this.radioButton_yes.Size = new System.Drawing.Size(65, 26);
            this.radioButton_yes.TabIndex = 7;
            this.radioButton_yes.TabStop = true;
            this.radioButton_yes.Text = "Yes";
            this.radioButton_yes.UseVisualStyleBackColor = true;
            this.radioButton_yes.CheckedChanged += new System.EventHandler(this.radioButton_yes_CheckedChanged);
            // 
            // label_birthdate_between
            // 
            this.label_birthdate_between.AutoSize = true;
            this.label_birthdate_between.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_birthdate_between.Location = new System.Drawing.Point(15, 71);
            this.label_birthdate_between.Name = "label_birthdate_between";
            this.label_birthdate_between.Size = new System.Drawing.Size(183, 22);
            this.label_birthdate_between.TabIndex = 5;
            this.label_birthdate_between.Text = "BirthDate Between:";
            // 
            // label_dateranger
            // 
            this.label_dateranger.AutoSize = true;
            this.label_dateranger.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_dateranger.Location = new System.Drawing.Point(15, 27);
            this.label_dateranger.Name = "label_dateranger";
            this.label_dateranger.Size = new System.Drawing.Size(170, 22);
            this.label_dateranger.TabIndex = 6;
            this.label_dateranger.Text = "Use Date Ranger:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.fnameDataGridViewTextBoxColumn,
            this.lnameDataGridViewTextBoxColumn,
            this.bdateDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.pictureDataGridViewImageColumn});
            this.dataGridView1.DataSource = this.stdBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 181);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1116, 299);
            this.dataGridView1.TabIndex = 4;
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
            this.fnameDataGridViewTextBoxColumn.HeaderText = "First name";
            this.fnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fnameDataGridViewTextBoxColumn.Name = "fnameDataGridViewTextBoxColumn";
            this.fnameDataGridViewTextBoxColumn.Width = 125;
            // 
            // lnameDataGridViewTextBoxColumn
            // 
            this.lnameDataGridViewTextBoxColumn.DataPropertyName = "lname";
            this.lnameDataGridViewTextBoxColumn.HeaderText = "Last name";
            this.lnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lnameDataGridViewTextBoxColumn.Name = "lnameDataGridViewTextBoxColumn";
            this.lnameDataGridViewTextBoxColumn.Width = 125;
            // 
            // bdateDataGridViewTextBoxColumn
            // 
            this.bdateDataGridViewTextBoxColumn.DataPropertyName = "bdate";
            this.bdateDataGridViewTextBoxColumn.HeaderText = "Birthdate";
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
            this.stdBindingSource.DataSource = this.viduDataSet2;
            // 
            // viduDataSet2
            // 
            this.viduDataSet2.DataSetName = "viduDataSet2";
            this.viduDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stdTableAdapter
            // 
            this.stdTableAdapter.ClearBeforeFill = true;
            // 
            // button_savetofile
            // 
            this.button_savetofile.BackColor = System.Drawing.Color.Yellow;
            this.button_savetofile.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_savetofile.Location = new System.Drawing.Point(252, 542);
            this.button_savetofile.Name = "button_savetofile";
            this.button_savetofile.Size = new System.Drawing.Size(155, 51);
            this.button_savetofile.TabIndex = 5;
            this.button_savetofile.Text = "Save ";
            this.button_savetofile.UseVisualStyleBackColor = false;
            this.button_savetofile.Click += new System.EventHandler(this.button_savetofile_Click);
            // 
            // button_toprinter
            // 
            this.button_toprinter.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_toprinter.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_toprinter.Location = new System.Drawing.Point(741, 542);
            this.button_toprinter.Name = "button_toprinter";
            this.button_toprinter.Size = new System.Drawing.Size(161, 51);
            this.button_toprinter.TabIndex = 6;
            this.button_toprinter.Text = "To Printer";
            this.button_toprinter.UseVisualStyleBackColor = false;
            this.button_toprinter.Click += new System.EventHandler(this.button_toprinter_Click);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(105, 502);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 22);
            this.label2.TabIndex = 7;
            this.label2.Text = "Save as type:";
            // 
            // comboBox_file
            // 
            this.comboBox_file.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_file.FormattingEnabled = true;
            this.comboBox_file.Items.AddRange(new object[] {
            "Excel",
            "Word",
            "Text",
            "PDF"});
            this.comboBox_file.Location = new System.Drawing.Point(252, 500);
            this.comboBox_file.Name = "comboBox_file";
            this.comboBox_file.Size = new System.Drawing.Size(155, 24);
            this.comboBox_file.TabIndex = 8;
            // 
            // Print
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1148, 633);
            this.Controls.Add(this.comboBox_file);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_toprinter);
            this.Controls.Add(this.button_savetofile);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Print";
            this.Text = "Print";
            this.Load += new System.EventHandler(this.Print_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stdBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viduDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButton_all;
        private System.Windows.Forms.RadioButton radioButton_male;
        private System.Windows.Forms.RadioButton radioButton_female;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label_birthdate_between;
        private System.Windows.Forms.Label label_dateranger;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_check;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.RadioButton radioButton_No;
        private System.Windows.Forms.RadioButton radioButton_yes;
        private System.Windows.Forms.DataGridView dataGridView1;
        private viduDataSet2 viduDataSet2;
        private System.Windows.Forms.BindingSource stdBindingSource;
        private viduDataSet2TableAdapters.stdTableAdapter stdTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn pictureDataGridViewImageColumn;
        private System.Windows.Forms.Button button_savetofile;
        private System.Windows.Forms.Button button_toprinter;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_file;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}