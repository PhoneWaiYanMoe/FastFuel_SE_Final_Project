using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformStaff
{
    public partial class ChoosingOptions : Form
    {
        public ChoosingOptions()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form1 staff = new Form1();

            staff.Show();

            this.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Menu menu = new Menu();

            menu.Show();

            this.Hide();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Vouchers vouchers = new Vouchers();

            vouchers.Show();

            this.Hide();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Gifts gifts = new Gifts();

            gifts.Show();

            this.Hide();
        }
    }
}
