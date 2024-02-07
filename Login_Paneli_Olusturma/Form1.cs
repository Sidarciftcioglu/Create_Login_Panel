using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_Paneli_Olusturma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (maskedTextBox1.Text == "12345678900" && textBox1.Text == "123456")
            {
                MessageBox.Show("Welcome");
            }
            else
            {
                MessageBox.Show("You have entered incomplete or incorrect login\r\n");
            }
        }
    }
}
