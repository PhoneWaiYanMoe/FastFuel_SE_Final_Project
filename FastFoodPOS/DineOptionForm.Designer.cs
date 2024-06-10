namespace FastFoodPOS
{
    partial class DineOptionForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.labelTitle = new System.Windows.Forms.Label();
            this.DineInButton = new System.Windows.Forms.Button();
            this.DineOutButton = new System.Windows.Forms.Button();
            this.labelOption = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.labelTitle.Location = new System.Drawing.Point(315, 31);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(194, 46);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Fast Fuel";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DineInButton
            // 
            this.DineInButton.BackColor = System.Drawing.Color.DarkGreen;
            this.DineInButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DineInButton.ForeColor = System.Drawing.Color.White;
            this.DineInButton.Location = new System.Drawing.Point(50, 175);
            this.DineInButton.Name = "DineInButton";
            this.DineInButton.Size = new System.Drawing.Size(350, 100);
            this.DineInButton.TabIndex = 2;
            this.DineInButton.Text = "Dine In";
            this.DineInButton.UseVisualStyleBackColor = false;
            this.DineInButton.Click += new System.EventHandler(this.DineInButton_Click);
            // 
            // DineOutButton
            // 
            this.DineOutButton.BackColor = System.Drawing.Color.DarkRed;
            this.DineOutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DineOutButton.ForeColor = System.Drawing.Color.White;
            this.DineOutButton.Location = new System.Drawing.Point(425, 175);
            this.DineOutButton.Name = "DineOutButton";
            this.DineOutButton.Size = new System.Drawing.Size(350, 100);
            this.DineOutButton.TabIndex = 3;
            this.DineOutButton.Text = "Take Away";
            this.DineOutButton.UseVisualStyleBackColor = false;
            this.DineOutButton.Click += new System.EventHandler(this.TakeAwayButton_Click);
            // 
            // labelOption
            // 
            this.labelOption.AutoSize = true;
            this.labelOption.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOption.Location = new System.Drawing.Point(281, 123);
            this.labelOption.Name = "labelOption";
            this.labelOption.Size = new System.Drawing.Size(259, 32);
            this.labelOption.TabIndex = 1;
            this.labelOption.Text = "Choose an Option";
            this.labelOption.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DineOptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelOption);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.DineOutButton);
            this.Controls.Add(this.DineInButton);
            this.Name = "DineOptionForm";
            this.Text = "Dine Option";
            this.Load += new System.EventHandler(this.DineOptionForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button DineInButton;
        private System.Windows.Forms.Button DineOutButton;
        private System.Windows.Forms.Label labelOption;
    }
}
