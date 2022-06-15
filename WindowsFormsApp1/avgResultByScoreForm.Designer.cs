namespace WindowsFormsApp1
{
    partial class avgResultByScoreForm
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
            this.label_firstname = new System.Windows.Forms.Label();
            this.label_lastname = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label_studentresult = new System.Windows.Forms.Label();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.textBox_firstname = new System.Windows.Forms.TextBox();
            this.textBox_lastname = new System.Windows.Forms.TextBox();
            this.textBox_search = new System.Windows.Forms.TextBox();
            this.button_search = new System.Windows.Forms.Button();
            this.button_print = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.errorProvider_id = new System.Windows.Forms.ErrorProvider(this.components);
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.button_save = new System.Windows.Forms.Button();
            this.comboBox_file = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_id)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_studentid
            // 
            this.label_studentid.AutoSize = true;
            this.label_studentid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_studentid.Location = new System.Drawing.Point(23, 87);
            this.label_studentid.Name = "label_studentid";
            this.label_studentid.Size = new System.Drawing.Size(121, 25);
            this.label_studentid.TabIndex = 0;
            this.label_studentid.Text = "Student ID:";
            // 
            // label_firstname
            // 
            this.label_firstname.AutoSize = true;
            this.label_firstname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_firstname.Location = new System.Drawing.Point(22, 146);
            this.label_firstname.Name = "label_firstname";
            this.label_firstname.Size = new System.Drawing.Size(123, 25);
            this.label_firstname.TabIndex = 1;
            this.label_firstname.Text = "First Name:";
            // 
            // label_lastname
            // 
            this.label_lastname.AutoSize = true;
            this.label_lastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_lastname.Location = new System.Drawing.Point(22, 202);
            this.label_lastname.Name = "label_lastname";
            this.label_lastname.Size = new System.Drawing.Size(122, 25);
            this.label_lastname.TabIndex = 2;
            this.label_lastname.Text = "Last Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Search By ID:";
            // 
            // label_studentresult
            // 
            this.label_studentresult.AutoSize = true;
            this.label_studentresult.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_studentresult.Location = new System.Drawing.Point(573, 9);
            this.label_studentresult.Name = "label_studentresult";
            this.label_studentresult.Size = new System.Drawing.Size(183, 29);
            this.label_studentresult.TabIndex = 4;
            this.label_studentresult.Text = "Student Result";
            // 
            // textBox_id
            // 
            this.textBox_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_id.Location = new System.Drawing.Point(181, 82);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.ReadOnly = true;
            this.textBox_id.Size = new System.Drawing.Size(179, 30);
            this.textBox_id.TabIndex = 5;
            // 
            // textBox_firstname
            // 
            this.textBox_firstname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_firstname.Location = new System.Drawing.Point(181, 141);
            this.textBox_firstname.Name = "textBox_firstname";
            this.textBox_firstname.ReadOnly = true;
            this.textBox_firstname.Size = new System.Drawing.Size(179, 30);
            this.textBox_firstname.TabIndex = 6;
            // 
            // textBox_lastname
            // 
            this.textBox_lastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_lastname.Location = new System.Drawing.Point(181, 199);
            this.textBox_lastname.Name = "textBox_lastname";
            this.textBox_lastname.ReadOnly = true;
            this.textBox_lastname.Size = new System.Drawing.Size(179, 30);
            this.textBox_lastname.TabIndex = 7;
            // 
            // textBox_search
            // 
            this.textBox_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_search.Location = new System.Drawing.Point(170, 319);
            this.textBox_search.Name = "textBox_search";
            this.textBox_search.Size = new System.Drawing.Size(190, 30);
            this.textBox_search.TabIndex = 8;
            this.textBox_search.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_search_KeyPress);
            // 
            // button_search
            // 
            this.button_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_search.Location = new System.Drawing.Point(28, 319);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(98, 30);
            this.button_search.TabIndex = 9;
            this.button_search.Text = "Search";
            this.button_search.UseVisualStyleBackColor = true;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // button_print
            // 
            this.button_print.BackColor = System.Drawing.Color.Coral;
            this.button_print.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_print.Location = new System.Drawing.Point(626, 412);
            this.button_print.Name = "button_print";
            this.button_print.Size = new System.Drawing.Size(100, 41);
            this.button_print.TabIndex = 11;
            this.button_print.Text = "Print";
            this.button_print.UseVisualStyleBackColor = false;
            this.button_print.Click += new System.EventHandler(this.button_print_Click);
            // 
            // button_cancel
            // 
            this.button_cancel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_cancel.Location = new System.Drawing.Point(998, 412);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(92, 41);
            this.button_cancel.TabIndex = 12;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = false;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // errorProvider_id
            // 
            this.errorProvider_id.ContainerControl = this;
            // 
            // button_save
            // 
            this.button_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_save.Location = new System.Drawing.Point(284, 412);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(92, 41);
            this.button_save.TabIndex = 13;
            this.button_save.Text = "Save";
            this.button_save.UseVisualStyleBackColor = false;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // comboBox_file
            // 
            this.comboBox_file.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_file.FormattingEnabled = true;
            this.comboBox_file.Items.AddRange(new object[] {
            "Excel",
            "Word"});
            this.comboBox_file.Location = new System.Drawing.Point(284, 376);
            this.comboBox_file.Name = "comboBox_file";
            this.comboBox_file.Size = new System.Drawing.Size(92, 24);
            this.comboBox_file.TabIndex = 14;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(436, 82);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(959, 267);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click_1);
            // 
            // avgResultByScoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1432, 501);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox_file);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_print);
            this.Controls.Add(this.button_search);
            this.Controls.Add(this.textBox_search);
            this.Controls.Add(this.textBox_lastname);
            this.Controls.Add(this.textBox_firstname);
            this.Controls.Add(this.textBox_id);
            this.Controls.Add(this.label_studentresult);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label_lastname);
            this.Controls.Add(this.label_firstname);
            this.Controls.Add(this.label_studentid);
            this.Name = "avgResultByScoreForm";
            this.Text = "avgResultByScoreForm";
            this.Load += new System.EventHandler(this.avgResultByScoreForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_id)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_studentid;
        private System.Windows.Forms.Label label_firstname;
        private System.Windows.Forms.Label label_lastname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_studentresult;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.TextBox textBox_firstname;
        private System.Windows.Forms.TextBox textBox_lastname;
        private System.Windows.Forms.TextBox textBox_search;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.Button button_print;
        private System.Windows.Forms.Button button_cancel;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.ErrorProvider errorProvider_id;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.ComboBox comboBox_file;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}