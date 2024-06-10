using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FastFoodPOS
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void StartForm_Load(object sender, EventArgs e)
        {

        }

        private void startFrom_Click(object sender, EventArgs e)
        {
            DineOptionForm dineOptionForm = new DineOptionForm();
            dineOptionForm.Show();
            this.Hide();
        }

      
    }
}
