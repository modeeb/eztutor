using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace EZTutor.GUI
{
    public partial class Slides : UserControl 
    {
        Label label1 = new Label();
        Label label2 = new Label();
        Label label3 = new Label();
        Label label4 = new Label();
        Label label5 = new Label();        
        Label label6 = new Label();
        Label label7 = new Label();
        Label label8 = new Label();
        Label label9 = new Label();
        Label label10 = new Label();
        Label label11 = new Label();
        Label label12 = new Label();
        Label label13 = new Label();
        Random r = new Random();
        ArrayList mylist = new ArrayList();
        int count = 0;

        public Slides()
        {
            InitializeComponent();
        }        

        private void UserControl1_Load(object sender, EventArgs e)
        {
            try
            {
                timer1.Enabled = true;              

                mylist.Add("What is a linked List?It is a list of items in which each item tells where to get the next item, in this case the items may be in any order. The order of the list will be known from the item structure.");
                mylist.Add("Int* P;typedef int* PointerType;PointerType P,Q;Int X;//reserve a memory cell for X,What is *P? P = &X; // find the address of X and store it in P (using address-of operator &)");
                mylist.Add("P = new int; //P = NULL; //Q = P; //Delete P; //How and what?Pointer Declaration:Pointer allocation (statement):Null  pointer:Accessing the cell to which  a pointer points : Pointer reference:Delete a pointer:Check a pointer");
                mylist.Add("Pointer-Based Linked Lists:List node C++ definition: ? Struct node{ int  data; node*  next; }; typedef node* ptrtype; typedef node   nodetype; or");
                mylist.Add("struct  node;typedef node* ptrType;Struct node { int  data; ptrType  next; };p = new node;");
                mylist.Add("To keep track of the first node in the list (that is the only way to get to the next and the following nodes in the list), we must preserve a special memory cell that points to the start or the head of the list.Ptrtype Head;");
                mylist.Add("To know when the list ends, (i.e., there was not any nodes in the LL any more), you must use the NULL keyword.Empty list : Head = null;");                
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }        

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                if (!this.Controls.Contains(label1))
                {
                    this.label1.AutoSize = true;
                    this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                    this.label1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
                    this.label1.Location = new System.Drawing.Point(5, 14);
                    this.label1.Name = "label1";
                    this.label1.Text = "Head";
                    this.Controls.Add(label1);
                }
                int x = label1.Location.X;
                if (x == 26)
                {
                    timer1.Stop();
                    arrow1();
                    labelNull(label6);
                    timer2.Enabled = true;  
                }
                label1.Location = new System.Drawing.Point(++x, 43);                                                 
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void arrow1()
        {
            int y = (label1.Location.X + label1.Width);
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(y, 43);
            this.label6.Name = "label8";
            this.label6.Text = "--->";
            this.Controls.Add(label6);                                              
        }

        private void arrow2()
        {
            int y = (label2.Location.X + label2.Width);
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(y, 43);
            this.label7.Name = "label7";
            this.label7.Text = "--->";
            this.Controls.Add(label7);
        }

        private void arrow3()
        {
            int y = (label3.Location.X + label3.Width);
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(y, 43);
            this.label8.Name = "label8";
            this.label8.Text = "--->";
            this.Controls.Add(label8);
        }

        private void arrow4()
        {
            int y = (label4.Location.X + label4.Width);
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(y, 43);
            this.label9.Name = "label9";
            this.label9.Text = "--->";
            this.Controls.Add(label9);
        }

        private void arrow5()
        {
            int y = (label5.Location.X + label5.Width);
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(y, 43);
            this.label10.Name = "label10";
            this.label10.Text = "--->";
            this.Controls.Add(label10);
        }

        private void arrow6()
        {
            int y = (label11.Location.X + label11.Width);
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label13.Location = new System.Drawing.Point(y, 43);
            this.label13.Name = "label13";
            this.label13.Text = "--->";
            this.Controls.Add(label13);
        }

        private void labelNull(Label mylabel)
        {
            int y = (mylabel.Location.X + mylabel.Width)-3;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(y, 43);
            this.label12.Name = "label12";
            this.label12.Text = "NULL";
            this.Controls.Add(label12);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (!this.Controls.Contains(label2))
            {                              
                this.label2.AutoSize = true;
                this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                this.label2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
                this.label2.Location = new System.Drawing.Point(5, 14);
                this.label2.Name = "label2";
                this.label2.Text = r.Next(0, 50).ToString ();
                this.Controls.Add(label2);
            }
            int x = label2.Location.X;
            int z = (label6.Location.X + label6.Width) ;
            int y = label2.Location.Y;
            if (x != z)
                label2.Location = new System.Drawing.Point(++x, 14);
            if (x == z)
            {
                if (y == 42)
                    label12.Visible = false; 
                if (y != 43)
                label2.Location = new System.Drawing.Point(x, ++y);
            }
            if (y == 43)
            {
                timer2.Stop();
                arrow2();
                label12.Visible = true;
                labelNull(label7);
                timer3.Enabled = true;  
            }
        }       

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (!this.Controls.Contains(label3))
            {
                this.label3.AutoSize = true;
                this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                this.label3.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
                this.label3.Location = new System.Drawing.Point(5, 14);
                this.label3.Name = "label3";
                this.label3.Text = r.Next(0, 50).ToString();
                this.Controls.Add(label3);
            }
            int x = label3.Location.X;
            int z = (label7.Location.X + label7.Width);
            int y = label3.Location.Y;
            if (x != z)
                label3.Location = new System.Drawing.Point(++x, 14);
            if (x == z)
            {
                if (y == 42)
                    label12.Visible = false; 
                if (y != 43)
                    label3.Location = new System.Drawing.Point(x, ++y);
            }
            if (y == 43)
            {
                timer3.Stop();
                arrow3();
                label12.Visible = true;
                labelNull(label8);
                timer4.Enabled = true;
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            if (!this.Controls.Contains(label4))
            {
                this.label4.AutoSize = true;
                this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                this.label4.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
                this.label4.Location = new System.Drawing.Point(5, 14);
                this.label4.Name = "label4";
                this.label4.Text = r.Next(0, 50).ToString();
                this.Controls.Add(label4);
            }
            int x = label4.Location.X;
            int z = (label8.Location.X + label8.Width);
            int y = label4.Location.Y;
            if (x != z)
                label4.Location = new System.Drawing.Point(++x, 14);
            if (x == z)
            {
                if (y == 42)
                    label12.Visible = false; 
                if (y != 43)
                    label4.Location = new System.Drawing.Point(x, ++y);
            }
            if (y == 43)
            {
                timer4.Stop();
                arrow4();
                label12.Visible = true;
                labelNull(label9);
                timer5.Enabled = true;
            }
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            if (!this.Controls.Contains(label5))
            {
                this.label5.AutoSize = true;
                this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                this.label5.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
                this.label5.Location = new System.Drawing.Point(5, 14);
                this.label5.Name = "label5";
                this.label5.Text = r.Next(0, 50).ToString();
                this.Controls.Add(label5);
            }
            int x = label5.Location.X;
            int z = (label9.Location.X + label9.Width);
            int y = label5.Location.Y;
            if (x != z)
                label5.Location = new System.Drawing.Point(++x, 14);
            if (x == z)
            {
                if (y == 42)
                    label12.Visible = false; 
                if (y != 43)
                    label5.Location = new System.Drawing.Point(x, ++y);
            }
            if (y == 43)
            {
                timer5.Stop();
                arrow5();
                label12.Visible = true;
                labelNull(label10);
                timer6.Enabled = true;
            }                            
        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            if (!this.Controls.Contains(label11))
            {
                this.label11.AutoSize = true;
                this.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                this.label11.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
                this.label11.Location = new System.Drawing.Point(5, 14);
                this.label11.Name = "label11";
                this.label11.Text = r.Next(0, 50).ToString();
                this.Controls.Add(label11);
            }
            int x = label11.Location.X;
            int z = (label10.Location.X + label10.Width);
            int y = label11.Location.Y;
            if (x != z)
                label11.Location = new System.Drawing.Point(++x, 14);
            if (x == z)
            {
                if (y == 42)
                    label12.Visible = false; 
                if (y != 43)
                    label11.Location = new System.Drawing.Point(x, ++y);
            }
            if (y == 43)
            {
                timer6.Stop();
                arrow6();
                label12.Visible = true;
                labelNull(label13);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (count == 0)
                return;
            count--;
            textBox1.Text = mylist[count].ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (count == mylist.Count-1)
                return;
            count++;
            textBox1.Text = mylist[count].ToString();
        }                 
    }
}
