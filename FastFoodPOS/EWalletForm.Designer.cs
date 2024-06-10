namespace FastFoodPOS
{
    partial class EWalletForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button buttonBankingQR;
        private System.Windows.Forms.Button buttonCreditCard;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.buttonBankingQR = new System.Windows.Forms.Button();
            this.buttonCreditCard = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelOption = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonBankingQR
            // 
            this.buttonBankingQR.BackColor = System.Drawing.Color.DarkRed;
            this.buttonBankingQR.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonBankingQR.Location = new System.Drawing.Point(108, 206);
            this.buttonBankingQR.Name = "buttonBankingQR";
            this.buttonBankingQR.Size = new System.Drawing.Size(171, 74);
            this.buttonBankingQR.TabIndex = 0;
            this.buttonBankingQR.Text = "Banking QR";
            this.buttonBankingQR.UseVisualStyleBackColor = false;
            this.buttonBankingQR.Click += new System.EventHandler(this.buttonBankingQR_Click);
            // 
            // buttonCreditCard
            // 
            this.buttonCreditCard.BackColor = System.Drawing.Color.DarkGreen;
            this.buttonCreditCard.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonCreditCard.Location = new System.Drawing.Point(497, 206);
            this.buttonCreditCard.Name = "buttonCreditCard";
            this.buttonCreditCard.Size = new System.Drawing.Size(180, 74);
            this.buttonCreditCard.TabIndex = 1;
            this.buttonCreditCard.Text = "Credit Card";
            this.buttonCreditCard.UseVisualStyleBackColor = false;
            this.buttonCreditCard.Click += new System.EventHandler(this.buttonCreditCard_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.labelTitle.Location = new System.Drawing.Point(312, 56);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(194, 46);
            this.labelTitle.TabIndex = 2;
            this.labelTitle.Text = "Fast Fuel";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelOption
            // 
            this.labelOption.AutoSize = true;
            this.labelOption.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOption.Location = new System.Drawing.Point(278, 123);
            this.labelOption.Name = "labelOption";
            this.labelOption.Size = new System.Drawing.Size(259, 32);
            this.labelOption.TabIndex = 3;
            this.labelOption.Text = "Choose an Option";
            this.labelOption.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EWalletForm
            // 
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelOption);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.buttonCreditCard);
            this.Controls.Add(this.buttonBankingQR);
            this.Name = "EWalletForm";
            this.Text = "E-Wallet Payment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelOption;
    }
}
