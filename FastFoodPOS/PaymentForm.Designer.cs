namespace FastFoodPOS
{
    partial class PaymentForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button buttonCashPayment;
        private System.Windows.Forms.Button buttonVNPay;
        private System.Windows.Forms.Button buttonPayPal;

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
            this.buttonCashPayment = new System.Windows.Forms.Button();
            this.buttonVNPay = new System.Windows.Forms.Button();
            this.buttonPayPal = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.buttonEWalletPayment = new System.Windows.Forms.Button();
            this.labelOption = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonCashPayment
            // 
            this.buttonCashPayment.Location = new System.Drawing.Point(258, 145);
            this.buttonCashPayment.Name = "buttonCashPayment";
            this.buttonCashPayment.Size = new System.Drawing.Size(260, 45);
            this.buttonCashPayment.TabIndex = 0;
            this.buttonCashPayment.Text = "Cash";
            this.buttonCashPayment.UseVisualStyleBackColor = true;
            this.buttonCashPayment.Click += new System.EventHandler(this.buttonCashPayment_Click);
            // 
            // buttonVNPay
            // 
            this.buttonVNPay.Location = new System.Drawing.Point(258, 247);
            this.buttonVNPay.Name = "buttonVNPay";
            this.buttonVNPay.Size = new System.Drawing.Size(260, 45);
            this.buttonVNPay.TabIndex = 2;
            this.buttonVNPay.Text = "VNPay";
            this.buttonVNPay.UseVisualStyleBackColor = true;
            this.buttonVNPay.Click += new System.EventHandler(this.buttonVNPay_Click);
            // 
            // buttonPayPal
            // 
            this.buttonPayPal.Location = new System.Drawing.Point(258, 298);
            this.buttonPayPal.Name = "buttonPayPal";
            this.buttonPayPal.Size = new System.Drawing.Size(260, 45);
            this.buttonPayPal.TabIndex = 3;
            this.buttonPayPal.Text = "PayPal";
            this.buttonPayPal.UseVisualStyleBackColor = true;
            this.buttonPayPal.Click += new System.EventHandler(this.buttonPayPal_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.labelTitle.Location = new System.Drawing.Point(290, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(194, 46);
            this.labelTitle.TabIndex = 4;
            this.labelTitle.Text = "Fast Fuel";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonEWalletPayment
            // 
            this.buttonEWalletPayment.Location = new System.Drawing.Point(258, 196);
            this.buttonEWalletPayment.Name = "buttonEWalletPayment";
            this.buttonEWalletPayment.Size = new System.Drawing.Size(260, 45);
            this.buttonEWalletPayment.TabIndex = 1;
            this.buttonEWalletPayment.Text = "E-Wallet";
            this.buttonEWalletPayment.UseVisualStyleBackColor = true;
            this.buttonEWalletPayment.Click += new System.EventHandler(this.buttonEWalletPayment_Click);
            // 
            // labelOption
            // 
            this.labelOption.AutoSize = true;
            this.labelOption.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOption.Location = new System.Drawing.Point(259, 86);
            this.labelOption.Name = "labelOption";
            this.labelOption.Size = new System.Drawing.Size(259, 32);
            this.labelOption.TabIndex = 5;
            this.labelOption.Text = "Choose an Option";
            this.labelOption.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PaymentForm
            // 
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelOption);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.buttonPayPal);
            this.Controls.Add(this.buttonVNPay);
            this.Controls.Add(this.buttonEWalletPayment);
            this.Controls.Add(this.buttonCashPayment);
            this.Name = "PaymentForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button buttonEWalletPayment;
        private System.Windows.Forms.Label labelOption;
    }
}
