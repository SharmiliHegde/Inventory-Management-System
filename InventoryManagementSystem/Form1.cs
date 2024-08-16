using System.Drawing;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Data.SqlClient;
using System.Data;
using static Azure.Core.HttpHeader;

namespace InventoryManagementSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string a = usname1.Text;
            string b = pass1.Text;


            SqlConnection con = new SqlConnection("Data Source=Sharmili\\SQLEXPRESS;Initial Catalog=InventoryManagementdb;Integrated Security=True");
            con.Open();

            try
            {
                string sql = "SELECT * FROM Login WHERE Username= '"+usname1.Text+"'  and Password= '"+pass1.Text+"'";
                SqlDataAdapter sda = new SqlDataAdapter(sql,con);

                DataTable dtable = new DataTable();
                sda.Fill(dtable);

                if(dtable.Rows.Count > 0)
                {
                    a = usname1.Text;
                    b = pass1.Text;

                    MessageBox.Show("Login Sucessfull", "Successfull");


                    Form2 obj = new Form2();
                    obj.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Invalied Detials", "Error");
                    usname1.Text = "";
                    pass1.Text = "";

                }


            }
            catch 
            {
                MessageBox.Show("Error");
            }
            finally
            {

                con.Close(); 
            
            }
        
        
        
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Register obj = new Register();
            obj.Show();

        }
    }
}
