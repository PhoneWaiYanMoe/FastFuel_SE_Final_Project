using System;
using System.Windows.Forms;

namespace FastFoodPOS
{
    public partial class DineOptionForm : Form
    {
        public DineOptionForm()
        {
            InitializeComponent();
        }

        private void DineInButton_Click(object sender, EventArgs e)
        {
            MenuForm menuForm = new MenuForm();
            menuForm.Show();
            this.Hide();
        }

        private void TakeAwayButton_Click(object sender, EventArgs e)
        {
            MenuForm menuForm = new MenuForm();
            menuForm.Show();
            this.Hide();
        }

        private void DineOptionForm_Load(object sender, EventArgs e)
        {
            // Additional logic for form load if needed
        }
    }
}
