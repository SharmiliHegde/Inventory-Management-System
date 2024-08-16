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

namespace InventoryManagementSystem;

public partial class Inventory : Form
{
    public Inventory()
    {
        InitializeComponent();
    }

    private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {

    }

    private void label12_Click(object sender, EventArgs e)
    {

    }

    private void button1_Click(object sender, EventArgs e)
    {
        String a = pid6.Text;
        String b = pname6.Text;
        String c = cname6.Text;
        String d = qnt6.Text;
        String f = price6.Text;
        String g = date6.Text;



        SqlConnection con = new SqlConnection("Data Source=Sharmili\\SQLEXPRESS;Initial Catalog=InventoryManagementdb;Integrated Security=True");
        con.Open();

        String query = "INSERT INTO InventoryTab(ProductId,ProductName,CustomerName,Quantity,Price,Date) values ('" + a + "','" + b + "','" + c + "','" + d + "', '" + f + "' , '" + g + "')";

        SqlDataAdapter sda = new SqlDataAdapter(query, con);
        sda.SelectCommand.ExecuteNonQuery();

        MessageBox.Show("Inventory data inserted successfully", "Data Insertion");

        pid6.Text = "";
        pname6.Text = "";
        cname6.Text = "";
        qnt6.Text = "";
        price6.Text = "";
        date6.Text = "";

        ShowData();
    }

    public void ShowData()
    {
        SqlConnection con = new SqlConnection("Data Source=Sharmili\\SQLEXPRESS;Initial Catalog=InventoryManagementdb;Integrated Security=True");
        con.Open();


        SqlDataAdapter sda = new SqlDataAdapter("select * from InventoryTab", con);

        DataTable dt = new DataTable();
        sda.Fill(dt);
        dataGridView1.Rows.Clear();

        foreach (DataRow dr in dt.Rows)
        {
            int n = dataGridView1.Rows.Add();
            dataGridView1.Rows[n].Cells["pid"].Value = dr["ProductId"].ToString();
            dataGridView1.Rows[n].Cells["pname"].Value = dr["ProductName"].ToString();
            dataGridView1.Rows[n].Cells["cname"].Value = dr["CustomerName"].ToString();
            dataGridView1.Rows[n].Cells["qnty"].Value = dr["Quantity"].ToString();
            dataGridView1.Rows[n].Cells["price"].Value = dr["Price"].ToString();
            dataGridView1.Rows[n].Cells["date"].Value = Convert.ToDateTime(dr["Date"].ToString()).ToString("dd/MM/yy");
        }


        if (dataGridView1.Rows.Count > 0)
        {
            label11.Text = dataGridView1.Rows.Count.ToString();
            label12.Text = dataGridView1.Rows.Count.ToString();

            float totalQnty = 0;

            for (int i = 0; i < dataGridView1.Rows.Count;++i)
            {
                totalQnty += float.Parse(dataGridView1.Rows[i].Cells["qnty"].Value.ToString());

                label13.Text = totalQnty.ToString();   
            }
        }
        else
        {
            label11.Text = "0";
            label12.Text = "0"; 
        }


    }

    private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
    {
        String a = pid6.Text;
        String b = pname6.Text;
        String c = cname6.Text;
        String d = qnt6.Text;
        String f = price6.Text;
        String g = date6.Text;



        SqlConnection con = new SqlConnection("Data Source=Sharmili\\SQLEXPRESS;Initial Catalog=InventoryManagementdb;Integrated Security=True");
        con.Open();

        string sql = "update InventoryTab set ProductName=@pnm,CustomerName=@cnm,Quantity=@qnt,Price=@pri,Date=@dt where ProductId=@pid ";

        SqlCommand cmd = new SqlCommand(sql, con);
        
        cmd.Parameters.AddWithValue("@pnm", b);
        cmd.Parameters.AddWithValue("@cnm", c);
        cmd.Parameters.AddWithValue("@qnt", d);
        cmd.Parameters.AddWithValue("@pri", f);
        cmd.Parameters.AddWithValue("@dt", g);
        cmd.Parameters.AddWithValue("@pid", a);

        int count = cmd.ExecuteNonQuery();
        if (count != 0)
        {
            MessageBox.Show("Inventory data updated ", "Updation");
        }
        else
        {
            MessageBox.Show("Data is not updated", "Error");
        }
        pid6.Text = "";
        pname6.Text = "";
        cname6.Text = "";
        qnt6.Text = "";
        price6.Text = "";
        date6.Text = "";
    }

    private void button2_Click(object sender, EventArgs e)
    {

    }

    private void button3_Click(object sender, EventArgs e)
    {
        string a = pid6.Text;

        SqlConnection con = new SqlConnection("Data Source=Sharmili\\SQLEXPRESS;Initial Catalog=InventoryManagementdb;Integrated Security=True");
        con.Open();


        string sql = "delete from InventoryTab where ProductId=@pid";

        SqlCommand cmd = new SqlCommand(sql, con);
        cmd.Parameters.AddWithValue("@pid", a);

        int status = cmd.ExecuteNonQuery();

        if (status > 0)
        {
            MessageBox.Show("Inventory data deleted ", "Deletion");
        }
        else
        {
            MessageBox.Show("No record found", "Error");
        }

        pid6.Text = "";
        ShowData();
    }

    private void Inventory_Load(object sender, EventArgs e)
    {
        ShowData();
    }
}

