using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.Hide();
            Products obj = new Products();
            obj.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //this.Hide();
            Customers obj = new Customers();
            obj.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //this.Hide();
            Orders obj = new Orders();
            obj.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //this.Hide();
            Inventory obj = new Inventory();
            obj.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //this.Hide();
            Print obj = new Print();
            obj.Show();
        }

        private void userToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            //this.Hide();
            User obj = new User();
            obj.Show();
        }

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Hide();
            Inventory obj = new Inventory();
            obj.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
