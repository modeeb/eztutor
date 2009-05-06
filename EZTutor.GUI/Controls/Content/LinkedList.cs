using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EZTutor.GUI.Controls.Content
{
    public partial class LinkedList : UserControl
    {
        LL a;
        DisplayLL b;
        RetrieveLL c;

        public LinkedList()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.Controls.Contains(b))
                this.Controls.Remove(b);

            if (this.Controls.Contains(c))
                this.Controls.Remove(c);
            
            if (this.Controls.Contains(a))
                return;

            a = new LL();
            a.Location = new System.Drawing.Point(12, 12);
            this.Controls.Add(a);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.Controls.Contains(a))
                this.Controls.Remove(a);
            
            if (this.Controls.Contains(c))
                this.Controls.Remove(c);

            if (this.Controls.Contains(b))
                return;

            b = new DisplayLL();
            b.Location = new System.Drawing.Point(12, 12);
            this.Controls.Add(b);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //if (this.Controls.Contains(a))
            //    this.Controls.Remove(a);
            
            //if (this.Controls.Contains(b))
            //    this.Controls.Remove(b);

            //if (this.Controls.Contains(c))
            //    return;

            //c = new RetrieveLL ();
            //c.Location = new System.Drawing.Point(12, 12);
            //this.Controls.Add(c);
        }                         
    }
}