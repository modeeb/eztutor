using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using AgentObjects;

namespace EZTutor.Controls.Content
{
    public partial class LL : UserControl 
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
        Label label15 = new Label();
        Random r = new Random();        
        private IAgentCtlCharacterEx genie;
        int timerno = 0;
        
        public LL()
        {
            InitializeComponent();
        }        

        private void UserControl1_Load(object sender, EventArgs e)
        {
            try
            {
                axAgent1.Characters.Load("genie", "merlin.acs");
                genie = axAgent1.Characters["genie"];
                genie.Show(null);
                genie.Speak(textBox1.Text, null);
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void labelPrev(Label mylabel)
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
                this.label14.Text = "Prev";
                this.Controls.Add(label14);
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void labelNode(Label mylabel)
        {
            try
            {
                int x = mylabel.Location.X;
                int y = mylabel.Location.Y - mylabel.Height;
                this.label15.AutoSize = true;
                this.label15.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
                this.label15.ForeColor = System.Drawing.Color.Blue;
                this.label15.Location = new System.Drawing.Point(x, y);
                this.label15.Name = "label15";
                this.label15.Text = "New Node";
                this.Controls.Add(label15);
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
                    button1.Enabled = true;
                    button2.Enabled = true;
                    if (radioButton2.Checked == false)
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

        private void timer2_Tick(object sender, EventArgs e)
        {
            try
            {
                if (!this.Controls.Contains(label2))
                {
                    textBox1.Text = "text2";
                    labelPrev(label1);                    
                    this.label2.AutoSize = true;
                    this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                    this.label2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
                    this.label2.Location = new System.Drawing.Point(5, 14);
                    this.label2.Name = "label2";
                    this.label2.Text = r.Next(0, 50).ToString();
                    this.Controls.Add(label2);
                }

                int x = label2.Location.X;
                int z = (label6.Location.X + label6.Width);
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
                    labelNode(label2);
                    button1.Enabled = true ;
                    button2.Enabled = true;
                    if (radioButton2.Checked == false)
                        timer3.Enabled = true;
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }       

        private void timer3_Tick(object sender, EventArgs e)
        {
            try
            {
                if (!this.Controls.Contains(label3))
                {
                    textBox1.Text = "text3";
                    labelPrev(label2);
                    this.Controls.Remove(label15);
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
                    labelNode(label3);
                    button1.Enabled = true;
                    button2.Enabled = true;
                    if (radioButton2.Checked == false)
                        timer4.Enabled = true;
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            try
            {
                if (!this.Controls.Contains(label4))
                {
                    textBox1.Text = "text4";
                    labelPrev(label3);
                    this.Controls.Remove(label15);
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
                    labelNode(label4);
                    button1.Enabled = true;
                    button2.Enabled = true;
                    if (radioButton2.Checked == false)
                        timer5.Enabled = true;
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            try
            {
                if (!this.Controls.Contains(label5))
                {
                    textBox1.Text = "text5";
                    labelPrev(label4);
                    this.Controls.Remove(label15);
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
                    labelNode(label5);
                    button1.Enabled = true;
                    button2.Enabled = true;
                    if (radioButton2.Checked == false)
                        timer6.Enabled = true;
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            try
            {
                if (!this.Controls.Contains(label11))
                {
                    textBox1.Text = "text6";
                    labelPrev(label5);
                    this.Controls.Remove(label15);
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
                    button1.Enabled = true;
                    button2.Enabled = true;
                    labelNull(label13);
                    labelNode(label11);
                }
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
                if (timerno == 6)
                    return;

                timerno++;
                switch (timerno)
                {
                    case 1:
                        timer1.Enabled = true;
                        button1.Enabled = false;
                        break;
                    case 2:
                        timer2.Enabled = true;
                        button1.Enabled = false;
                        break;
                    case 3:
                        timer3.Enabled = true;
                        button1.Enabled = false;
                        break;
                    case 4:
                        timer4.Enabled = true;
                        button1.Enabled = false;
                        break;
                    case 5:
                        timer5.Enabled = true;
                        button1.Enabled = false;
                        break;
                    case 6:
                        timer6.Enabled = true;
                        button1.Enabled = false;
                        break;                    
                    default :
                        break;
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {                            
                //genie.SoundEffectsOn = false ;            
                genie.Speak(textBox1.Text, null);
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                genie.Hide(null);
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                genie.Stop(null);                
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {                
                genie.Show(null);
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }        

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (radioButton2.Checked == true)
                {
                    timerno = 0;
                    button1.Enabled = true;
                    button2.Enabled = true;
                    button7.Enabled = false;
                    button8.Enabled = false;
                   
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
                    this.Controls.Remove(label15);
                    timer1.Enabled = false;
                    timer2.Enabled = false;
                    timer3.Enabled = false;
                    timer4.Enabled = false;
                    timer5.Enabled = false;
                    timer6.Enabled = false;
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (radioButton1.Checked == true)
                {
                    button7.Enabled = true;
                    button8.Enabled = true;
                    button1.Enabled = false;
                    button2.Enabled = false;

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
                    this.Controls.Remove(label15);
                    timer1.Enabled = false;
                    timer2.Enabled = false;
                    timer3.Enabled = false;
                    timer4.Enabled = false;
                    timer5.Enabled = false;
                    timer6.Enabled = false;
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (timerno == 0)
                    return;
                if (timerno != 1)
                    timerno--;
               
                switch (timerno)
                {
                    case 1:
                        this.Controls.Remove(label1);
                        this.Controls.Remove(label6);
                        this.Controls.Remove(label12);
                        this.Controls.Remove(label2);
                        this.Controls.Remove(label7);
                        this.Controls.Remove(label12);
                        this.Controls.Remove(label14);
                        this.Controls.Remove(label15);  
                        timer1.Enabled = true;
                        button2.Enabled = false;
                        break;
                    case 2:
                        this.Controls.Remove(label2);
                        this.Controls.Remove(label7);
                        this.Controls.Remove(label12);
                        this.Controls.Remove(label3);
                        this.Controls.Remove(label8);
                        this.Controls.Remove(label12);
                        this.Controls.Remove(label14);
                        this.Controls.Remove(label15); 
                        timer2.Enabled = true;
                        button2.Enabled = false;
                        break;
                    case 3:
                        this.Controls.Remove(label3);
                        this.Controls.Remove(label8);
                        this.Controls.Remove(label12);
                        this.Controls.Remove(label4);
                        this.Controls.Remove(label9);
                        this.Controls.Remove(label12);
                        this.Controls.Remove(label14);
                        this.Controls.Remove(label15); 
                        timer3.Enabled = true;
                        button2.Enabled = false;
                        break;
                    case 4:
                        this.Controls.Remove(label4);
                        this.Controls.Remove(label9);
                        this.Controls.Remove(label12);
                        this.Controls.Remove(label5);
                        this.Controls.Remove(label10);
                        this.Controls.Remove(label12);
                        this.Controls.Remove(label14);
                        this.Controls.Remove(label15); 
                        timer4.Enabled = true;
                        button2.Enabled = false;
                        break;
                    case 5:
                        this.Controls.Remove(label5);
                        this.Controls.Remove(label10);
                        this.Controls.Remove(label12);
                        this.Controls.Remove(label11);
                        this.Controls.Remove(label13);
                        this.Controls.Remove(label12);
                        this.Controls.Remove(label14);
                        this.Controls.Remove(label15); 
                        timer5.Enabled = true;
                        button2.Enabled = false;
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

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                timer1.Enabled = true;                
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
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
                this.Controls.Remove(label15);
                timer1.Enabled = false;
                timer2.Enabled = false;
                timer3.Enabled = false;
                timer4.Enabled = false;
                timer5.Enabled = false;
                timer6.Enabled = false;
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }                           
    }
}