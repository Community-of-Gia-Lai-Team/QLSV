namespace WindowsFormsApp1
{
    partial class VerificationForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_code = new System.Windows.Forms.TextBox();
            this.button_confirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Your confirmation code is:";
            // 
            // textBox_code
            // 
            this.textBox_code.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_code.Location = new System.Drawing.Point(275, 50);
            this.textBox_code.Name = "textBox_code";
            this.textBox_code.Size = new System.Drawing.Size(176, 30);
            this.textBox_code.TabIndex = 1;
            // 
            // button_confirm
            // 
            this.button_confirm.BackColor = System.Drawing.Color.Red;
            this.button_confirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_confirm.Location = new System.Drawing.Point(482, 45);
            this.button_confirm.Name = "button_confirm";
            this.button_confirm.Size = new System.Drawing.Size(136, 40);
            this.button_confirm.TabIndex = 2;
            this.button_confirm.Text = "Confirm";
            this.button_confirm.UseVisualStyleBackColor = false;
            this.button_confirm.Click += new System.EventHandler(this.button_confirm_Click);
            // 
            // VerificationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 102);
            this.Controls.Add(this.button_confirm);
            this.Controls.Add(this.textBox_code);
            this.Controls.Add(this.label1);
            this.Name = "VerificationForm";
            this.Text = "VerificationForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_code;
        private System.Windows.Forms.Button button_confirm;
    }
}