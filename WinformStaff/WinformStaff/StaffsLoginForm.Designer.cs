namespace WinformStaff
{
    partial class StaffsLoginForm
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
        /// Required method for Designer support - do not modify the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.Submit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.loginPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.loginPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(20, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(20, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password";
            // 
            // Email
            // 
            this.Email.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(0)))));
            this.Email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.Email.Location = new System.Drawing.Point(100, 27);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(200, 20);
            this.Email.TabIndex = 3;
            this.Email.TextChanged += new System.EventHandler(this.Email_TextChanged);
            // 
            // Password
            // 
            this.Password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(0)))));
            this.Password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.Password.Location = new System.Drawing.Point(100, 77);
            this.Password.Name = "Password";
            this.Password.PasswordChar = '•';
            this.Password.Size = new System.Drawing.Size(200, 20);
            this.Password.TabIndex = 4;
            this.Password.TextChanged += new System.EventHandler(this.Password_TextChanged);
            // 
            // Submit
            // 
            this.Submit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(0)))), ((int)(((byte)(57)))));
            this.Submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Submit.ForeColor = System.Drawing.Color.White;
            this.Submit.Location = new System.Drawing.Point(125, 120);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(75, 30);
            this.Submit.TabIndex = 5;
            this.Submit.Text = "Login";
            this.Submit.UseVisualStyleBackColor = false;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(548, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Welcome to Fast Fuels Staff Portal";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // loginPanel
            // 
            this.loginPanel.BackColor = System.Drawing.Color.White;
            this.loginPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.loginPanel.Controls.Add(this.label1);
            this.loginPanel.Controls.Add(this.label2);
            this.loginPanel.Controls.Add(this.Email);
            this.loginPanel.Controls.Add(this.Password);
            this.loginPanel.Controls.Add(this.Submit);
            this.loginPanel.Location = new System.Drawing.Point(438, 147);
            this.loginPanel.Name = "loginPanel";
            this.loginPanel.Size = new System.Drawing.Size(350, 180);
            this.loginPanel.TabIndex = 8;
            this.loginPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.loginPanel_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WinformStaff.Properties.Resources.FastFuelLogo;
            this.pictureBox1.Location = new System.Drawing.Point(-3, -4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(402, 458);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // StaffsLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.loginPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "StaffsLoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Staff Login";
            this.Load += new System.EventHandler(this.StaffsLoginForm_Load);
            this.loginPanel.ResumeLayout(false);
            this.loginPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel loginPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
