namespace WindowsFormsApp1
{
    partial class RegisterForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label_username = new System.Windows.Forms.Label();
            this.label_password = new System.Windows.Forms.Label();
            this.textBox_pass = new System.Windows.Forms.TextBox();
            this.textBox_user = new System.Windows.Forms.TextBox();
            this.button_OK = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.error_user = new System.Windows.Forms.ErrorProvider(this.components);
            this.checkBox_showpass = new System.Windows.Forms.CheckBox();
            this.label_email = new System.Windows.Forms.Label();
            this.label_pass_email = new System.Windows.Forms.Label();
            this.textBox_pass_email = new System.Windows.Forms.TextBox();
            this.textBox_email = new System.Windows.Forms.TextBox();
            this.checkBox_Showpassemail = new System.Windows.Forms.CheckBox();
            this.error_email = new System.Windows.Forms.ErrorProvider(this.components);
            this.error_pass = new System.Windows.Forms.ErrorProvider(this.components);
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.error_passemail = new System.Windows.Forms.ErrorProvider(this.components);
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.error_user)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_email)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_pass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_passemail)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(188, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "Register";
            // 
            // label_username
            // 
            this.label_username.AutoSize = true;
            this.label_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_username.Location = new System.Drawing.Point(51, 94);
            this.label_username.Name = "label_username";
            this.label_username.Size = new System.Drawing.Size(130, 29);
            this.label_username.TabIndex = 1;
            this.label_username.Text = "Username:";
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_password.Location = new System.Drawing.Point(55, 154);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(126, 29);
            this.label_password.TabIndex = 2;
            this.label_password.Text = "Password:";
            // 
            // textBox_pass
            // 
            this.textBox_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_pass.Location = new System.Drawing.Point(264, 154);
            this.textBox_pass.Name = "textBox_pass";
            this.textBox_pass.PasswordChar = '*';
            this.textBox_pass.Size = new System.Drawing.Size(226, 34);
            this.textBox_pass.TabIndex = 3;
            this.textBox_pass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_pass_KeyPress);
            // 
            // textBox_user
            // 
            this.textBox_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_user.Location = new System.Drawing.Point(264, 89);
            this.textBox_user.Name = "textBox_user";
            this.textBox_user.Size = new System.Drawing.Size(226, 34);
            this.textBox_user.TabIndex = 4;
            this.textBox_user.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_user_Validating);
            // 
            // button_OK
            // 
            this.button_OK.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.button_OK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_OK.Location = new System.Drawing.Point(56, 375);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(434, 44);
            this.button_OK.TabIndex = 5;
            this.button_OK.Text = "Register";
            this.button_OK.UseVisualStyleBackColor = false;
            this.button_OK.Click += new System.EventHandler(this.button_OK_Click);
            // 
            // error_user
            // 
            this.error_user.ContainerControl = this;
            // 
            // checkBox_showpass
            // 
            this.checkBox_showpass.AutoSize = true;
            this.checkBox_showpass.Location = new System.Drawing.Point(428, 194);
            this.checkBox_showpass.Name = "checkBox_showpass";
            this.checkBox_showpass.Size = new System.Drawing.Size(62, 20);
            this.checkBox_showpass.TabIndex = 7;
            this.checkBox_showpass.Text = "Show";
            this.checkBox_showpass.UseVisualStyleBackColor = true;
            this.checkBox_showpass.CheckedChanged += new System.EventHandler(this.checkBox_showpass_CheckedChanged);
            // 
            // label_email
            // 
            this.label_email.AutoSize = true;
            this.label_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_email.Location = new System.Drawing.Point(55, 235);
            this.label_email.Name = "label_email";
            this.label_email.Size = new System.Drawing.Size(80, 29);
            this.label_email.TabIndex = 8;
            this.label_email.Text = "Email:";
            // 
            // label_pass_email
            // 
            this.label_pass_email.AutoSize = true;
            this.label_pass_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_pass_email.Location = new System.Drawing.Point(51, 300);
            this.label_pass_email.Name = "label_pass_email";
            this.label_pass_email.Size = new System.Drawing.Size(193, 29);
            this.label_pass_email.TabIndex = 9;
            this.label_pass_email.Text = "Email Password:";
            // 
            // textBox_pass_email
            // 
            this.textBox_pass_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_pass_email.Location = new System.Drawing.Point(264, 295);
            this.textBox_pass_email.Name = "textBox_pass_email";
            this.textBox_pass_email.PasswordChar = '*';
            this.textBox_pass_email.Size = new System.Drawing.Size(226, 34);
            this.textBox_pass_email.TabIndex = 10;
            this.textBox_pass_email.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_pass_email_KeyPress);
            // 
            // textBox_email
            // 
            this.textBox_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_email.Location = new System.Drawing.Point(264, 230);
            this.textBox_email.Name = "textBox_email";
            this.textBox_email.Size = new System.Drawing.Size(226, 34);
            this.textBox_email.TabIndex = 11;
            this.textBox_email.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_email_Validating);
            // 
            // checkBox_Showpassemail
            // 
            this.checkBox_Showpassemail.AutoSize = true;
            this.checkBox_Showpassemail.Location = new System.Drawing.Point(428, 335);
            this.checkBox_Showpassemail.Name = "checkBox_Showpassemail";
            this.checkBox_Showpassemail.Size = new System.Drawing.Size(62, 20);
            this.checkBox_Showpassemail.TabIndex = 12;
            this.checkBox_Showpassemail.Text = "Show";
            this.checkBox_Showpassemail.UseVisualStyleBackColor = true;
            this.checkBox_Showpassemail.CheckedChanged += new System.EventHandler(this.checkBox_Showpassemail_CheckedChanged);
            // 
            // error_email
            // 
            this.error_email.ContainerControl = this;
            // 
            // error_pass
            // 
            this.error_pass.ContainerControl = this;
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "";
            // 
            // error_passemail
            // 
            this.error_passemail.ContainerControl = this;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 442);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(189, 18);
            this.label8.TabIndex = 19;
            this.label8.Text = "<< Have an account? Login";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(514, 469);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.checkBox_Showpassemail);
            this.Controls.Add(this.textBox_email);
            this.Controls.Add(this.textBox_pass_email);
            this.Controls.Add(this.label_pass_email);
            this.Controls.Add(this.label_email);
            this.Controls.Add(this.checkBox_showpass);
            this.Controls.Add(this.button_OK);
            this.Controls.Add(this.textBox_user);
            this.Controls.Add(this.textBox_pass);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.label_username);
            this.Controls.Add(this.label1);
            this.Name = "RegisterForm";
            this.Text = "RegisterForm";
            ((System.ComponentModel.ISupportInitialize)(this.error_user)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_email)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_pass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_passemail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_username;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.TextBox textBox_pass;
        private System.Windows.Forms.TextBox textBox_user;
        private System.Windows.Forms.Button button_OK;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ErrorProvider error_user;
        private System.Windows.Forms.CheckBox checkBox_showpass;
        private System.Windows.Forms.CheckBox checkBox_Showpassemail;
        private System.Windows.Forms.TextBox textBox_email;
        private System.Windows.Forms.TextBox textBox_pass_email;
        private System.Windows.Forms.Label label_pass_email;
        private System.Windows.Forms.Label label_email;
        private System.Windows.Forms.ErrorProvider error_email;
        private System.Windows.Forms.ErrorProvider error_pass;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.ErrorProvider error_passemail;
        private System.Windows.Forms.Label label8;
    }
}