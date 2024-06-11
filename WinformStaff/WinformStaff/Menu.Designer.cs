namespace WinformStaff
{
    partial class Menu
    {
        // Required designer variable.
        private System.ComponentModel.IContainer components = null;

        // Clean up any resources being used.
        // Dispose method to release managed resources.
        // Disposing parameter to check if the resources should be disposed.
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        // Method for Designer support - do not modify
        // the contents of this method with the code editor.
        private void InitializeComponent()
        {
            // Initialize components
            this.MainPage = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Add = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.Description = new System.Windows.Forms.RichTextBox();
            this.Remove = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.FoodGrid = new System.Windows.Forms.DataGridView();
            this.Size = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Price = new System.Windows.Forms.TextBox();
            this.Category = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.FoodGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // MainPage
            // Button to navigate to the homepage
            this.MainPage.Location = new System.Drawing.Point(1, 2);
            this.MainPage.Name = "MainPage";
            this.MainPage.Size = new System.Drawing.Size(75, 23);
            this.MainPage.TabIndex = 18;
            this.MainPage.Text = "Homepage";
            this.MainPage.UseVisualStyleBackColor = true;
            this.MainPage.Click += new System.EventHandler(this.MainPage_Click);
            // 
            // label1
            // Label for the food item name
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Name";
            // 
            // label5
            // Label for the food item description
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Description";
            // 
            // Add
            // Button to add a new food item
            this.Add.Location = new System.Drawing.Point(48, 262);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 23);
            this.Add.TabIndex = 21;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // label6
            // Label for the food item price
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Price";
            // 
            // NameTextBox
            // TextBox for entering the food item name
            this.NameTextBox.Location = new System.Drawing.Point(96, 50);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(100, 20);
            this.NameTextBox.TabIndex = 24;
            this.NameTextBox.TextChanged += new System.EventHandler(this.NameTextBox_TextChanged);
            // 
            // Description
            // RichTextBox for entering the food item description
            this.Description.Location = new System.Drawing.Point(96, 210);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(221, 35);
            this.Description.TabIndex = 25;
            this.Description.Text = "";
            this.Description.TextChanged += new System.EventHandler(this.DescriptionTextBox_TextChanged);
            // 
            // Remove
            // Button to remove a selected food item
            this.Remove.Location = new System.Drawing.Point(211, 262);
            this.Remove.Name = "Remove";
            this.Remove.Size = new System.Drawing.Size(75, 23);
            this.Remove.TabIndex = 28;
            this.Remove.Text = "Remove";
            this.Remove.UseVisualStyleBackColor = true;
            this.Remove.Click += new System.EventHandler(this.Remove_Click);
            // 
            // Update
            // Button to update the details of a food item
            this.Update.Location = new System.Drawing.Point(48, 291);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(75, 23);
            this.Update.TabIndex = 29;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // Clear
            // Button to clear the input fields
            this.Clear.Location = new System.Drawing.Point(211, 291);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(75, 23);
            this.Clear.TabIndex = 30;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // FoodGrid
            // DataGridView to display the list of food items
            this.FoodGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FoodGrid.Location = new System.Drawing.Point(349, 12);
            this.FoodGrid.Name = "FoodGrid";
            this.FoodGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.FoodGrid.Size = new System.Drawing.Size(439, 300);
            this.FoodGrid.TabIndex = 31;
            this.FoodGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.FoodGrid_CellContentClick);
            // 
            // Size
            // ComboBox for selecting the size of the food item
            this.Size.AutoCompleteCustomSource.AddRange(new string[] {
            "Default",
            "S",
            "M",
            "L"});
            this.Size.FormattingEnabled = true;
            this.Size.Location = new System.Drawing.Point(96, 169);
            this.Size.Name = "Size";
            this.Size.Size = new System.Drawing.Size(121, 21);
            this.Size.TabIndex = 33;
            this.Size.SelectedIndexChanged += new System.EventHandler(this.SizeComboBox_SelectedIndexChanged);
            // 
            // label2
            // Label for the size of the food item
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "Size";

            // TextBox for entering the price of the food item
            this.Price.Location = new System.Drawing.Point(96, 90);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(100, 20);
            this.Price.TabIndex = 35;

            // TextBox for entering the category of the food item
            this.Category.Location = new System.Drawing.Point(96, 131);
            this.Category.Name = "Category";
            this.Category.Size = new System.Drawing.Size(100, 20);
            this.Category.TabIndex = 36;
            this.Category.TextChanged += new System.EventHandler(this.CategoryTextBox_TextChanged);

            // Label for the category of the food item
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 37;
            this.label3.Text = "Category";

            // Menu form settings
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Category);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Size);
            this.Controls.Add(this.FoodGrid);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.Remove);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MainPage);
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FoodGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button MainPage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.RichTextBox Description;
        private System.Windows.Forms.Button Remove;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.DataGridView FoodGrid;
        private System.Windows.Forms.ComboBox Size;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Price;
        private System.Windows.Forms.TextBox Category;
        private System.Windows.Forms.Label label3;
    }
}