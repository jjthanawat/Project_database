using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace coffee_shop_project
{
    public partial class Form1 : Form
    {
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

        private void button1_Click(object sender, EventArgs e)
        {
            string N_product = comboBox1.Text; //เครื่องดื่ม
            string T_product = comboBox2.Text; //ชนิดเครื่องดื่ม
            string O_product = comboBox3.Text; //เพิ่มเติม
            if (O_product == "ไม่เพิ่ม")
            {
                listBox1.Items.Add("" + N_product + " " + T_product + "");
            }
            else
            {

                listBox1.Items.Add("" + N_product + " " + T_product + " " + O_product + "");
            }
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
    }
}
