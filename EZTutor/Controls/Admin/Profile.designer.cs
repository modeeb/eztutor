namespace EZTutor.Controls.Admin
{
    partial class Profile
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
            this.components = new System.ComponentModel.Container();
            this.password = new System.Windows.Forms.TextBox();
            this.birth_date = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.mobile = new System.Windows.Forms.TextBox();
            this.phone = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.photo = new System.Windows.Forms.Button();
            this.address = new System.Windows.Forms.TextBox();
            this.interests = new System.Windows.Forms.TextBox();
            this.job = new System.Windows.Forms.TextBox();
            this.gender = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.hidden = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.full_name = new System.Windows.Forms.TextBox();
            this.user_name = new System.Windows.Forms.TextBox();
            this.remoteDataSet = new EZTutor.Datasets.RemoteDataSet();
            this.ezprofilesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ez_profilesTableAdapter = new EZTutor.Datasets.RemoteDataSetTableAdapters.Ez_profilesTableAdapter();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.remoteDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ezprofilesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // password
            // 
            this.password.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ezprofilesBindingSource, "password", true));
            this.password.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Location = new System.Drawing.Point(104, 66);
            this.password.Margin = new System.Windows.Forms.Padding(4);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(132, 23);
            this.password.TabIndex = 0;
            // 
            // birth_date
            // 
            this.birth_date.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birth_date.Location = new System.Drawing.Point(104, 129);
            this.birth_date.Margin = new System.Windows.Forms.Padding(4);
            this.birth_date.Name = "birth_date";
            this.birth_date.Size = new System.Drawing.Size(132, 23);
            this.birth_date.TabIndex = 2;
            // 
            // email
            // 
            this.email.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ezprofilesBindingSource, "email", true));
            this.email.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.Location = new System.Drawing.Point(104, 160);
            this.email.Margin = new System.Windows.Forms.Padding(4);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(132, 23);
            this.email.TabIndex = 3;
            // 
            // mobile
            // 
            this.mobile.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ezprofilesBindingSource, "mobile", true));
            this.mobile.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mobile.Location = new System.Drawing.Point(104, 191);
            this.mobile.Margin = new System.Windows.Forms.Padding(4);
            this.mobile.Name = "mobile";
            this.mobile.Size = new System.Drawing.Size(132, 23);
            this.mobile.TabIndex = 4;
            // 
            // phone
            // 
            this.phone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ezprofilesBindingSource, "phone", true));
            this.phone.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phone.Location = new System.Drawing.Point(104, 227);
            this.phone.Margin = new System.Windows.Forms.Padding(4);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(132, 23);
            this.phone.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 66);
            this.label1.Margin = new System.Windows.Forms.Padding(4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 97);
            this.label2.Margin = new System.Windows.Forms.Padding(4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Gender:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 129);
            this.label3.Margin = new System.Windows.Forms.Padding(4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Birth Date:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 160);
            this.label4.Margin = new System.Windows.Forms.Padding(4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "E-Mail:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(4, 191);
            this.label5.Margin = new System.Windows.Forms.Padding(4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Mobile:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(4, 227);
            this.label6.Margin = new System.Windows.Forms.Padding(4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Phone:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(4, 258);
            this.label7.Margin = new System.Windows.Forms.Padding(4);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Address:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(4, 289);
            this.label8.Margin = new System.Windows.Forms.Padding(4);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 16);
            this.label8.TabIndex = 13;
            this.label8.Text = "Interests:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(4, 320);
            this.label9.Margin = new System.Windows.Forms.Padding(4);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 16);
            this.label9.TabIndex = 14;
            this.label9.Text = "Job:";
            // 
            // photo
            // 
            this.photo.Location = new System.Drawing.Point(254, 191);
            this.photo.Margin = new System.Windows.Forms.Padding(4);
            this.photo.Name = "photo";
            this.photo.Size = new System.Drawing.Size(145, 28);
            this.photo.TabIndex = 16;
            this.photo.Text = "Upload Photo ...";
            this.photo.UseVisualStyleBackColor = true;
            // 
            // address
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.address, 2);
            this.address.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ezprofilesBindingSource, "address", true));
            this.address.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address.Location = new System.Drawing.Point(104, 258);
            this.address.Margin = new System.Windows.Forms.Padding(4);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(295, 23);
            this.address.TabIndex = 17;
            // 
            // interests
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.interests, 2);
            this.interests.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ezprofilesBindingSource, "interests", true));
            this.interests.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.interests.Location = new System.Drawing.Point(104, 289);
            this.interests.Margin = new System.Windows.Forms.Padding(4);
            this.interests.Name = "interests";
            this.interests.Size = new System.Drawing.Size(295, 23);
            this.interests.TabIndex = 18;
            // 
            // job
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.job, 2);
            this.job.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ezprofilesBindingSource, "job", true));
            this.job.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.job.Location = new System.Drawing.Point(104, 320);
            this.job.Margin = new System.Windows.Forms.Padding(4);
            this.job.Name = "job";
            this.job.Size = new System.Drawing.Size(295, 23);
            this.job.TabIndex = 19;
            // 
            // gender
            // 
            this.gender.FormattingEnabled = true;
            this.gender.Items.AddRange(new object[] {
            "Male",
            "Femal"});
            this.gender.Location = new System.Drawing.Point(104, 97);
            this.gender.Margin = new System.Windows.Forms.Padding(4);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(132, 24);
            this.gender.TabIndex = 20;
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button2.Location = new System.Drawing.Point(125, 351);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 21;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // hidden
            // 
            this.hidden.AutoSize = true;
            this.hidden.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.ezprofilesBindingSource, "hidden", true));
            this.hidden.Location = new System.Drawing.Point(254, 227);
            this.hidden.Margin = new System.Windows.Forms.Padding(4);
            this.hidden.Name = "hidden";
            this.hidden.Size = new System.Drawing.Size(145, 20);
            this.hidden.TabIndex = 24;
            this.hidden.Text = "Invisible to others";
            this.hidden.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.Controls.Add(this.job, 1, 10);
            this.tableLayoutPanel1.Controls.Add(this.interests, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.address, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.phone, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.mobile, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.email, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.birth_date, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.gender, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.password, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 10);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label13, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label14, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.full_name, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.user_name, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.hidden, 2, 7);
            this.tableLayoutPanel1.Controls.Add(this.photo, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.button2, 1, 11);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 12;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(413, 384);
            this.tableLayoutPanel1.TabIndex = 27;
            // 
            // pictureBox1
            // 
            this.pictureBox1.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.ezprofilesBindingSource, "photo", true));
            this.pictureBox1.Location = new System.Drawing.Point(253, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.tableLayoutPanel1.SetRowSpan(this.pictureBox1, 5);
            this.pictureBox1.Size = new System.Drawing.Size(146, 149);
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(4, 4);
            this.label13.Margin = new System.Windows.Forms.Padding(4);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(72, 16);
            this.label13.TabIndex = 6;
            this.label13.Text = "Full Name:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(4, 35);
            this.label14.Margin = new System.Windows.Forms.Padding(4);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(81, 16);
            this.label14.TabIndex = 6;
            this.label14.Text = "User Name:";
            // 
            // full_name
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.full_name, 2);
            this.full_name.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ezprofilesBindingSource, "full_name", true));
            this.full_name.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.full_name.Location = new System.Drawing.Point(104, 4);
            this.full_name.Margin = new System.Windows.Forms.Padding(4);
            this.full_name.Name = "full_name";
            this.full_name.Size = new System.Drawing.Size(295, 23);
            this.full_name.TabIndex = 2;
            // 
            // user_name
            // 
            this.user_name.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ezprofilesBindingSource, "user_name", true));
            this.user_name.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_name.Location = new System.Drawing.Point(104, 35);
            this.user_name.Margin = new System.Windows.Forms.Padding(4);
            this.user_name.Name = "user_name";
            this.user_name.Size = new System.Drawing.Size(132, 23);
            this.user_name.TabIndex = 2;
            // 
            // remoteDataSet
            // 
            this.remoteDataSet.DataSetName = "RemoteDataSet";
            this.remoteDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ezprofilesBindingSource
            // 
            this.ezprofilesBindingSource.DataMember = "Ez_profiles";
            this.ezprofilesBindingSource.DataSource = this.remoteDataSet;
            // 
            // ez_profilesTableAdapter
            // 
            this.ez_profilesTableAdapter.ClearBeforeFill = true;
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Profile";
            this.Size = new System.Drawing.Size(420, 391);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.remoteDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ezprofilesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox birth_date;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox mobile;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button photo;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.TextBox interests;
        private System.Windows.Forms.TextBox job;
        private System.Windows.Forms.ComboBox gender;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox hidden;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox full_name;
        private System.Windows.Forms.TextBox user_name;
        private System.Windows.Forms.BindingSource ezprofilesBindingSource;
        private EZTutor.Datasets.RemoteDataSet remoteDataSet;
        private EZTutor.Datasets.RemoteDataSetTableAdapters.Ez_profilesTableAdapter ez_profilesTableAdapter;
    }
}