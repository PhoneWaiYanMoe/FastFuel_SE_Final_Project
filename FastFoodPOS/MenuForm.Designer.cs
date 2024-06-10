namespace FastFoodPOS
{
    partial class MenuForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView foodDataGridView;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.ListBox categoryListBox;
        private System.Windows.Forms.Label categoryLabel;

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
            this.foodDataGridView = new System.Windows.Forms.DataGridView();
            this.submitButton = new System.Windows.Forms.Button();
            this.categoryListBox = new System.Windows.Forms.ListBox();
            this.categoryLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.foodDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // foodDataGridView
            // 
            this.foodDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.foodDataGridView.Location = new System.Drawing.Point(204, 31);
            this.foodDataGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.foodDataGridView.Name = "foodDataGridView";
            this.foodDataGridView.RowHeadersWidth = 62;
            this.foodDataGridView.Size = new System.Drawing.Size(954, 494);
            this.foodDataGridView.TabIndex = 0;
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(522, 535);
            this.submitButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(253, 62);
            this.submitButton.TabIndex = 1;
            this.submitButton.Text = "Confirm";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // categoryListBox
            // 
            this.categoryListBox.FormattingEnabled = true;
            this.categoryListBox.ItemHeight = 20;
            this.categoryListBox.Location = new System.Drawing.Point(18, 77);
            this.categoryListBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.categoryListBox.Name = "categoryListBox";
            this.categoryListBox.Size = new System.Drawing.Size(167, 444);
            this.categoryListBox.TabIndex = 2;
            this.categoryListBox.SelectedIndexChanged += new System.EventHandler(this.CategoryListBox_SelectedIndexChanged);
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryLabel.Location = new System.Drawing.Point(18, 31);
            this.categoryLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(167, 25);
            this.categoryLabel.TabIndex = 3;
            this.categoryLabel.Text = "Select Category";
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 771);
            this.Controls.Add(this.categoryLabel);
            this.Controls.Add(this.categoryListBox);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.foodDataGridView);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MenuForm";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.MenuForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.foodDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
