using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace coffee_shop_project
{

    public partial class Staff_login : Form
    {
        //public int CUS_ID; //เก็บ ID ของคนขาย
        public Staff_login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
            
            if (textBox2.Text != "" && textBox1.Text != "")
            {
                string sql = "select * from staffs where StaffID = '" + textBox2.Text + "'and StaffPassword = '" + textBox1.Text + "'";
                MySqlConnection con = new MySqlConnection("host = localhost;user=root;password=123456789;database=py_database");
                MySqlCommand cmd = new MySqlCommand(sql, con);
                con.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    int CUS_ID = reader.GetInt32("StaffID"); //เก็บไอดีของคนขายจากหน้า log in
                    this.Hide();
                    Form1 f1 = new Form1();
                    f1.label20.Text = CUS_ID.ToString(); //ให้ไอดีของคนขายไปแสดงในหน้าคิดเงิน
                    f1.Show();
                }
                else
                {
                    MessageBox.Show("ชื่อผู้ใช้ หรือรหัสผ่านไ ไม่ถูกต้อง");
                }
            }
            else
            {
                MessageBox.Show("กรุณาใส่ ชื่อผู้ใช้ และรหัสผ่าน");

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult iExit;
            iExit = MessageBox.Show("Do you want to exit ?", "Cinema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (iExit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
