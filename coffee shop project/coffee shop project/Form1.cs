using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace coffee_shop_project
{
    public partial class Form1 : Form
    {
        public int totolprice;
        public int prices;
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide(); //ซ้อนหน้า Form1
            add_proucts addproducts = new add_proucts();
            addproducts.Show(); //เปิดหน้า add_products
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int cal_price = 0;
            string N_product = comboBox1.Text; //เครื่องดื่ม
            string T_product = comboBox2.Text; //ชนิดเครื่องดื่ม
            string O_product = comboBox3.Text; //เพิ่มเติม

            //------------------------------------------------------------------------//

            string sql = "SELECT Price FROM products WHERE ProductName ='" + N_product + "'";
            MySqlConnection con = new MySqlConnection("host = localhost;user=root;password=123456789;database=py_database");
            MySqlCommand cmd = new MySqlCommand(sql, con);
            con.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {

                cal_price = reader.GetInt32("Price"); //เก็บราคา
                prices = reader.GetInt32("Price"); //เก็บราคาเฉพาะชิ้น
                totolprice += totolprice + cal_price; //เก็บราคารวม โยกการบวกราคาไปเรื่อยๆ

            }
            con.Close();
            //cal_price = cal_price + totolprice;
            string x = totolprice.ToString(); //แปลงค่าเพื่อแสดงใน textBox1
            textBox1.Text = x; //แสดงราคารวม
            //-----------------------------------------------------------
            if (N_product == "เลือกเครื่องดื่ม") //เช็คเงื่อนไข เลือกเครื่องดื่มหรือยัง
            {
                MessageBox.Show("เครื่องดื่มยังไม่ถูกเลือก");
            }
            else
            {
                if (T_product == "ชนิด") //เช็คเงื่อนไข เลือกชนิดเครื่องดื่มหรือยัง
                {
                    MessageBox.Show("ชนิดเครื่องดื่มยังไม่ถูกเลือก");
                }
                else
                {
                    //listBox1.Items.Add("" + N_product + " " + T_product + "");
                    listBox1.Items.Add(N_product); //แสดชื่อ
                    listBox2.Items.Add(T_product);  //แสดงชนิด
                    listBox3.Items.Add(O_product);  //เพิ่มเติม
                    listBox4.Items.Add(prices); //แสดงราคา
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear(); //ลบค่าใน comboBox1 ทั้งหมด
            string sql = "select * from products";
            MySqlConnection con = new MySqlConnection("host = localhost;user=root;password=123456789;database=py_database");

            MySqlCommand cmd = new MySqlCommand(sql, con);
            con.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string product = reader.GetString("ProductName");
                comboBox1.Items.Add(product); //เพิ่มค่าใน comboBox1 ทั้งหมด
            }
            //cmd.ExecuteNonQuery();
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*------------------------------------------------------------
            if (listBox1.Text == "")
            {
                MessageBox.Show("กรุณาเลือกเครื่องดื่มในหน้ารายการ");
            }
            else
            {
                listBox1.Items.Remove(listBox1.Text);
                ------------------------------------------------------------
            }*/
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            listBox4.Items.Clear();
            totolprice = 0;
            textBox1.Text = totolprice.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*listBox1.Items.Clear();
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
            con.Close();*/
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "" || textBox1.Text == "0") //เช็คเงื่อนไข textBox1 ว่างหรือเท่ากับ 0 หรือไม่
            {
                //ไม่ต้องทำอะไร
            }
            else
            {
                if (textBox2.Text != "") //เช็คเงื่อนไขถ้า textBox2 ไม่ว่าง
                {
                    int totol = int.Parse(textBox2.Text) - totolprice; //ลบจำนวนเงินที่ได้จากลูกค้า กับ ราคาทั้งหมด
                    textBox3.Text = totol.ToString(); //แปลงค่าเป็นข้อความ
                    if (int.Parse(textBox3.Text) < 0)   //เช็นเงื่อนไข ถ้าเงินทอนติดลบ
                    {
                        int c = int.Parse(textBox3.Text) * (-1); //คูณจำนวนที่ติดลบเข้ากับ -1
                        MessageBox.Show("จำนวนเงินไม่พอจ่ายอีก " + c + " บาท"); //แสดงเงินที่ต้องจ่ายเพิ่ม
                    }
                }
                else //ถ้าช่องรับเงินจากลูกค้าว่าง
                {
                    MessageBox.Show("กรุณาใส่จำนวนเงินที่ได้รับจากลูกค้า");
                }

            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox4.Text != "") //ถ้า textBox4 ไม่ว่าง
            {
                /*
                int ttp = 0;
                int CustomerID = int.Parse(textBox4.Text);
                string sql = "SELECT * FROM customers where CustomerID ='" + CustomerID + "'";
                MySqlConnection con = new MySqlConnection("host = localhost;user=root;password=123456789;database=py_database");
                MySqlCommand cmd = new MySqlCommand(sql, con);
                con.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    int Npoint = totolprice / 25;
                    string cus_ID = reader.GetString("CustomerID"); //เก็บราคา)
                    string cus_name = reader.GetString("CustomerName"); //เก็บราคาเฉพาะชิ้น
                    string cus_tel = reader.GetString("CustomerTelNo");
                    int cus_Bpoint = reader.GetInt32("customers_points");
                    label14.Text = "ไอดีลูกค้า     " + cus_ID + "";
                    label15.Text = "ชื่อลูกค้า      " + cus_name + "";
                    label19.Text = "เบอร์โทรลูกค้า  " + cus_tel + "";
                    label16.Text = "แต้มก่อนหน้านี้  " + cus_Bpoint.ToString() + "";
                    label17.Text = "แต้มที่ได้ในครั้งนี้ " + Npoint + "";
                    ttp = Npoint + cus_Bpoint;
                    label18.Text = "รวมแต้มทั้งหมด " + ttp + "";

                }
                con.Close();*/



                int ttp = 0;
                int CustomerID = int.Parse(textBox4.Text);
                int Npoint = totolprice / 25;
                string sql = "SELECT * FROM customers where CustomerID ='" + CustomerID + "'";
                MySqlConnection con = new MySqlConnection("host = localhost;user=root;password=123456789;database=py_database");
                MySqlCommand cmd = new MySqlCommand(sql, con);
                con.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                con.Close();



                               
               
                string sql1 = "UPDATE customers SET customers_points = '" + Npoint + "' WHERE customers.CustomerID ='" + CustomerID + "'";
                MySqlConnection con1 = new MySqlConnection("host = localhost;user=root;password=123456789;database=py_database");
                MySqlCommand cmd1 = new MySqlCommand(sql1, con1);
                con1.Open();
                MySqlDataReader reader1 = cmd1.ExecuteReader();
                if (reader1.Read())
                {
                    string cus_ID = reader.GetString("CustomerID"); //เก็บราคา)
                    string cus_name = reader.GetString("CustomerName"); //เก็บราคาเฉพาะชิ้น
                    string cus_tel = reader.GetString("CustomerTelNo");
                    int cus_Bpoint = reader.GetInt32("customers_points");
                    label14.Text = "ไอดีลูกค้า     " + cus_ID + "";
                    label15.Text = "ชื่อลูกค้า      " + cus_name + "";
                    label19.Text = "เบอร์โทรลูกค้า  " + cus_tel + "";
                    label16.Text = "แต้มก่อนหน้านี้  " + cus_Bpoint.ToString() + "";
                    label17.Text = "แต้มที่ได้ในครั้งนี้ " + Npoint + "";
                    ttp = Npoint + cus_Bpoint;
                    label18.Text = "รวมแต้มทั้งหมด " + ttp + "";

                }
                con1.Close();
                
            }
            else //ถ้า textBox4 ว่าง
            {
                MessageBox.Show("กรุณาใส่ ID ของลูกค้า");
            }
        }
    }
}
