namespace EZTutor.Controls.Browsers
{
    partial class MainBrowser
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.topicBrowser1 = new TopicBrowser();
            this.lectureBrowser1 = new LectureBrowser();
            this.freeSearch1 = new FreeSearch();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Controls.Add(this.topicBrowser1);
            this.flowLayoutPanel1.Controls.Add(this.button2);
            this.flowLayoutPanel1.Controls.Add(this.lectureBrowser1);
            this.flowLayoutPanel1.Controls.Add(this.button3);
            this.flowLayoutPanel1.Controls.Add(this.freeSearch1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(329, 749);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(302, 54);
            this.button1.TabIndex = 6;
            this.button1.Text = "Browse Content By Topic";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(3, 269);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(302, 54);
            this.button2.TabIndex = 7;
            this.button2.Text = "Browse Content By Lecture";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button3.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.Location = new System.Drawing.Point(3, 485);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(302, 54);
            this.button3.TabIndex = 11;
            this.button3.Text = "Search For A Certain Content";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // topicBrowser1
            // 
            this.topicBrowser1.Location = new System.Drawing.Point(3, 63);
            this.topicBrowser1.Name = "topicBrowser1";
            this.topicBrowser1.Size = new System.Drawing.Size(300, 200);
            this.topicBrowser1.TabIndex = 9;
            // 
            // lectureBrowser1
            // 
            this.lectureBrowser1.Location = new System.Drawing.Point(3, 329);
            this.lectureBrowser1.Name = "lectureBrowser1";
            this.lectureBrowser1.Size = new System.Drawing.Size(300, 150);
            this.lectureBrowser1.TabIndex = 10;
            // 
            // freeSearch1
            // 
            this.freeSearch1.Location = new System.Drawing.Point(3, 545);
            this.freeSearch1.Name = "freeSearch1";
            this.freeSearch1.Size = new System.Drawing.Size(300, 150);
            this.freeSearch1.TabIndex = 12;
            // 
            // MainBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "MainBrowser";
            this.Size = new System.Drawing.Size(329, 749);
            this.Load += new System.EventHandler(this.MainBrowser_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private TopicBrowser topicBrowser1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private LectureBrowser lectureBrowser1;
        private System.Windows.Forms.Button button3;
        private FreeSearch freeSearch1;

    }
}