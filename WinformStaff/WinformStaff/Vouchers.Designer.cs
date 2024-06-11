namespace WinformStaff
{
    partial class Vouchers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Vouchers));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Code = new System.Windows.Forms.TextBox();
            this.Value = new System.Windows.Forms.TextBox();
            this.Voucher = new System.Windows.Forms.DataGridView();
            this.Submit = new System.Windows.Forms.Button();
            this.Remove = new System.Windows.Forms.Button();
            this.Homepage = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Description = new System.Windows.Forms.TextBox();
            this.MinimumVal = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Voucher)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(30, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(30, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Value";
            // 
            // Code
            // 
            this.Code.Location = new System.Drawing.Point(113, 82);
            this.Code.Name = "Code";
            this.Code.Size = new System.Drawing.Size(100, 20);
            this.Code.TabIndex = 2;
            this.Code.TextChanged += new System.EventHandler(this.Code_TextChanged);
            // 
            // Value
            // 
            this.Value.Location = new System.Drawing.Point(113, 119);
            this.Value.Name = "Value";
            this.Value.Size = new System.Drawing.Size(100, 20);
            this.Value.TabIndex = 3;
            this.Value.TextChanged += new System.EventHandler(this.Value_TextChanged);
            // 
            // Voucher
            // 
            this.Voucher.BackgroundColor = System.Drawing.Color.LightGoldenrodYellow;
            this.Voucher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Voucher.Location = new System.Drawing.Point(267, 12);
            this.Voucher.Name = "Voucher";
            this.Voucher.Size = new System.Drawing.Size(521, 288);
            this.Voucher.TabIndex = 4;
            this.Voucher.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Voucher_CellContentClick);
            // 
            // Submit
            // 
            this.Submit.BackColor = System.Drawing.Color.DarkRed;
            this.Submit.ForeColor = System.Drawing.Color.White;
            this.Submit.Location = new System.Drawing.Point(46, 263);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(75, 23);
            this.Submit.TabIndex = 5;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = false;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // Remove
            // 
            this.Remove.BackColor = System.Drawing.Color.DarkRed;
            this.Remove.ForeColor = System.Drawing.Color.White;
            this.Remove.Location = new System.Drawing.Point(148, 263);
            this.Remove.Name = "Remove";
            this.Remove.Size = new System.Drawing.Size(75, 23);
            this.Remove.TabIndex = 6;
            this.Remove.Text = "Remove";
            this.Remove.UseVisualStyleBackColor = false;
            this.Remove.Click += new System.EventHandler(this.Remove_Click);
            // 
            // Homepage
            // 
            this.Homepage.BackColor = System.Drawing.Color.DarkRed;
            this.Homepage.ForeColor = System.Drawing.Color.White;
            this.Homepage.Location = new System.Drawing.Point(-1, 1);
            this.Homepage.Name = "Homepage";
            this.Homepage.Size = new System.Drawing.Size(75, 23);
            this.Homepage.TabIndex = 7;
            this.Homepage.Text = "Homepage";
            this.Homepage.UseVisualStyleBackColor = false;
            this.Homepage.Click += new System.EventHandler(this.button3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.DarkRed;
            this.label3.Location = new System.Drawing.Point(30, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Description";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.DarkRed;
            this.label4.Location = new System.Drawing.Point(30, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Minimum Value";
            // 
            // Description
            // 
            this.Description.Location = new System.Drawing.Point(148, 161);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(100, 20);
            this.Description.TabIndex = 10;
            this.Description.TextChanged += new System.EventHandler(this.Description_TextChanged);
            // 
            // MinimumVal
            // 
            this.MinimumVal.Location = new System.Drawing.Point(148, 201);
            this.MinimumVal.Name = "MinimumVal";
            this.MinimumVal.Size = new System.Drawing.Size(100, 20);
            this.MinimumVal.TabIndex = 11;
            this.MinimumVal.TextChanged += new System.EventHandler(this.MinimumVal_TextChanged);
            // 
            // Vouchers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MinimumVal);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Homepage);
            this.Controls.Add(this.Remove);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.Voucher);
            this.Controls.Add(this.Value);
            this.Controls.Add(this.Code);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Vouchers";
            this.Text = "Voucher Management";
            this.Load += new System.EventHandler(this.Vouchers_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.Voucher)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Code;
        private System.Windows.Forms.TextBox Value;
        private System.Windows.Forms.DataGridView Voucher;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.Button Remove;
        private System.Windows.Forms.Button Homepage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Description;
        private System.Windows.Forms.TextBox MinimumVal;
    }
}
