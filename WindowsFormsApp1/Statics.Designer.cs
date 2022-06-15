namespace WindowsFormsApp1
{
    partial class Statics
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
            this.panel_total = new System.Windows.Forms.Panel();
            this.label_total = new System.Windows.Forms.Label();
            this.panel_male = new System.Windows.Forms.Panel();
            this.label_male = new System.Windows.Forms.Label();
            this.panel_female = new System.Windows.Forms.Panel();
            this.label_female = new System.Windows.Forms.Label();
            this.panel_total.SuspendLayout();
            this.panel_male.SuspendLayout();
            this.panel_female.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_total
            // 
            this.panel_total.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel_total.Controls.Add(this.label_total);
            this.panel_total.Location = new System.Drawing.Point(0, -1);
            this.panel_total.Name = "panel_total";
            this.panel_total.Size = new System.Drawing.Size(801, 234);
            this.panel_total.TabIndex = 0;
            // 
            // label_total
            // 
            this.label_total.BackColor = System.Drawing.Color.Blue;
            this.label_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_total.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_total.Location = new System.Drawing.Point(0, 0);
            this.label_total.Name = "label_total";
            this.label_total.Size = new System.Drawing.Size(801, 234);
            this.label_total.TabIndex = 0;
            this.label_total.Text = "Total Student: 100%";
            this.label_total.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_total.MouseEnter += new System.EventHandler(this.label_total_MouseEnter);
            this.label_total.MouseLeave += new System.EventHandler(this.label_total_MouseLeave);
            // 
            // panel_male
            // 
            this.panel_male.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel_male.Controls.Add(this.label_male);
            this.panel_male.Location = new System.Drawing.Point(0, 235);
            this.panel_male.Name = "panel_male";
            this.panel_male.Size = new System.Drawing.Size(410, 223);
            this.panel_male.TabIndex = 0;
            // 
            // label_male
            // 
            this.label_male.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label_male.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_male.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_male.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label_male.Location = new System.Drawing.Point(0, -2);
            this.label_male.Name = "label_male";
            this.label_male.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label_male.Size = new System.Drawing.Size(410, 217);
            this.label_male.TabIndex = 0;
            this.label_male.Text = "Male:";
            this.label_male.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_male.MouseEnter += new System.EventHandler(this.label_male_MouseEnter);
            this.label_male.MouseLeave += new System.EventHandler(this.label_male_MouseLeave);
            // 
            // panel_female
            // 
            this.panel_female.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel_female.Controls.Add(this.label_female);
            this.panel_female.Location = new System.Drawing.Point(410, 235);
            this.panel_female.Name = "panel_female";
            this.panel_female.Size = new System.Drawing.Size(391, 215);
            this.panel_female.TabIndex = 1;
            // 
            // label_female
            // 
            this.label_female.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label_female.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_female.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_female.Location = new System.Drawing.Point(0, 1);
            this.label_female.Name = "label_female";
            this.label_female.Size = new System.Drawing.Size(391, 214);
            this.label_female.TabIndex = 0;
            this.label_female.Text = "Female:";
            this.label_female.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_female.MouseEnter += new System.EventHandler(this.label_female_MouseEnter);
            this.label_female.MouseLeave += new System.EventHandler(this.label_female_MouseLeave);
            // 
            // Statics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel_female);
            this.Controls.Add(this.panel_male);
            this.Controls.Add(this.panel_total);
            this.Name = "Statics";
            this.Text = "Statics";
            this.Load += new System.EventHandler(this.Statics_Load);
            this.panel_total.ResumeLayout(false);
            this.panel_male.ResumeLayout(false);
            this.panel_female.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_total;
        private System.Windows.Forms.Panel panel_male;
        private System.Windows.Forms.Panel panel_female;
        private System.Windows.Forms.Label label_total;
        private System.Windows.Forms.Label label_male;
        private System.Windows.Forms.Label label_female;
    }
}