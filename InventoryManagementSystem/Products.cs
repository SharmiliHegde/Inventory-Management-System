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
    public partial class Products : Form
    {
        public Products()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String a = pid.Text;
            String b = pname.Text;
            String c = price.Text;


            SqlConnection con = new SqlConnection("Data Source=Sharmili\\SQLEXPRESS;Initial Catalog=InventoryManagementdb;Integrated Security=True");
            con.Open();

            String query = "INSERT INTO ProductTab(ProductId,ProductName,Price) values ('" + a + "','" + b + "','" + c + "')";

            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            sda.SelectCommand.ExecuteNonQuery();

            MessageBox.Show("Product data inserted successfully", "Data Insertion");

            pid.Text = "";
            pname.Text = "";
            price.Text = "";

            ShowData();

        }
        public void ShowData()
        {
            SqlConnection con = new SqlConnection("Data Source=Sharmili\\SQLEXPRESS;Initial Catalog=InventoryManagementdb;Integrated Security=True");
            con.Open();


            SqlDataAdapter sda = new SqlDataAdapter("select * from ProductTab", con);

            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.Rows.Clear();

            foreach (DataRow dr in dt.Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells["pid1"].Value = dr["ProductId"].ToString();
                dataGridView1.Rows[n].Cells["pname1"].Value = dr["ProductName"].ToString();
                dataGridView1.Rows[n].Cells["price1"].Value = dr["Price"].ToString();
            }


        }
        private void button2_Click(object sender, EventArgs e)
        {

            String a = pid.Text;
            String b = pname.Text;
            String c = price.Text;


            SqlConnection con = new SqlConnection("Data Source=Sharmili\\SQLEXPRESS;Initial Catalog=InventoryManagementdb;Integrated Security=True");
            con.Open();

            string sql = "update ProductTab set Price=@pr,ProductId=@pid where ProductName=@pnm ";

            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@pr", c);
            cmd.Parameters.AddWithValue("@pid", a);
            cmd.Parameters.AddWithValue("@pnm", b);

            int count = cmd.ExecuteNonQuery();
            if (count != 0)
            {
                MessageBox.Show("Product data updated ", "Updation");
            }
            else
            {
                MessageBox.Show("Data is not updated", "Error");
            }
            pid.Text = "";
            pname.Text = "";
            price.Text = "";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string a = pname.Text;


            SqlConnection con = new SqlConnection("Data Source=Sharmili\\SQLEXPRESS;Initial Catalog=InventoryManagementdb;Integrated Security=True");
            con.Open();

            string sql = "delete from ProductTab where ProductName=@pna";

            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@pna", a);

            int status = cmd.ExecuteNonQuery();

            if (status > 0)
            {
                MessageBox.Show("Product data deleted ", "Deletion");
            }
            else
            {
                MessageBox.Show("No record found", "Error");
            }

            pname.Text = "";
            ShowData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Products_Load(object sender, EventArgs e)
        {
            ShowData();
        }

        
    }
}
