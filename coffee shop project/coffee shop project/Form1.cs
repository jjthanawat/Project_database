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
    }
}
