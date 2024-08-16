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
using static Azure.Core.HttpHeader;
using System.Diagnostics;
using System.Security.Cryptography;
namespace InventoryManagementSystem
{
    public partial class Customers : Form
    {
        public Customers()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string a = cid.Text;
            string b = cname.Text;
            string c = cadd.Text;
            string d = contact.Text;

            SqlConnection con = new SqlConnection("Data Source = Sharmili\\SQLEXPRESS; Initial Catalog = InventoryManagementdb; Integrated Security = True");
            con.Open();

            String query = "INSERT INTO CustomerTab(CustomerId,CustomerName,Address,ContactNo) values ('" + a + "','" + b + "','" + c + "','" + d + "')";

            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            sda.SelectCommand.ExecuteNonQuery();

            MessageBox.Show("Consumer data inserted", "Data Insertion");

            cid.Text = "";
            cname.Text = "";
            cadd.Text = "";
            contact.Text = "";

            ShowData();

        }
        public void ShowData()
        {

            SqlConnection con = new SqlConnection("Data Source = Sharmili\\SQLEXPRESS; Initial Catalog = InventoryManagementdb; Integrated Security = True");
            con.Open();



            SqlDataAdapter sda = new SqlDataAdapter("select * from CustomerTab", con);

            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.Rows.Clear();

            foreach (DataRow dr in dt.Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells["cid4"].Value = dr["CustomerId"].ToString();
                dataGridView1.Rows[n].Cells["cname4"].Value = dr["CustomerName"].ToString();
                dataGridView1.Rows[n].Cells["cadd4"].Value = dr["Address"].ToString();
                dataGridView1.Rows[n].Cells["contact4"].Value = dr["ContactNo"].ToString();
            }


        }
        private void button2_Click(object sender, EventArgs e)
        {
            string a = cid.Text;
            string b = cname.Text;
            string c = cadd.Text;
            string d = contact.Text;


            SqlConnection con = new SqlConnection("Data Source = Sharmili\\SQLEXPRESS; Initial Catalog = InventoryManagementdb; Integrated Security = True");
            con.Open();

            string sql = "update CustomerTab set ContactNo=@cnt,Address=@addr,CustomerId=@cid where CustomerName=@cnm ";

            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@cnt", d);
            cmd.Parameters.AddWithValue("@addr", c);
            cmd.Parameters.AddWithValue("@cid", a);
            cmd.Parameters.AddWithValue("@cnm", b);

            int count = cmd.ExecuteNonQuery();
            if (count != 0)
            {
                MessageBox.Show("Consumer data updated ", "Updation");
            }
            else
            {
                MessageBox.Show("Consumer data is not updated", "Error");
            }

            cid.Text = "";
            cname.Text = "";
            cadd.Text = "";
            contact.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string a = cname.Text;


            SqlConnection con = new SqlConnection("Data Source = Sharmili\\SQLEXPRESS; Initial Catalog = InventoryManagementdb; Integrated Security = True");
            con.Open();


            string sql = "delete from CustomerTab where CustomerName=@cna";

            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@cna", a);

            int status = cmd.ExecuteNonQuery();

            if (status > 0)
            {
                MessageBox.Show("Consumer data deleted ", "Deletion");
            }
            else
            {
                MessageBox.Show("No record found", "Error");
            }

            cname.Text = "";
            ShowData();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Customers_Load(object sender, EventArgs e)
        {
            ShowData(); 
        }
    }
}
