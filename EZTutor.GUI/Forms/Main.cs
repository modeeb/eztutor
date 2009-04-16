using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EZTutor.GUI.Forms
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //profile1.Visible = false;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (listBox1.SelectedIndex == 2)
            //{
            //    profile1.Visible = true;
            //    userControl11.Visible = false;
            //}
            //if (listBox1.SelectedIndex ==1)
            //{
            //    profile1.Visible = false;
            //    userControl11.Visible = true;
            //}
        }
    }
}