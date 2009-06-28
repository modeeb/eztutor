using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EZTutor.GUI
{
    public partial class Form1 : Form
    {
        Label label1 = new Label();
        int x = 23;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(23, 22);
            this.label1.Name = "label1";
            this.label1.Text = "Head";
            this.Controls.Add(label1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            while (x < 120)
            {
                label1.Location = new System.Drawing.Point(++x, 22);
            }
        }
    }
}