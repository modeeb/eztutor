using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EZTutor.Data.Remote.Datasets;
using EZTutor.Data.Remote.Datasets.EZTutorDataSetTableAdapters;
using EZTutor.Data.Remote.Entities;
using EZTutor.Data.Remote.Domain;
using NHibernate;

namespace EZTutor.GUI.Controls
{
    public partial class TopicBrowser : UserControl
    {
        public TopicBrowser()
        {
            InitializeComponent();
        }

        private void TopicBrowser_Load(object sender, EventArgs e)
        {
            //Provider provider = new Provider();
            
            //provider.OpenSession();

            //var topics = session.CreateCriteria(typeof(Topics)).List<Topics>();

            TopicsTableAdapter topicsTableAdapter = new TopicsTableAdapter();

            EZTutorDataSet.TopicsDataTable topics = topicsTableAdapter.GetData();
            //dataGridView1.DataSource = topicsTableAdapter.GetData();

            TreeNode parent = treeView1.Nodes.Add("Topics");
            foreach (EZTutorDataSet.TopicsRow topic in topics)
            {
                parent.Nodes.Add(topic.TopicName);
            }
            treeView1.ExpandAll();
        }
    }
}
