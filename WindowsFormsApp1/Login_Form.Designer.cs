namespace WindowsFormsApp1
{
    partial class Login_Form
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
            this.lb_username = new System.Windows.Forms.Label();
            this.lb_password = new System.Windows.Forms.Label();
            this.tB_password = new System.Windows.Forms.TextBox();
            this.tB_username = new System.Windows.Forms.TextBox();
            this.lb_accountlogin = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bt_cancel = new System.Windows.Forms.Button();
            this.bt_login = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button_register = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.error_user = new System.Windows.Forms.ErrorProvider(this.components);
            this.error_pass = new System.Windows.Forms.ErrorProvider(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button_Resetpassword = new System.Windows.Forms.Button();
            this.checkBox_hienthimk = new System.Windows.Forms.CheckBox();
            this.radioButton_student = new System.Windows.Forms.RadioButton();
            this.radioButton_human = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_user)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_pass)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_username
            // 
            this.lb_username.AutoSize = true;
            this.lb_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_username.Location = new System.Drawing.Point(47, 105);
            this.lb_username.Name = "lb_username";
            this.lb_username.Size = new System.Drawing.Size(130, 29);
            this.lb_username.TabIndex = 0;
            this.lb_username.Text = "Username:";
            // 
            // lb_password
            // 
            this.lb_password.AutoSize = true;
            this.lb_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_password.Location = new System.Drawing.Point(51, 178);
            this.lb_password.Name = "lb_password";
            this.lb_password.Size = new System.Drawing.Size(126, 29);
            this.lb_password.TabIndex = 1;
            this.lb_password.Text = "Password:";
            // 
            // tB_password
            // 
            this.error_pass.SetError(this.tB_password, "PLease enter your pass");
            this.tB_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tB_password.Location = new System.Drawing.Point(222, 175);
            this.tB_password.Name = "tB_password";
            this.tB_password.PasswordChar = '*';
            this.tB_password.Size = new System.Drawing.Size(270, 34);
            this.tB_password.TabIndex = 2;
            this.tB_password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tB_password_KeyDown);
            this.tB_password.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tB_password_KeyPress);
            // 
            // tB_username
            // 
            this.error_user.SetError(this.tB_username, "PLease enter your user");
            this.tB_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tB_username.Location = new System.Drawing.Point(222, 105);
            this.tB_username.Name = "tB_username";
            this.tB_username.Size = new System.Drawing.Size(270, 34);
            this.tB_username.TabIndex = 3;
            this.tB_username.Validating += new System.ComponentModel.CancelEventHandler(this.tB_username_Validating);
            // 
            // lb_accountlogin
            // 
            this.lb_accountlogin.AutoSize = true;
            this.lb_accountlogin.Font = new System.Drawing.Font("Comic Sans MS", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_accountlogin.Location = new System.Drawing.Point(163, 19);
            this.lb_accountlogin.Name = "lb_accountlogin";
            this.lb_accountlogin.Size = new System.Drawing.Size(265, 51);
            this.lb_accountlogin.TabIndex = 4;
            this.lb_accountlogin.Text = "Account Login";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources._1;
            this.pictureBox1.Location = new System.Drawing.Point(35, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // bt_cancel
            // 
            this.bt_cancel.BackColor = System.Drawing.Color.IndianRed;
            this.bt_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_cancel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bt_cancel.Location = new System.Drawing.Point(35, 261);
            this.bt_cancel.Name = "bt_cancel";
            this.bt_cancel.Size = new System.Drawing.Size(125, 51);
            this.bt_cancel.TabIndex = 6;
            this.bt_cancel.Text = "Cancel";
            this.bt_cancel.UseVisualStyleBackColor = false;
            this.bt_cancel.Click += new System.EventHandler(this.bt_cancel_Click);
            // 
            // bt_login
            // 
            this.bt_login.BackColor = System.Drawing.Color.DarkOrange;
            this.bt_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_login.Location = new System.Drawing.Point(201, 261);
            this.bt_login.Name = "bt_login";
            this.bt_login.Size = new System.Drawing.Size(125, 51);
            this.bt_login.TabIndex = 7;
            this.bt_login.Text = "Login";
            this.bt_login.UseVisualStyleBackColor = false;
            this.bt_login.Click += new System.EventHandler(this.bt_login_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(328, 429);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nguyễn Hữu Thắng - 20110568";
            // 
            // button_register
            // 
            this.button_register.BackColor = System.Drawing.Color.RosyBrown;
            this.button_register.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_register.Location = new System.Drawing.Point(381, 261);
            this.button_register.Name = "button_register";
            this.button_register.Size = new System.Drawing.Size(125, 51);
            this.button_register.TabIndex = 11;
            this.button_register.Text = "Register";
            this.button_register.UseVisualStyleBackColor = false;
            this.button_register.Click += new System.EventHandler(this.button_register_Click);
            // 
            // error_user
            // 
            this.error_user.ContainerControl = this;
            // 
            // error_pass
            // 
            this.error_pass.ContainerControl = this;
            // 
            // button_Resetpassword
            // 
            this.button_Resetpassword.BackColor = System.Drawing.Color.PeachPuff;
            this.button_Resetpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Resetpassword.Location = new System.Drawing.Point(145, 332);
            this.button_Resetpassword.Name = "button_Resetpassword";
            this.button_Resetpassword.Size = new System.Drawing.Size(233, 39);
            this.button_Resetpassword.TabIndex = 12;
            this.button_Resetpassword.Text = "Reset password";
            this.button_Resetpassword.UseVisualStyleBackColor = false;
            this.button_Resetpassword.Click += new System.EventHandler(this.button_Resetpassword_Click);
            // 
            // checkBox_hienthimk
            // 
            this.checkBox_hienthimk.AutoSize = true;
            this.checkBox_hienthimk.Location = new System.Drawing.Point(430, 224);
            this.checkBox_hienthimk.Name = "checkBox_hienthimk";
            this.checkBox_hienthimk.Size = new System.Drawing.Size(62, 20);
            this.checkBox_hienthimk.TabIndex = 13;
            this.checkBox_hienthimk.Text = "Show";
            this.checkBox_hienthimk.UseVisualStyleBackColor = true;
            this.checkBox_hienthimk.CheckedChanged += new System.EventHandler(this.checkBox_hienthimk_CheckedChanged);
            // 
            // radioButton_student
            // 
            this.radioButton_student.AutoSize = true;
            this.radioButton_student.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_student.Location = new System.Drawing.Point(12, 392);
            this.radioButton_student.Name = "radioButton_student";
            this.radioButton_student.Size = new System.Drawing.Size(87, 24);
            this.radioButton_student.TabIndex = 14;
            this.radioButton_student.TabStop = true;
            this.radioButton_student.Text = "Student";
            this.radioButton_student.UseVisualStyleBackColor = true;
            // 
            // radioButton_human
            // 
            this.radioButton_human.AutoSize = true;
            this.radioButton_human.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_human.Location = new System.Drawing.Point(181, 392);
            this.radioButton_human.Name = "radioButton_human";
            this.radioButton_human.Size = new System.Drawing.Size(161, 24);
            this.radioButton_human.TabIndex = 15;
            this.radioButton_human.TabStop = true;
            this.radioButton_human.Text = "Human Resource";
            this.radioButton_human.UseVisualStyleBackColor = true;
            // 
            // Login_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(546, 454);
            this.Controls.Add(this.radioButton_human);
            this.Controls.Add(this.radioButton_student);
            this.Controls.Add(this.checkBox_hienthimk);
            this.Controls.Add(this.button_Resetpassword);
            this.Controls.Add(this.button_register);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_login);
            this.Controls.Add(this.bt_cancel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lb_accountlogin);
            this.Controls.Add(this.tB_username);
            this.Controls.Add(this.tB_password);
            this.Controls.Add(this.lb_password);
            this.Controls.Add(this.lb_username);
            this.Name = "Login_Form";
            this.Text = "Login_Form";
            this.Load += new System.EventHandler(this.Login_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_user)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error_pass)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_username;
        private System.Windows.Forms.Label lb_password;
        private System.Windows.Forms.TextBox tB_password;
        private System.Windows.Forms.TextBox tB_username;
        private System.Windows.Forms.Label lb_accountlogin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bt_cancel;
        private System.Windows.Forms.Button bt_login;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_register;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ErrorProvider error_user;
        private System.Windows.Forms.ErrorProvider error_pass;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button_Resetpassword;
        private System.Windows.Forms.CheckBox checkBox_hienthimk;
        public System.Windows.Forms.RadioButton radioButton_human;
        public System.Windows.Forms.RadioButton radioButton_student;
    }
}

