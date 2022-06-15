namespace WindowsFormsApp1
{
    partial class PrintResultScore
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_search = new System.Windows.Forms.TextBox();
            this.button_search = new System.Windows.Forms.Button();
            this.button_print = new System.Windows.Forms.Button();
            this.button_save = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_file = new System.Windows.Forms.ComboBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.errorProvider_id = new System.Windows.Forms.ErrorProvider(this.components);
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_id)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 80);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(911, 338);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search By ID:";
            // 
            // textBox_search
            // 
            this.textBox_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_search.Location = new System.Drawing.Point(202, 30);
            this.textBox_search.Name = "textBox_search";
            this.textBox_search.Size = new System.Drawing.Size(115, 34);
            this.textBox_search.TabIndex = 2;
            this.textBox_search.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_search_KeyPress);
            // 
            // button_search
            // 
            this.button_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_search.Location = new System.Drawing.Point(368, 32);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(117, 34);
            this.button_search.TabIndex = 3;
            this.button_search.Text = "Search";
            this.button_search.UseVisualStyleBackColor = true;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // button_print
            // 
            this.button_print.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_print.Location = new System.Drawing.Point(560, 490);
            this.button_print.Name = "button_print";
            this.button_print.Size = new System.Drawing.Size(111, 48);
            this.button_print.TabIndex = 4;
            this.button_print.Text = "Print";
            this.button_print.UseVisualStyleBackColor = true;
            this.button_print.Click += new System.EventHandler(this.button_print_Click);
            // 
            // button_save
            // 
            this.button_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_save.Location = new System.Drawing.Point(160, 490);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(111, 48);
            this.button_save.TabIndex = 5;
            this.button_save.Text = "Save";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 442);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Save as type:";
            // 
            // comboBox_file
            // 
            this.comboBox_file.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_file.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_file.FormattingEnabled = true;
            this.comboBox_file.Items.AddRange(new object[] {
            "Excel",
            "Word",
            "Text",
            "PDF"});
            this.comboBox_file.Location = new System.Drawing.Point(150, 442);
            this.comboBox_file.Name = "comboBox_file";
            this.comboBox_file.Size = new System.Drawing.Size(121, 24);
            this.comboBox_file.TabIndex = 7;
            // 
            // errorProvider_id
            // 
            this.errorProvider_id.ContainerControl = this;
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // PrintResultScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 561);
            this.Controls.Add(this.comboBox_file);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.button_print);
            this.Controls.Add(this.button_search);
            this.Controls.Add(this.textBox_search);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "PrintResultScore";
            this.Text = "PrintResultScore";
            this.Load += new System.EventHandler(this.PrintResultScore_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_id)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_search;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.Button button_print;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_file;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ErrorProvider errorProvider_id;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}