using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EZTutor.Arguments;
using EZTutor.Datasets;
using EZTutor.Datasets.RemoteDataSetTableAdapters;
using EZTutor.Enums;

namespace EZTutor.Controls.Browsers
{
    public partial class TopicBrowser : CollapsedControl
    {
        public delegate void NodeClickedHandler(object sender, MenuArgs args);

        public NodeClickedHandler NodeClicked;

        public TopicBrowser()
        {
            InitializeComponent();
        }

        private void TopicBrowser_Load(object sender, EventArgs e)
        {
            //Provider provider = new Provider();
            
            //provider.OpenSession();

            //var topics = session.CreateCriteria(typeof(Topics)).List<Topics>();

            Ez_topicsTableAdapter topicsTableAdapter = new Ez_topicsTableAdapter();

            RemoteDataSet.Ez_topicsDataTable topics = topicsTableAdapter.GetData();

            TreeNode parent = treeView1.Nodes.Add("Topics");
            foreach (RemoteDataSet.Ez_topicsRow topic in topics)
            {
                parent.Nodes.Add(topic.topic_title);
            }
            treeView1.ExpandAll();
        }

        private void OnNodeClicked(object sender, MenuArgs args)
        {
            if (NodeClicked != null)
            {
                NodeClicked(sender, args);
            }
        }

        private void treeView1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            OnNodeClicked(sender, new MenuArgs { FormType = FormType.Slides, ContentName = e.Node.Text });
        }
    }
}