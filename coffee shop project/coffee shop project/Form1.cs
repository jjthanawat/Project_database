using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace coffee_shop_project
{
    public partial class Form1 : Form
    {
        public int totolprice;
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
            this.Hide();
            add_proucts addproducts = new add_proucts();
            addproducts.Show();
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
                {   //เช็คเงื่อนไข เพิ่มอะไรลงในเครื่องดื่มหรือไม่
                    if (O_product == "ไม่เพิ่ม" || O_product == "เพิ่มเติม")   //ไม่เพิ่ม
                    {
                        listBox1.Items.Add("" + N_product + " " + T_product + "");
                    }
                    else   //เพิ่ม
                    {

                        listBox1.Items.Add("" + N_product + " " + T_product + " " + O_product + ""); //เพิ่มรายการนี้ลงใน listbox
                    }
                }
            }
            //------------------------------------------------------------------------//

            string sql = "SELECT Price FROM products WHERE ProductName ='" + N_product + "'";
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
            //cal_price = cal_price + totolprice;
            string x = totolprice.ToString();
            textBox1.Text = x;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            string sql = "select * from products";
            MySqlConnection con = new MySqlConnection("host = localhost;user=root;password=123456789;database=py_database");

            MySqlCommand cmd = new MySqlCommand(sql, con);
            con.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string product = reader.GetString("ProductName");
                comboBox1.Items.Add(product);
            }
            //cmd.ExecuteNonQuery();
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.Text == "")
            {
                MessageBox.Show("กรุณาเลือกเครื่องดื่มในหน้ารายการ");
            }
            else
            {
                listBox1.Items.Remove(listBox1.Text);
            }
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
            int totol = int.Parse(textBox2.Text)- totolprice;
            textBox3.Text = totol.ToString();
        }
    }
}
