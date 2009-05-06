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
//using EZTutor.Data.Remote.Domain;
using EZTutor.GUI.Enums;
using EZTutor.GUI.Arguments;

namespace EZTutor.GUI.Controls.Browsers
{
    public partial class LectureBrowser : CollapsedControl
    {
        public delegate void NodeClickedHandler(object sender, MenuArgs args);

        public NodeClickedHandler NodeClicked;

        public LectureBrowser()
        {
            InitializeComponent();
        }

        private void LectureBrowser_Load(object sender, EventArgs e)
        {
            //Provider provider = new Provider();
            
            //provider.OpenSession();

            //var topics = session.CreateCriteria(typeof(Topics)).List<Topics>();

            LecturesTableAdapter lecturesTableAdapter = new LecturesTableAdapter();

            EZTutorDataSet.LecturesDataTable lectures = lecturesTableAdapter.GetData();
            //dataGridView1.DataSource = topicsTableAdapter.GetData();

            TreeNode parent = treeView1.Nodes.Add("Lectures");
            foreach (EZTutorDataSet.LecturesRow topic in lectures)
            {
                parent.Nodes.Add(topic.LectureName);
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