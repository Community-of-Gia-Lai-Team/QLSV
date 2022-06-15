namespace WindowsFormsApp1
{
    partial class AddScoreForm
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
            this.label_studentid = new System.Windows.Forms.Label();
            this.label_selectcourse = new System.Windows.Forms.Label();
            this.label_score = new System.Windows.Forms.Label();
            this.label_des = new System.Windows.Forms.Label();
            this.comboBox_course = new System.Windows.Forms.ComboBox();
            this.textBox_score = new System.Windows.Forms.TextBox();
            this.textBox_des = new System.Windows.Forms.TextBox();
            this.textBox_studentid = new System.Windows.Forms.TextBox();
            this.button_add = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stdBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.viduDataSet4 = new WindowsFormsApp1.viduDataSet4();
            this.stdTableAdapter = new WindowsFormsApp1.viduDataSet4TableAdapters.stdTableAdapter();
            this.button_cancel = new System.Windows.Forms.Button();
            this.errorProvider_score = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider_id = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stdBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viduDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_score)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_id)).BeginInit();
            this.SuspendLayout();
            // 
            // label_studentid
            // 
            this.label_studentid.AutoSize = true;
            this.label_studentid.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_studentid.Location = new System.Drawing.Point(79, 57);
            this.label_studentid.Name = "label_studentid";
            this.label_studentid.Size = new System.Drawing.Size(141, 29);
            this.label_studentid.TabIndex = 0;
            this.label_studentid.Text = "Student ID:";
            // 
            // label_selectcourse
            // 
            this.label_selectcourse.AutoSize = true;
            this.label_selectcourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_selectcourse.Location = new System.Drawing.Point(35, 119);
            this.label_selectcourse.Name = "label_selectcourse";
            this.label_selectcourse.Size = new System.Drawing.Size(185, 29);
            this.label_selectcourse.TabIndex = 1;
            this.label_selectcourse.Text = "Select Course:";
            // 
            // label_score
            // 
            this.label_score.AutoSize = true;
            this.label_score.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_score.Location = new System.Drawing.Point(131, 178);
            this.label_score.Name = "label_score";
            this.label_score.Size = new System.Drawing.Size(89, 29);
            this.label_score.TabIndex = 2;
            this.label_score.Text = "Score:";
            // 
            // label_des
            // 
            this.label_des.AutoSize = true;
            this.label_des.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_des.Location = new System.Drawing.Point(67, 234);
            this.label_des.Name = "label_des";
            this.label_des.Size = new System.Drawing.Size(153, 29);
            this.label_des.TabIndex = 3;
            this.label_des.Text = "Description:";
            // 
            // comboBox_course
            // 
            this.comboBox_course.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_course.FormattingEnabled = true;
            this.comboBox_course.Location = new System.Drawing.Point(243, 111);
            this.comboBox_course.Name = "comboBox_course";
            this.comboBox_course.Size = new System.Drawing.Size(251, 37);
            this.comboBox_course.TabIndex = 4;
            // 
            // textBox_score
            // 
            this.textBox_score.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_score.Location = new System.Drawing.Point(243, 173);
            this.textBox_score.Name = "textBox_score";
            this.textBox_score.Size = new System.Drawing.Size(122, 34);
            this.textBox_score.TabIndex = 5;
            this.textBox_score.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_score_KeyPress);
            // 
            // textBox_des
            // 
            this.textBox_des.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_des.Location = new System.Drawing.Point(243, 241);
            this.textBox_des.Multiline = true;
            this.textBox_des.Name = "textBox_des";
            this.textBox_des.Size = new System.Drawing.Size(251, 136);
            this.textBox_des.TabIndex = 6;
            // 
            // textBox_studentid
            // 
            this.textBox_studentid.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_studentid.Location = new System.Drawing.Point(243, 52);
            this.textBox_studentid.Name = "textBox_studentid";
            this.textBox_studentid.Size = new System.Drawing.Size(122, 34);
            this.textBox_studentid.TabIndex = 7;
            this.textBox_studentid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_studentid_KeyPress);
            // 
            // button_add
            // 
            this.button_add.BackColor = System.Drawing.Color.Lime;
            this.button_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_add.Location = new System.Drawing.Point(212, 404);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(113, 51);
            this.button_add.TabIndex = 8;
            this.button_add.Text = "Add";
            this.button_add.UseVisualStyleBackColor = false;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.fnameDataGridViewTextBoxColumn,
            this.lnameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.stdBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(592, 52);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(672, 325);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
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
            // stdBindingSource
            // 
            this.stdBindingSource.DataMember = "std";
            this.stdBindingSource.DataSource = this.viduDataSet4;
            // 
            // viduDataSet4
            // 
            this.viduDataSet4.DataSetName = "viduDataSet4";
            this.viduDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stdTableAdapter
            // 
            this.stdTableAdapter.ClearBeforeFill = true;
            // 
            // button_cancel
            // 
            this.button_cancel.BackColor = System.Drawing.Color.Orange;
            this.button_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_cancel.Location = new System.Drawing.Point(824, 404);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(117, 51);
            this.button_cancel.TabIndex = 10;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = false;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // errorProvider_score
            // 
            this.errorProvider_score.ContainerControl = this;
            // 
            // errorProvider_id
            // 
            this.errorProvider_id.ContainerControl = this;
            // 
            // AddScoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1312, 493);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.textBox_studentid);
            this.Controls.Add(this.textBox_des);
            this.Controls.Add(this.textBox_score);
            this.Controls.Add(this.comboBox_course);
            this.Controls.Add(this.label_des);
            this.Controls.Add(this.label_score);
            this.Controls.Add(this.label_selectcourse);
            this.Controls.Add(this.label_studentid);
            this.Name = "AddScoreForm";
            this.Text = "AddScoreForm";
            this.Load += new System.EventHandler(this.AddScoreForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stdBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viduDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_score)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_id)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_studentid;
        private System.Windows.Forms.Label label_selectcourse;
        private System.Windows.Forms.Label label_score;
        private System.Windows.Forms.Label label_des;
        private System.Windows.Forms.ComboBox comboBox_course;
        private System.Windows.Forms.TextBox textBox_score;
        private System.Windows.Forms.TextBox textBox_des;
        private System.Windows.Forms.TextBox textBox_studentid;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.DataGridView dataGridView1;
        private viduDataSet4 viduDataSet4;
        private System.Windows.Forms.BindingSource stdBindingSource;
        private viduDataSet4TableAdapters.stdTableAdapter stdTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.ErrorProvider errorProvider_score;
        private System.Windows.Forms.ErrorProvider errorProvider_id;
    }
}