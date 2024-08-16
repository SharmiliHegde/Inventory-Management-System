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
    public partial class Print : Form
    {
        public Print()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
         
            txtOutput.Text += "Inventory  Details : ";
            txtOutput.Text += "\n\n";

            txtOutput.Text += "Product Id : " + pid7.Text + "\n\n";
            txtOutput.Text += "Product Name : " + pname7.Text + "\n\n";
            txtOutput.Text += "Consumer Name : " + pcname7.Text + "\n\n";
            txtOutput.Text += "Quantity : " + pqnty7.Text + "\n\n";
            txtOutput.Text += "Price : " + price7.Text + "\n\n";
            txtOutput.Text += "Date : " + DateTime.Now + "\n\n";
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(txtOutput.Text, new Font("Times New Roman", 18, FontStyle.Bold), Brushes.Black, new Point(10, 10));


        }

        private void button2_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();  
        }
    }
}
