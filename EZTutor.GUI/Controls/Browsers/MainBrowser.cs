using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using EZTutor.GUI.Arguments;
using EZTutor.GUI.Controls.Content;

namespace EZTutor.GUI.Controls.Browsers
{
    public partial class MainBrowser : UserControl
    {
        private Control slides;

        public MainBrowser()
        {
            InitializeComponent();
        }

        private void MainBrowser_Load(object sender, EventArgs e)
        {
            ShowByTopic();
            topicBrowser1.NodeClicked = new TopicBrowser.NodeClickedHandler(NodeClicked);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowByTopic();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ShowByLecture();
        }

        private void ShowByTopic()
        {
            lectureBrowser1.Collapse();
            freeSearch1.Collapse();
            topicBrowser1.Expand(200);
        }

        private void ShowByLecture()
        {
            topicBrowser1.Collapse();
            freeSearch1.Collapse();
            lectureBrowser1.Expand(200);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lectureBrowser1.Collapse();
            topicBrowser1.Collapse();
            freeSearch1.Expand(150);
        }

        private void NodeClicked(object sender, MenuArgs args)
        {
            if (slides == null)
            {
                slides = new LinkedList();
            }

            Parent.Controls.Add(slides);
            slides.BringToFront();
        }
    }
}