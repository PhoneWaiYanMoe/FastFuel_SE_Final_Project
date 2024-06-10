namespace FastFoodPOS
{
    partial class OrderConfirmationForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridViewOrderDetails;
        private System.Windows.Forms.Label labelTotalPrice;
        private System.Windows.Forms.Button buttonConfirm;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn FoodNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SizeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceColumn;

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
            this.dataGridViewOrderDetails = new System.Windows.Forms.DataGridView();
            this.FoodNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SizeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelTotalPrice = new System.Windows.Forms.Label();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrderDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewOrderDetails
            // 
            this.dataGridViewOrderDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrderDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FoodNameColumn,
            this.SizeColumn,
            this.PriceColumn});
            this.dataGridViewOrderDetails.Location = new System.Drawing.Point(127, 12);
            this.dataGridViewOrderDetails.Name = "dataGridViewOrderDetails";
            this.dataGridViewOrderDetails.RowHeadersWidth = 62;
            this.dataGridViewOrderDetails.Size = new System.Drawing.Size(514, 340);
            this.dataGridViewOrderDetails.TabIndex = 0;
            // 
            // FoodNameColumn
            // 
            this.FoodNameColumn.HeaderText = "Food Item";
            this.FoodNameColumn.MinimumWidth = 8;
            this.FoodNameColumn.Name = "FoodNameColumn";
            this.FoodNameColumn.Width = 150;
            // 
            // SizeColumn
            // 
            this.SizeColumn.HeaderText = "Size";
            this.SizeColumn.MinimumWidth = 8;
            this.SizeColumn.Name = "SizeColumn";
            this.SizeColumn.Width = 150;
            // 
            // PriceColumn
            // 
            this.PriceColumn.HeaderText = "Price";
            this.PriceColumn.MinimumWidth = 8;
            this.PriceColumn.Name = "PriceColumn";
            this.PriceColumn.Width = 150;
            // 
            // labelTotalPrice
            // 
            this.labelTotalPrice.AutoSize = true;
            this.labelTotalPrice.Location = new System.Drawing.Point(323, 370);
            this.labelTotalPrice.Name = "labelTotalPrice";
            this.labelTotalPrice.Size = new System.Drawing.Size(87, 20);
            this.labelTotalPrice.TabIndex = 1;
            this.labelTotalPrice.Text = "Total Price:";
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.Location = new System.Drawing.Point(713, 415);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(75, 30);
            this.buttonConfirm.TabIndex = 2;
            this.buttonConfirm.Text = "Confirm";
            this.buttonConfirm.UseVisualStyleBackColor = true;
            this.buttonConfirm.Click += new System.EventHandler(this.buttonConfirm_Click_1);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(21, 415);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 30);
            this.buttonCancel.TabIndex = 3;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click_1);
            // 
            // OrderConfirmationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonConfirm);
            this.Controls.Add(this.labelTotalPrice);
            this.Controls.Add(this.dataGridViewOrderDetails);
            this.Name = "OrderConfirmationForm";
            this.Text = "Order Confirmation";
            this.Load += new System.EventHandler(this.OrderConfirmationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrderDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
