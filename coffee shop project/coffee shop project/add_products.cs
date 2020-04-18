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

            string sql = "select * from users";
            sql = "insert into users(users,password,name,tel) values('" + username + "','" + password + "','" + name + "','" + telephone + "')";
            MySqlConnection con = new MySqlConnection("host = localhost;user=root;password=mca12345;database=project");

            MySqlCommand cmd = new MySqlCommand(sql, con);
            con.Open();

            /*MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                MessageBox.Show(reader.GetString("id")+" "+reader.GetString("name"));
            }*/

            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Registered Please return to the login page.");
        }
    }
}
