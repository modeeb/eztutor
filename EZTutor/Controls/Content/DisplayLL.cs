using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace EZTutor.Controls.Content
{
    public partial class DisplayLL : UserControl
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
        Label label14 = new Label(); 
        Random r = new Random();
        int node = 1;

        public DisplayLL()
        {
            InitializeComponent();
        }

        private void arrow1()
        {
            try
            {
                int y = (label1.Location.X + label1.Width);
                this.label6.AutoSize = true;
                this.label6.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
                this.label6.Location = new System.Drawing.Point(y, 43);
                this.label6.Name = "label6";
                this.label6.Text = "--->";
                this.Controls.Add(label6);
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void arrow2()
        {
            try
            {
                int y = (label2.Location.X + label2.Width);
                this.label7.AutoSize = true;
                this.label7.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
                this.label7.Location = new System.Drawing.Point(y, 43);
                this.label7.Name = "label7";
                this.label7.Text = "--->";
                this.Controls.Add(label7);
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void arrow3()
        {
            try
            {
                int y = (label3.Location.X + label3.Width);
                this.label8.AutoSize = true;
                this.label8.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
                this.label8.Location = new System.Drawing.Point(y, 43);
                this.label8.Name = "label8";
                this.label8.Text = "--->";
                this.Controls.Add(label8);
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void arrow4()
        {
            try
            {
                int y = (label4.Location.X + label4.Width);
                this.label9.AutoSize = true;
                this.label9.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
                this.label9.Location = new System.Drawing.Point(y, 43);
                this.label9.Name = "label9";
                this.label9.Text = "--->";
                this.Controls.Add(label9);
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void arrow5()
        {
            try
            {
                int y = (label5.Location.X + label5.Width);
                this.label10.AutoSize = true;
                this.label10.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
                this.label10.Location = new System.Drawing.Point(y, 43);
                this.label10.Name = "label10";
                this.label10.Text = "--->";
                this.Controls.Add(label10);
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void arrow6()
        {
            try
            {
                int y = (label11.Location.X + label11.Width);
                this.label13.AutoSize = true;
                this.label13.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
                this.label13.Location = new System.Drawing.Point(y, 43);
                this.label13.Name = "label13";
                this.label13.Text = "--->";
                this.Controls.Add(label13);
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void labelNull(Label mylabel)
        {
            try
            {
                int y = (mylabel.Location.X + mylabel.Width) - 3;
                this.label12.AutoSize = true;
                this.label12.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
                this.label12.Location = new System.Drawing.Point(y, 43);
                this.label12.Name = "label12";
                this.label12.Text = "NULL";
                this.Controls.Add(label12);
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (button1.Text == "Replay")
                {
                    this.Controls.Remove(label1);
                    this.Controls.Remove(label2);
                    this.Controls.Remove(label3);
                    this.Controls.Remove(label4);
                    this.Controls.Remove(label5);
                    this.Controls.Remove(label6);
                    this.Controls.Remove(label7);
                    this.Controls.Remove(label8);
                    this.Controls.Remove(label9);
                    this.Controls.Remove(label10);
                    this.Controls.Remove(label11);
                    this.Controls.Remove(label12);
                    this.Controls.Remove(label13);
                    this.Controls.Remove(label14);
                    label16.Text = "Output:";
                    timer1.Enabled = true;
                    node = 1; 
                }
                this.label1.AutoSize = true;
                this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                this.label1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
                this.label1.Location = new System.Drawing.Point(26, 43);
                this.label1.Name = "label1";
                this.label1.Text = "Head";
                this.Controls.Add(label1);                                           
                arrow1();

                this.label2.AutoSize = true;
                this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                this.label2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
                this.label2.Location = new System.Drawing.Point(label6.Location.X + label6.Width, 43);
                this.label2.Name = "label2";
                this.label2.Text = r.Next(0, 50).ToString();
                this.Controls.Add(label2);
                arrow2();

                this.label3.AutoSize = true;
                this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                this.label3.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
                this.label3.Location = new System.Drawing.Point(label7.Location.X + label7.Width, 43);
                this.label3.Name = "label3";
                this.label3.Text = r.Next(0, 50).ToString();
                this.Controls.Add(label3);
                arrow3();

                this.label4.AutoSize = true;
                this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                this.label4.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
                this.label4.Location = new System.Drawing.Point(label8.Location.X + label8.Width, 43);
                this.label4.Name = "label4";
                this.label4.Text = r.Next(0, 50).ToString();
                this.Controls.Add(label4);
                arrow4();

                this.label5.AutoSize = true;
                this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                this.label5.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
                this.label5.Location = new System.Drawing.Point(label9.Location.X + label9.Width, 43);
                this.label5.Name = "label5";
                this.label5.Text = r.Next(0, 50).ToString();
                this.Controls.Add(label5);
                arrow5();

                this.label11.AutoSize = true;
                this.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                this.label11.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
                this.label11.Location = new System.Drawing.Point(label10.Location.X + label10.Width, 43);
                this.label11.Name = "label11";
                this.label11.Text = r.Next(0, 50).ToString();
                this.Controls.Add(label11);
                arrow6();

                labelNull(label13);
                timer1.Enabled = true;                  
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
                label16.Visible = true;
                node++;
                switch (node)
                {
                    case 2:
                        labelCur(label2);
                        label16.Text += " " + label2.Text;
                        break;
                    case 3:
                        labelCur(label3);
                        label16.Text += ", " + label3.Text;
                        break;
                    case 4:
                        labelCur(label4);
                        label16.Text += ", " + label4.Text;
                        break;
                    case 5:
                        labelCur(label5);
                        label16.Text += ", " + label5.Text;
                        break;
                    case 6:
                        labelCur(label11);
                        label16.Text += ", " + label11.Text;                        
                        button1.Text = "Replay";
                        timer1.Enabled=false; 
                        break;
                    default:
                        break;
                }          
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void labelCur(Label mylabel)
        {
            try
            {
                int x = mylabel.Location.X;
                int y = mylabel.Location.Y - mylabel.Height;
                this.label14.AutoSize = true;
                this.label14.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
                this.label14.ForeColor = System.Drawing.Color.Red;
                this.label14.Location = new System.Drawing.Point(x, y);
                this.label14.Name = "label14";
                this.label14.Text = "Cur";
                this.Controls.Add(label14);
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}