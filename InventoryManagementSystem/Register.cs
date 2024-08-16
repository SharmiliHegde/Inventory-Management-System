using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;
using System.Data.SqlClient;

namespace InventoryManagementSystem
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Form1 obj = new Form1();
            obj.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String a = usid.Text;
            String b = suname.Text;
            String c = spass.Text;
            String d = scpass.Text; 


            SqlConnection con = new SqlConnection("Data Source=Sharmili\\SQLEXPRESS;Initial Catalog=InventoryManagementdb;Integrated Security=True");
            con.Open();


            String sql = "INSERT INTO Login(Id,Username,Password) values ('" + a + "','" + b + "','" + c + "')";


            SqlDataAdapter sda = new SqlDataAdapter(sql, con);
            sda.SelectCommand.ExecuteNonQuery();

            MessageBox.Show("New data inserted successfully", "Data Insertion");

            usid.Text = "";
            suname.Text = "";
            spass.Text = "";
            scpass.Text = "";

        }

        private void sid_Click(object sender, EventArgs e)
        {

        }
    }
}
