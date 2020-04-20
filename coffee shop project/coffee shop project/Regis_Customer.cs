using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace coffee_shop_project
{
    public partial class Regis_Customer : Form
    {
        public Regis_Customer()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide(); //ซ้อนหน้า Regis_Customer
            Form1 F1 = new Form1();
            F1.Show();  //เปิดหน้า Form1(หน้าคิดเงิน)
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cus_name = textBox4.Text;    //ชื่อสมาชิก
            string cus_gender = comboBox1.Text;    //เลือก Item (เพศ)
            string cos_tel = comboBox1.Text;    //เบอร์โทร
            if (cus_name != "" && cus_gender != "" && cos_tel != "")
            {


                string cus_gen = ""; //เก็บค่าว่างเปล่า
                if (cus_gender == "ชาย") //เช็กเงื่อนไข ถ้าเลือกคำว่า "ชาย"
                {
                    cus_gen = "M";  //ให้แทนด้วยตัว M
                }
                else if (cus_gender == "หญิง") //เช็กเงื่อนไข ถ้าเลือกคำว่า "หญิง"
                {
                    cus_gen = "F";  //ให้แทนด้วยตัว F
                }
                //--------------สมัครสมาชิก---------------
                string sql = "INSERT INTO `customers` " +
                          "(`CustomerID`, `CustomerName`, `Gender`, `CustomerType`, `CustomerTelNo`, `customers_points`) " +
                    "VALUES (NULL, '" + cus_name + "', '" + cus_gen + "', 'Member', '" + cos_tel + "', '0')";
                MySqlConnection con = new MySqlConnection("host = localhost;user=root;password=123456789;database=py_database");
                MySqlCommand cmd = new MySqlCommand(sql, con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                //--------------สมัครสมาชิก---------------
            }
            else
            {
                MessageBox.Show("กรุณาใส่ข้อมูลในช่อง \n'ชื่อ - สกุล'  'เพศ' และ 'เบอร์โทร.'\nให้ครบทุกช่อง");
            }





        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            string cus_ID = "";     //ไอดี
            string cus_Name = ""; //ชื่อ
            string cus_Gender = "";     //เพศ
            string cus_Tel = ""; //เบอร์โทร
            string cus_Points = "";   //แต้ม

            //------------------แสดงข้อมูลสมาชิก--------------------
            string sql = "SELECT * FROM `customers`";
            MySqlConnection con = new MySqlConnection("host = localhost;user=root;password=123456789;database=py_database");
            MySqlCommand cmd = new MySqlCommand(sql, con);
            con.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                //CustomerID | CustomerName | Gender | CustomerType | CustomerTelNo | customers_points
                cus_ID = reader.GetString("CustomerID");     //ไอดี
                cus_Name = reader.GetString("CustomerName"); //ชื่อ
                cus_Gender = reader.GetString("Gender");     //เพศ
                cus_Tel = reader.GetString("CustomerTelNo"); //เบอร์โทร
                cus_Points = reader.GetString("customers_points");   //แต้ม
                                
            }
            con.Close();
            string x = "'" + cus_ID + "''" + cus_Name + "''" + cus_Gender + "''" + cus_Tel + "''" + cus_Points + "'";
            //string x = "ไอดี        :'" + cus_ID + "',\nชื่อ      :'" + cus_Name + "',\nเพศ     :'" + cus_Gender + "',\nเบอร์โทร      :'" + cus_Tel + "',\nแต้มทั้งหมด    :'" + cus_Points + "'";
            listBox1.Text = x.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }
    }
}
