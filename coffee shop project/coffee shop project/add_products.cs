using MySql.Data.MySqlClient;
using System;
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
            //-------------------------สุ่มตัวเลข--------------------//
            /*string output = "";//เก็บตัวเลข 11 ตัวที่ได้จากการสุ่มแปลงเป็น string
            Random r = new Random();
            int[] ar_ran = new int[11]; //เก็บตัวเลข 11 ตัวที่ได้จากการสุ่ม
            for(int i = 0; i <= 10; i++)
            {
                ar_ran[i] = r.Next(0,9);
            }
            for (int j = 0; j <= 10; j++)
            {
                output += ar_ran[j] + "";
            }*/

            string Nproduct = textBox1.Text; //เก็บค่ารายชื่อสินค้า
            string Pproduct = textBox2.Text; //เก็บค่าราคาสินค้า
            string Detail = textBox3.Text;  //เก็บรายละเอียดสินค้า
            string sql = "select * from products";
            //sql = "insert into users(users,password,name,tel) values('" + username + "','" + password + "','" + name + "','" + telephone + "')";
            //DELETE FROM `products` WHERE `products`.`ProductID` = 9;

            if (Nproduct.Length != 0 && Pproduct.Length != 0)
            {
                sql = "INSERT INTO products (ProductName, Price, ProductDetail) VALUES('" + Nproduct + "', '" + Pproduct + "', '" + Detail + "')";
                MySqlConnection con = new MySqlConnection("host = localhost;user=root;password=123456789;database=py_database");

                MySqlCommand cmd = new MySqlCommand(sql, con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("บันทึกสินค้าแล้ว");
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
            }
            else
            {
                MessageBox.Show("กรุณาใส่ชื่อ และราคาของสินค้าด้วยครับ");
            }
            listBox1.Items.Add(Nproduct);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 F1 = new Form1();
            F1.Show();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string sql = "select * from products";
            MySqlConnection con = new MySqlConnection("host = localhost;user=root;password=123456789;database=py_database");

            MySqlCommand cmd = new MySqlCommand(sql, con);
            con.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string product = reader.GetString("ProductName");
                listBox1.Items.Add(product);
            }
            //cmd.ExecuteNonQuery();
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //string sql = "SELECT Price FROM products WHERE ProductName ='" + N_product + "'";
            //string sql = "DELETE FROM products WHERE products.ProductID = 13";
            string sql = "DELETE FROM products WHERE ProductName = '" + N_product + "'";
            MySqlConnection con = new MySqlConnection("host = localhost;user=root;password=123456789;database=py_database");
            MySqlCommand cmd = new MySqlCommand(sql, con);
            con.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {

                cal_price = reader.GetInt32("Price");
                totolprice += totolprice + cal_price;

            }
            con.Close();
        }
    }
}
