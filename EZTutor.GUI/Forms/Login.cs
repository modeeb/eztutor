using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EZTutor.GUI.Forms
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Main f1 = new Main();
            Login lo = new Login();
            //if (textBox1.Text == "username" && textBox2.Text == "password")
            if (true)
            {
                this.Hide();
                f1.Show();
            }
            else
            {
                MessageBox.Show("INVALID USERNAME OR PASSWORD");
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}