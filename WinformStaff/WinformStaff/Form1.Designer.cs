namespace WinformStaff
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.Description = new System.Windows.Forms.RichTextBox();
            this.CreationDate = new System.Windows.Forms.DateTimePicker();
            this.AgentsGrid = new System.Windows.Forms.DataGridView();
            this.Add = new System.Windows.Forms.Button();
            this.Remove = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.Location = new System.Windows.Forms.TextBox();
            this.MainPage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AgentsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Creation date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Description\r\n";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(92, 35);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(100, 20);
            this.NameTextBox.TabIndex = 5;
            this.NameTextBox.TextChanged += new System.EventHandler(this.NameTextBox_TextChanged);
            // 
            // Email
            // 
            this.Email.Location = new System.Drawing.Point(92, 66);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(100, 20);
            this.Email.TabIndex = 6;
            this.Email.TextChanged += new System.EventHandler(this.Email_TextChanged);
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(92, 104);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(100, 20);
            this.Password.TabIndex = 7;
            this.Password.TextChanged += new System.EventHandler(this.Password_TextChanged);
            // 
            // Description
            // 
            this.Description.Location = new System.Drawing.Point(92, 223);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(221, 35);
            this.Description.TabIndex = 8;
            this.Description.Text = "";
            this.Description.TextChanged += new System.EventHandler(this.Description_TextChanged);
            // 
            // CreationDate
            // 
            this.CreationDate.Location = new System.Drawing.Point(92, 180);
            this.CreationDate.Name = "CreationDate";
            this.CreationDate.Size = new System.Drawing.Size(200, 20);
            this.CreationDate.TabIndex = 9;
            this.CreationDate.ValueChanged += new System.EventHandler(this.CreationDate_ValueChanged);
            // 
            // AgentsGrid
            // 
            this.AgentsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AgentsGrid.Location = new System.Drawing.Point(349, 12);
            this.AgentsGrid.Name = "AgentsGrid";
            this.AgentsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AgentsGrid.Size = new System.Drawing.Size(439, 300);
            this.AgentsGrid.TabIndex = 10;
            this.AgentsGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AgentsGrid_CellContentClick);
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(71, 283);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 23);
            this.Add.TabIndex = 11;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click_1);
            // 
            // Remove
            // 
            this.Remove.Location = new System.Drawing.Point(196, 283);
            this.Remove.Name = "Remove";
            this.Remove.Size = new System.Drawing.Size(75, 23);
            this.Remove.TabIndex = 12;
            this.Remove.Text = "Remove";
            this.Remove.UseVisualStyleBackColor = true;
            this.Remove.Click += new System.EventHandler(this.Remove_Click_1);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(196, 312);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(75, 23);
            this.Clear.TabIndex = 13;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click_1);
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(71, 312);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(75, 23);
            this.Update.TabIndex = 14;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Location";
            // 
            // Location
            // 
            this.Location.Location = new System.Drawing.Point(92, 143);
            this.Location.Name = "Location";
            this.Location.Size = new System.Drawing.Size(100, 20);
            this.Location.TabIndex = 16;
            this.Location.TextChanged += new System.EventHandler(this.Location_TextChanged);
            // 
            // MainPage
            // 
            this.MainPage.Location = new System.Drawing.Point(1, 0);
            this.MainPage.Name = "MainPage";
            this.MainPage.Size = new System.Drawing.Size(75, 23);
            this.MainPage.TabIndex = 17;
            this.MainPage.Text = "Homepage";
            this.MainPage.UseVisualStyleBackColor = true;
            this.MainPage.Click += new System.EventHandler(this.MainPage_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MainPage);
            this.Controls.Add(this.Location);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Remove);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.AgentsGrid);
            this.Controls.Add(this.CreationDate);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "AgentsManage";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AgentsGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.RichTextBox Description;
        private System.Windows.Forms.DateTimePicker CreationDate;
        private System.Windows.Forms.DataGridView AgentsGrid;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Remove;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Location;
        private System.Windows.Forms.Button MainPage;
    }
}