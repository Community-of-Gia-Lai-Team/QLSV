namespace WindowsFormsApp1
{
    partial class RemoveCourseForm
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
            this.label_enter_id = new System.Windows.Forms.Label();
            this.textBox_enter_id = new System.Windows.Forms.TextBox();
            this.button_remove = new System.Windows.Forms.Button();
            this.errorProvider_id = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_id)).BeginInit();
            this.SuspendLayout();
            // 
            // label_enter_id
            // 
            this.label_enter_id.AutoSize = true;
            this.label_enter_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_enter_id.Location = new System.Drawing.Point(12, 68);
            this.label_enter_id.Name = "label_enter_id";
            this.label_enter_id.Size = new System.Drawing.Size(258, 29);
            this.label_enter_id.TabIndex = 0;
            this.label_enter_id.Text = "Enter The Course ID:";
            // 
            // textBox_enter_id
            // 
            this.textBox_enter_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_enter_id.Location = new System.Drawing.Point(289, 63);
            this.textBox_enter_id.Name = "textBox_enter_id";
            this.textBox_enter_id.Size = new System.Drawing.Size(227, 34);
            this.textBox_enter_id.TabIndex = 1;
            this.textBox_enter_id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_enter_id_KeyPress);
            // 
            // button_remove
            // 
            this.button_remove.BackColor = System.Drawing.Color.Cyan;
            this.button_remove.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_remove.Location = new System.Drawing.Point(561, 63);
            this.button_remove.Name = "button_remove";
            this.button_remove.Size = new System.Drawing.Size(172, 34);
            this.button_remove.TabIndex = 2;
            this.button_remove.Text = "REMOVE";
            this.button_remove.UseVisualStyleBackColor = false;
            this.button_remove.Click += new System.EventHandler(this.button_remove_Click);
            // 
            // errorProvider_id
            // 
            this.errorProvider_id.ContainerControl = this;
            // 
            // RemoveCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 173);
            this.Controls.Add(this.button_remove);
            this.Controls.Add(this.textBox_enter_id);
            this.Controls.Add(this.label_enter_id);
            this.Name = "RemoveCourseForm";
            this.Text = "RemoveCourseForm";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_id)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_enter_id;
        private System.Windows.Forms.TextBox textBox_enter_id;
        private System.Windows.Forms.Button button_remove;
        private System.Windows.Forms.ErrorProvider errorProvider_id;
    }
}