using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using EZTutor.GUI.Arguments;

namespace EZTutor.GUI.Controls
{
    public partial class MainBrowser : UserControl
    {
        private Slides slides;

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
            topicBrowser1.Expand(200);
            lectureBrowser1.Collapse();
        }

        private void ShowByLecture()
        {
            lectureBrowser1.Expand(200);
            topicBrowser1.Collapse();
        }

        private void NodeClicked(object sender, MenuArgs args)
        {
            if (slides == null)
            {
                slides = new Slides();
            }

            Controls.Add(slides);
            slides.BringToFront();
        }
    }
}