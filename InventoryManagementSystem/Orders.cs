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
using System.Security.Cryptography;
namespace InventoryManagementSystem
{
    public partial class Orders : Form
    {
        public Orders()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String a = oid5.Text;
            String b = cid5.Text;
            String c = qnt5.Text;
            String d = price5.Text;


            SqlConnection con = new SqlConnection("Data Source=Sharmili\\SQLEXPRESS;Initial Catalog=InventoryManagementdb;Integrated Security=True");
            con.Open();

            String query = "INSERT INTO OrderTab(OrderId,CustomerId,Quantity,Price) values ('" + a + "','" + b + "','" + c + "','" + d + "')";

            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            sda.SelectCommand.ExecuteNonQuery();

            MessageBox.Show("Order data inserted successfully", "Data Insertion");

            oid5.Text = "";
            cid5.Text = "";
            qnt5.Text = "";
            price5.Text = "";

            ShowData();
        }
        public void ShowData()
        {
            SqlConnection con = new SqlConnection("Data Source=Sharmili\\SQLEXPRESS;Initial Catalog=InventoryManagementdb;Integrated Security=True");
            con.Open();


            SqlDataAdapter sda = new SqlDataAdapter("select * from OrderTab", con);

            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.Rows.Clear();

            foreach (DataRow dr in dt.Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells["oid"].Value = dr["OrderId"].ToString();
                dataGridView1.Rows[n].Cells["cid"].Value = dr["CustomerId"].ToString();
                dataGridView1.Rows[n].Cells["qnt"].Value = dr["Quantity"].ToString();
                dataGridView1.Rows[n].Cells["price"].Value = dr["Price"].ToString();
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            String a = oid5.Text;
            String b = cid5.Text;
            String c = qnt5.Text;
            String d = price5.Text;


            SqlConnection con = new SqlConnection("Data Source=Sharmili\\SQLEXPRESS;Initial Catalog=InventoryManagementdb;Integrated Security=True");
            con.Open();

            string sql = "update OrderTab set Price=@pr,Quantity=@qn,OrderId=@oid where CustomerId=@cid ";

            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@pr", d);
            cmd.Parameters.AddWithValue("@qn", c);
            cmd.Parameters.AddWithValue("@oid", a);
            cmd.Parameters.AddWithValue("@cid", b);

            int count = cmd.ExecuteNonQuery();
            if (count != 0)
            {
                MessageBox.Show("Order data updated ", "Updation");
            }
            else
            {
                MessageBox.Show("Data is not updated", "Error");
            }

            oid5.Text = "";
            cid5.Text = "";
            qnt5.Text = "";
            price5.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string a = cid5.Text;


            SqlConnection con = new SqlConnection("Data Source=Sharmili\\SQLEXPRESS;Initial Catalog=InventoryManagementdb;Integrated Security=True");
            con.Open();

            string sql = "delete from OrderTab where CustomerId=@cid";

            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@cid", a);

            int status = cmd.ExecuteNonQuery();

            if (status > 0)
            {
                MessageBox.Show("Order data deleted ", "Deletion");
            }
            else
            {
                MessageBox.Show("No record found", "Error");
            }

            cid5.Text = "";
            ShowData();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Orders_Load_1(object sender, EventArgs e)
        {
            ShowData();
        }
    }

}
