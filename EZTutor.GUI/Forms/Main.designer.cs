using EZTutor.GUI.Controls;

namespace EZTutor.GUI.Forms
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mainBrowser1 = new EZTutor.GUI.Controls.MainBrowser();
            this.studentMenu1 = new EZTutor.GUI.Controls.StudentMenu();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox1.Controls.Add(this.studentMenu1);
            this.groupBox1.Location = new System.Drawing.Point(-5, -1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(241, 509);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // mainBrowser1
            // 
            this.mainBrowser1.Location = new System.Drawing.Point(243, 13);
            this.mainBrowser1.Name = "mainBrowser1";
            this.mainBrowser1.Size = new System.Drawing.Size(329, 331);
            this.mainBrowser1.TabIndex = 1;
            // 
            // studentMenu1
            // 
            this.studentMenu1.Location = new System.Drawing.Point(17, 19);
            this.studentMenu1.Name = "studentMenu1";
            this.studentMenu1.Size = new System.Drawing.Size(188, 231);
            this.studentMenu1.TabIndex = 1;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 508);
            this.Controls.Add(this.mainBrowser1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Main";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private StudentMenu studentMenu1;
        private MainBrowser mainBrowser1;
    }
}