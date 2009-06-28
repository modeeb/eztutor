using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EZTutor.Arguments;
using EZTutor.Enums;

namespace EZTutor.Forms
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SecurityArgs args = new SecurityArgs();
            if (textBox1.Text == "instructor" && textBox2.Text == "instructor")
            {
                args.UserName = textBox1.Text;
                args.UserType = UserType.Instructor;
                Main f1 = new Main(args);
                Hide();
                f1.Show();
            }
            else if (true)
            {
                args.UserName = textBox1.Text;
                args.UserType = UserType.Student;
                Main f1 = new Main(args);
                Hide();
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
    }
}