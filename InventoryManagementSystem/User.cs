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
    public partial class User : Form
    {
        public User()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String a = uid8.Text;
            String b = uname8.Text;
            String c = uadd8.Text;
            String d = uphone8.Text;
            String f = upos8.Text;

            SqlConnection con = new SqlConnection("Data Source=Sharmili\\SQLEXPRESS;Initial Catalog=InventoryManagementdb;Integrated Security=True");
            con.Open();

            String query = "INSERT INTO UserTab(UserId,UserName,Address,ContactNo,Position) values ('" + a + "','" + b + "','" + c + "','" + d + "', '" + f + "')";

            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            sda.SelectCommand.ExecuteNonQuery();

            MessageBox.Show("User data inserted successfully", "Data Insertion");

            uid8.Text = "";
            uname8.Text = "";
            uadd8.Text = "";
            uphone8.Text = "";
            upos8.Text = "";

            ShowData();
        }
        public void ShowData()
        {
            SqlConnection con = new SqlConnection("Data Source=Sharmili\\SQLEXPRESS;Initial Catalog=InventoryManagementdb;Integrated Security=True");
            con.Open();


            SqlDataAdapter sda = new SqlDataAdapter("select * from UserTab", con);

            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.Rows.Clear();

            foreach (DataRow dr in dt.Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells["uid"].Value = dr["UserId"].ToString();
                dataGridView1.Rows[n].Cells["uname"].Value = dr["UserName"].ToString();
                dataGridView1.Rows[n].Cells["addr"].Value = dr["Address"].ToString();
                dataGridView1.Rows[n].Cells["contact"].Value = dr["ContactNo"].ToString();
                dataGridView1.Rows[n].Cells["post"].Value = dr["Position"].ToString();
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            String a = uid8.Text;
            String b = uname8.Text;
            String c = uadd8.Text;
            String d = uphone8.Text;
            String f = upos8.Text;

            SqlConnection con = new SqlConnection("Data Source=Sharmili\\SQLEXPRESS;Initial Catalog=InventoryManagementdb;Integrated Security=True");
            con.Open();

            string sql = "update UserTab set UserName=@unm,Address=@addr,ContactNo=@con,Position=@pos where UserId=@uid ";

            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@unm", b);
            cmd.Parameters.AddWithValue("@addr", c);
            cmd.Parameters.AddWithValue("@con", d);
            cmd.Parameters.AddWithValue("@pos", f);
            cmd.Parameters.AddWithValue("@uid", a);

            int count = cmd.ExecuteNonQuery();
            if (count != 0)
            {
                MessageBox.Show("User data updated ", "Updation");
            }
            else
            {
                MessageBox.Show("Data is not updated", "Error");
            }

            uid8.Text = "";
            uname8.Text = "";
            uadd8.Text = "";
            uphone8.Text = "";
            upos8.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string a = uid8.Text;


            SqlConnection con = new SqlConnection("Data Source=Sharmili\\SQLEXPRESS;Initial Catalog=InventoryManagementdb;Integrated Security=True");
            con.Open();

            string sql = "delete from UserTab where UserId=@uid";

            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@uid", a);

            int status = cmd.ExecuteNonQuery();

            if (status > 0)
            {
                MessageBox.Show("User data deleted ", "Deletion");
            }
            else
            {
                MessageBox.Show("No record found", "Error");
            }

            uid8.Text = "";
            ShowData();
        }

        private void User_Load(object sender, EventArgs e)
        {
            ShowData();
        }
    }
}
