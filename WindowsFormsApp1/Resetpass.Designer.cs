namespace WindowsFormsApp1
{
    partial class Resetpass
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
            this.label_resetpass = new System.Windows.Forms.Label();
            this.label_newpass = new System.Windows.Forms.Label();
            this.label_email = new System.Windows.Forms.Label();
            this.label_username = new System.Windows.Forms.Label();
            this.button_cancel = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox_newpass = new System.Windows.Forms.TextBox();
            this.textBox_email = new System.Windows.Forms.TextBox();
            this.textBox_user = new System.Windows.Forms.TextBox();
            this.checkBox_show = new System.Windows.Forms.CheckBox();
            this.error_passnew = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.error_passnew)).BeginInit();
            this.SuspendLayout();
            // 
            // label_resetpass
            // 
            this.label_resetpass.AutoSize = true;
            this.label_resetpass.Font = new System.Drawing.Font("Comic Sans MS", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_resetpass.Location = new System.Drawing.Point(184, 19);
            this.label_resetpass.Name = "label_resetpass";
            this.label_resetpass.Size = new System.Drawing.Size(300, 51);
            this.label_resetpass.TabIndex = 0;
            this.label_resetpass.Text = "Reset Password";
            // 
            // label_newpass
            // 
            this.label_newpass.AutoSize = true;
            this.label_newpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_newpass.Location = new System.Drawing.Point(78, 225);
            this.label_newpass.Name = "label_newpass";
            this.label_newpass.Size = new System.Drawing.Size(186, 29);
            this.label_newpass.TabIndex = 1;
            this.label_newpass.Text = "New PassWord:";
            // 
            // label_email
            // 
            this.label_email.AutoSize = true;
            this.label_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_email.Location = new System.Drawing.Point(78, 164);
            this.label_email.Name = "label_email";
            this.label_email.Size = new System.Drawing.Size(80, 29);
            this.label_email.TabIndex = 2;
            this.label_email.Text = "Email:";
            // 
            // label_username
            // 
            this.label_username.AutoSize = true;
            this.label_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_username.Location = new System.Drawing.Point(78, 101);
            this.label_username.Name = "label_username";
            this.label_username.Size = new System.Drawing.Size(130, 29);
            this.label_username.TabIndex = 3;
            this.label_username.Text = "Username:";
            // 
            // button_cancel
            // 
            this.button_cancel.BackColor = System.Drawing.Color.Yellow;
            this.button_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_cancel.Location = new System.Drawing.Point(136, 302);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(119, 47);
            this.button_cancel.TabIndex = 4;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = false;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.IndianRed;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(422, 302);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 47);
            this.button2.TabIndex = 5;
            this.button2.Text = "Confirm";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox_newpass
            // 
            this.textBox_newpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_newpass.Location = new System.Drawing.Point(294, 225);
            this.textBox_newpass.Name = "textBox_newpass";
            this.textBox_newpass.PasswordChar = '*';
            this.textBox_newpass.Size = new System.Drawing.Size(313, 28);
            this.textBox_newpass.TabIndex = 6;
            this.textBox_newpass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_newpass_KeyPress);
            // 
            // textBox_email
            // 
            this.textBox_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_email.Location = new System.Drawing.Point(294, 164);
            this.textBox_email.Name = "textBox_email";
            this.textBox_email.Size = new System.Drawing.Size(313, 28);
            this.textBox_email.TabIndex = 7;
            // 
            // textBox_user
            // 
            this.textBox_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_user.Location = new System.Drawing.Point(294, 101);
            this.textBox_user.Name = "textBox_user";
            this.textBox_user.Size = new System.Drawing.Size(313, 28);
            this.textBox_user.TabIndex = 8;
            // 
            // checkBox_show
            // 
            this.checkBox_show.AutoSize = true;
            this.checkBox_show.Location = new System.Drawing.Point(545, 270);
            this.checkBox_show.Name = "checkBox_show";
            this.checkBox_show.Size = new System.Drawing.Size(62, 20);
            this.checkBox_show.TabIndex = 9;
            this.checkBox_show.Text = "Show";
            this.checkBox_show.UseVisualStyleBackColor = true;
            this.checkBox_show.CheckedChanged += new System.EventHandler(this.checkBox_show_CheckedChanged);
            // 
            // error_passnew
            // 
            this.error_passnew.ContainerControl = this;
            // 
            // Resetpass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(665, 383);
            this.Controls.Add(this.checkBox_show);
            this.Controls.Add(this.textBox_user);
            this.Controls.Add(this.textBox_email);
            this.Controls.Add(this.textBox_newpass);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.label_username);
            this.Controls.Add(this.label_email);
            this.Controls.Add(this.label_newpass);
            this.Controls.Add(this.label_resetpass);
            this.Name = "Resetpass";
            this.Text = "Resetpass";
            ((System.ComponentModel.ISupportInitialize)(this.error_passnew)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_resetpass;
        private System.Windows.Forms.Label label_newpass;
        private System.Windows.Forms.Label label_email;
        private System.Windows.Forms.Label label_username;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox_newpass;
        private System.Windows.Forms.TextBox textBox_email;
        private System.Windows.Forms.TextBox textBox_user;
        private System.Windows.Forms.CheckBox checkBox_show;
        private System.Windows.Forms.ErrorProvider error_passnew;
    }
}