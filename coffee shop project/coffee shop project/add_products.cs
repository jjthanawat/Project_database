using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace coffee_shop_project
{
    public partial class add_proucts : Form
    {
        public add_proucts()
        {
            InitializeComponent();
        }

        private void add_proucts_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*string Nproduct = textBox1.Text; //เก็บค่ารายชื่อสินค้า
            string Pproduct = textBox2.Text; //เก็บค่าราคาสินค้า
            string sql = "select * from products";
            //sql = "insert into users(users,password,name,tel) values('" + username + "','" + password + "','" + name + "','" + telephone + "')";
            sql = "INSERT INTO products (ProductID, ProductName, Price, ProductDetail) VALUES('0000', 'productname0000000', '60', 'ProductDetail0000000')";
            MySqlConnection con = new MySqlConnection("host = localhost;user=root;password=123456789;database=py_database");

            MySqlCommand cmd = new MySqlCommand(sql, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Registered Please return to the login page.");*/
            Random r = new Random();

        }
    }
}
