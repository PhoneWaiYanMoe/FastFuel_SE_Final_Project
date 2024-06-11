namespace WinformStaff
{
    partial class Gifts
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
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.PriceTextBox = new System.Windows.Forms.TextBox();
            this.GiftGrid = new System.Windows.Forms.DataGridView();
            this.DescriptionTextBox = new System.Windows.Forms.RichTextBox();
            this.Submit = new System.Windows.Forms.Button();
            this.Remove = new System.Windows.Forms.Button();
            this.Homepage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GiftGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Description";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(89, 114);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(100, 20);
            this.NameTextBox.TabIndex = 3;
            this.NameTextBox.TextChanged += new System.EventHandler(this.Name_TextChanged);
            // 
            // PriceTextBox
            // 
            this.PriceTextBox.Location = new System.Drawing.Point(89, 157);
            this.PriceTextBox.Name = "PriceTextBox";
            this.PriceTextBox.Size = new System.Drawing.Size(100, 20);
            this.PriceTextBox.TabIndex = 4;
            this.PriceTextBox.TextChanged += new System.EventHandler(this.Price_TextChanged);
            // 
            // GiftGrid
            // 
            this.GiftGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GiftGrid.Location = new System.Drawing.Point(288, 12);
            this.GiftGrid.Name = "GiftGrid";
            this.GiftGrid.Size = new System.Drawing.Size(500, 297);
            this.GiftGrid.TabIndex = 6;
            this.GiftGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Gift_CellContentClick);
            // 
            // DescriptionTextBox
            // 
            this.DescriptionTextBox.Location = new System.Drawing.Point(89, 203);
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.Size = new System.Drawing.Size(162, 81);
            this.DescriptionTextBox.TabIndex = 7;
            this.DescriptionTextBox.Text = "";
            this.DescriptionTextBox.TextChanged += new System.EventHandler(this.Description_TextChanged);
            // 
            // Submit
            // 
            this.Submit.Location = new System.Drawing.Point(75, 305);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(75, 23);
            this.Submit.TabIndex = 8;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // Remove
            // 
            this.Remove.Location = new System.Drawing.Point(176, 305);
            this.Remove.Name = "Remove";
            this.Remove.Size = new System.Drawing.Size(75, 23);
            this.Remove.TabIndex = 9;
            this.Remove.Text = "Remove";
            this.Remove.UseVisualStyleBackColor = true;
            this.Remove.Click += new System.EventHandler(this.Remove_Click);
            // 
            // Homepage
            // 
            this.Homepage.Location = new System.Drawing.Point(-3, 1);
            this.Homepage.Name = "Homepage";
            this.Homepage.Size = new System.Drawing.Size(75, 23);
            this.Homepage.TabIndex = 10;
            this.Homepage.Text = "Homepage";
            this.Homepage.UseVisualStyleBackColor = true;
            this.Homepage.Click += new System.EventHandler(this.Homepage_Click);
            // 
            // Gifts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Homepage);
            this.Controls.Add(this.Remove);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.DescriptionTextBox);
            this.Controls.Add(this.GiftGrid);
            this.Controls.Add(this.PriceTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Gifts";
            this.Text = "Gifts";
            this.Load += new System.EventHandler(this.Gifts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GiftGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox PriceTextBox;
        private System.Windows.Forms.DataGridView GiftGrid;
        private System.Windows.Forms.RichTextBox DescriptionTextBox;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.Button Remove;
        private System.Windows.Forms.Button Homepage;
    }
}
