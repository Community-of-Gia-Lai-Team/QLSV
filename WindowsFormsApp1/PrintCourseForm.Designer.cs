namespace WindowsFormsApp1
{
    partial class PrintCourseForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.periodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coursetableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.viduDataSet3 = new WindowsFormsApp1.viduDataSet3();
            this.course_tableTableAdapter = new WindowsFormsApp1.viduDataSet3TableAdapters.course_tableTableAdapter();
            this.button_totext = new System.Windows.Forms.Button();
            this.button_print = new System.Windows.Forms.Button();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.comboBox_file = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursetableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viduDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.labelDataGridViewTextBoxColumn,
            this.periodDataGridViewTextBoxColumn,
            this.descriptionsDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.coursetableBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(773, 340);
            this.dataGridView1.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // labelDataGridViewTextBoxColumn
            // 
            this.labelDataGridViewTextBoxColumn.DataPropertyName = "label";
            this.labelDataGridViewTextBoxColumn.HeaderText = "Course";
            this.labelDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.labelDataGridViewTextBoxColumn.Name = "labelDataGridViewTextBoxColumn";
            this.labelDataGridViewTextBoxColumn.Width = 125;
            // 
            // periodDataGridViewTextBoxColumn
            // 
            this.periodDataGridViewTextBoxColumn.DataPropertyName = "period";
            this.periodDataGridViewTextBoxColumn.HeaderText = "Period";
            this.periodDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.periodDataGridViewTextBoxColumn.Name = "periodDataGridViewTextBoxColumn";
            this.periodDataGridViewTextBoxColumn.Width = 125;
            // 
            // descriptionsDataGridViewTextBoxColumn
            // 
            this.descriptionsDataGridViewTextBoxColumn.DataPropertyName = "descriptions";
            this.descriptionsDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descriptionsDataGridViewTextBoxColumn.Name = "descriptionsDataGridViewTextBoxColumn";
            this.descriptionsDataGridViewTextBoxColumn.Width = 125;
            // 
            // coursetableBindingSource
            // 
            this.coursetableBindingSource.DataMember = "course_table";
            this.coursetableBindingSource.DataSource = this.viduDataSet3;
            // 
            // viduDataSet3
            // 
            this.viduDataSet3.DataSetName = "viduDataSet3";
            this.viduDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // course_tableTableAdapter
            // 
            this.course_tableTableAdapter.ClearBeforeFill = true;
            // 
            // button_totext
            // 
            this.button_totext.BackColor = System.Drawing.Color.Yellow;
            this.button_totext.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_totext.Location = new System.Drawing.Point(304, 400);
            this.button_totext.Name = "button_totext";
            this.button_totext.Size = new System.Drawing.Size(137, 43);
            this.button_totext.TabIndex = 1;
            this.button_totext.Text = "Save";
            this.button_totext.UseVisualStyleBackColor = false;
            this.button_totext.Click += new System.EventHandler(this.button_totext_Click);
            // 
            // button_print
            // 
            this.button_print.BackColor = System.Drawing.Color.Cyan;
            this.button_print.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_print.Location = new System.Drawing.Point(475, 400);
            this.button_print.Name = "button_print";
            this.button_print.Size = new System.Drawing.Size(137, 43);
            this.button_print.TabIndex = 2;
            this.button_print.Text = "Print";
            this.button_print.UseVisualStyleBackColor = false;
            this.button_print.Click += new System.EventHandler(this.button_print_Click);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // comboBox_file
            // 
            this.comboBox_file.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_file.FormattingEnabled = true;
            this.comboBox_file.Items.AddRange(new object[] {
            "Text",
            "Excel",
            "Word",
            "PDF"});
            this.comboBox_file.Location = new System.Drawing.Point(304, 370);
            this.comboBox_file.Name = "comboBox_file";
            this.comboBox_file.Size = new System.Drawing.Size(137, 24);
            this.comboBox_file.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(168, 372);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "Save as type:";
            // 
            // PrintCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 495);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_file);
            this.Controls.Add(this.button_print);
            this.Controls.Add(this.button_totext);
            this.Controls.Add(this.dataGridView1);
            this.Name = "PrintCourseForm";
            this.Text = "PrintCourseForm";
            this.Load += new System.EventHandler(this.PrintCourseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursetableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viduDataSet3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private viduDataSet3 viduDataSet3;
        private System.Windows.Forms.BindingSource coursetableBindingSource;
        private viduDataSet3TableAdapters.course_tableTableAdapter course_tableTableAdapter;
        private System.Windows.Forms.Button button_totext;
        private System.Windows.Forms.Button button_print;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn labelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn periodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionsDataGridViewTextBoxColumn;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ComboBox comboBox_file;
        private System.Windows.Forms.Label label1;
    }
}