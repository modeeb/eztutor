namespace EZTutor.GUI.Controls
{
    partial class TopicBrowser
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
            this.topicsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eztutorDataSet = new EZTutor.GUI.eztutorDataSet();
            this.topicsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.topicsTableAdapter = new EZTutor.GUI.eztutorDataSetTableAdapters.TopicsTableAdapter();
            this.treeView1 = new System.Windows.Forms.TreeView();
            ((System.ComponentModel.ISupportInitialize)(this.topicsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eztutorDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topicsBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // topicsBindingSource
            // 
            this.topicsBindingSource.DataSource = typeof(EZTutor.Data.Remote.Entities.Topics);
            // 
            // eztutorDataSet
            // 
            this.eztutorDataSet.DataSetName = "eztutorDataSet";
            this.eztutorDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // topicsBindingSource1
            // 
            this.topicsBindingSource1.DataMember = "Topics";
            this.topicsBindingSource1.DataSource = this.eztutorDataSet;
            // 
            // topicsTableAdapter
            // 
            this.topicsTableAdapter.ClearBeforeFill = true;
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(12, 4);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(387, 229);
            this.treeView1.TabIndex = 0;
            // 
            // TopicBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.treeView1);
            this.Name = "TopicBrowser";
            this.Size = new System.Drawing.Size(412, 236);
            this.Load += new System.EventHandler(this.TopicBrowser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.topicsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eztutorDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.topicsBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource topicsBindingSource;
        private System.Windows.Forms.BindingSource topicsBindingSource1;
        private eztutorDataSet eztutorDataSet;
        private EZTutor.GUI.eztutorDataSetTableAdapters.TopicsTableAdapter topicsTableAdapter;
        private System.Windows.Forms.TreeView treeView1;

    }
}
