using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace FastFoodPOS
{
    public partial class MenuForm : Form
    {
        private Database database;
        private Dictionary<string, List<FoodItem>> selectedItemsByCategory; // Dictionary to keep track of selected items by category

        public MenuForm()
        {
            InitializeComponent();
            database = new Database();
            selectedItemsByCategory = new Dictionary<string, List<FoodItem>>(); // Initialize the dictionary
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {
            LoadCategories();
        }

        private void LoadCategories()
        {
            // Add categories to the ListBox
            categoryListBox.Items.AddRange(new string[] { "Main Course", "Side", "Beverage", "Dessert", "Combo" });
        }

        private void CategoryListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Save the selected items for the current category before changing categories
            if (categoryListBox.SelectedItem != null)
            {
                string currentCategory = categoryListBox.SelectedItem.ToString();
                if (!selectedItemsByCategory.ContainsKey(currentCategory))
                {
                    selectedItemsByCategory[currentCategory] = new List<FoodItem>();
                }
                selectedItemsByCategory[currentCategory] = GetSelectedItems();
            }

            // Load food items based on the selected category
            string selectedCategory = categoryListBox.SelectedItem.ToString();
            LoadFoodItems(selectedCategory);
        }

        private void LoadFoodItems(string category)
        {
            List<FoodItem> foodItems = database.GetFoodItems();
            var filteredItems = foodItems.Where(f => f.Category == category).ToList();
            foodDataGridView.DataSource = filteredItems;

            // Add a checkbox column to allow selecting items
            if (foodDataGridView.Columns["Selected"] == null)
            {
                DataGridViewCheckBoxColumn selectColumn = new DataGridViewCheckBoxColumn
                {
                    Name = "Selected",
                    HeaderText = "Select"
                };
                foodDataGridView.Columns.Insert(0, selectColumn);
            }

            // Add size column if category is 'Side' or 'Beverage'
            if (category == "Side" || category == "Beverage")
            {
                if (foodDataGridView.Columns["Size"] == null)
                {
                    DataGridViewComboBoxColumn sizeColumn = new DataGridViewComboBoxColumn
                    {
                        Name = "Size",
                        HeaderText = "Size",
                        DataSource = new string[] { "S", "M", "L" }
                    };
                    foodDataGridView.Columns.Add(sizeColumn);
                }
            }
            else
            {
                if (foodDataGridView.Columns["Size"] != null)
                {
                    foodDataGridView.Columns.Remove("Size");
                }
            }

            // Restore the selected state of items for the current category
            if (selectedItemsByCategory.ContainsKey(category))
            {
                foreach (var item in selectedItemsByCategory[category])
                {
                    foreach (DataGridViewRow row in foodDataGridView.Rows)
                    {
                        FoodItem dataItem = row.DataBoundItem as FoodItem;
                        if (dataItem.FoodId == item.FoodId)
                        {
                            row.Cells["Selected"].Value = true;
                            if (item.Category == "Side" || item.Category == "Beverage")
                            {
                                row.Cells["Size"].Value = item.Size;
                            }
                        }
                    }
                }
            }
        }

        private List<FoodItem> GetSelectedItems()
        {
            List<FoodItem> selectedItems = new List<FoodItem>(); // Use a local list instead of class-level list
            foreach (DataGridViewRow row in foodDataGridView.Rows)
            {
                if (Convert.ToBoolean(row.Cells["Selected"].Value))
                {
                    FoodItem item = row.DataBoundItem as FoodItem;
                    if (item.Category == "Side" || item.Category == "Beverage")
                    {
                        item.Size = row.Cells["Size"].Value.ToString();
                    }
                    selectedItems.Add(item);
                }
            }
            return selectedItems;
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            // Ensure the current category's selected items are saved before submitting
            if (categoryListBox.SelectedItem != null)
            {
                string currentCategory = categoryListBox.SelectedItem.ToString();
                selectedItemsByCategory[currentCategory] = GetSelectedItems();
            }

            // Combine all selected items from all categories
            List<FoodItem> allSelectedItems = selectedItemsByCategory.Values.SelectMany(items => items).ToList();
            OrderConfirmationForm orderConfirmationForm = new OrderConfirmationForm(allSelectedItems);
            orderConfirmationForm.Show();
            this.Hide();
        }
    }
}
