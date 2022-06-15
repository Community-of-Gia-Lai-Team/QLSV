namespace WindowsFormsApp1
{
    partial class CodeHrform
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
            this.button_confirm = new System.Windows.Forms.Button();
            this.textBox_code = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_confirm
            // 
            this.button_confirm.BackColor = System.Drawing.Color.Red;
            this.button_confirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_confirm.Location = new System.Drawing.Point(506, 25);
            this.button_confirm.Name = "button_confirm";
            this.button_confirm.Size = new System.Drawing.Size(136, 40);
            this.button_confirm.TabIndex = 5;
            this.button_confirm.Text = "Confirm";
            this.button_confirm.UseVisualStyleBackColor = false;
            this.button_confirm.Click += new System.EventHandler(this.button_confirm_Click);
            // 
            // textBox_code
            // 
            this.textBox_code.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_code.Location = new System.Drawing.Point(299, 30);
            this.textBox_code.Name = "textBox_code";
            this.textBox_code.Size = new System.Drawing.Size(176, 30);
            this.textBox_code.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Your confirmation code is:";
            // 
            // CodeHrform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 81);
            this.Controls.Add(this.button_confirm);
            this.Controls.Add(this.textBox_code);
            this.Controls.Add(this.label1);
            this.Name = "CodeHrform";
            this.Text = "CodeHrform";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_confirm;
        private System.Windows.Forms.TextBox textBox_code;
        private System.Windows.Forms.Label label1;
    }
}