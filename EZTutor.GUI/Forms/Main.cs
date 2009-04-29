using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EZTutor.GUI.Arguments;
using EZTutor.GUI.Controls;
using EZTutor.GUI.Enums;

namespace EZTutor.GUI.Forms
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        public Main(SecurityArgs args) : this()
        {
            UserType = args.UserType;
            UserName = args.UserName;
        }

        public string UserName { get; set; }

        public UserType UserType { get; set; }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (UserType == UserType.Student)
            {
                studentMenu1.Expand(263);
                studentMenu1.UserName = UserName;
                studentMenu1.MenuItemClicked = new StudentMenu.MenuItemClickedHandler(MenuClickedHandler);
                instructorMenu1.Collapse();
            }
            else
            {
                instructorMenu1.Expand(263);
                instructorMenu1.UserName = UserName;
                studentMenu1.MenuItemClicked = new StudentMenu.MenuItemClickedHandler(MenuClickedHandler);
                studentMenu1.Collapse();
            }
        }

        private void MenuClickedHandler(object sender, MenuArgs args)
        {
            switch (args.FormType)
            {
                case FormType.Home:
                    MainBrowser browser = new MainBrowser();
                    panel1.Controls.Add(browser);
                    browser.Dock = DockStyle.Fill;
                    break;
                case FormType.Profile:
                    Profile profile = new Profile();
                    panel1.Controls.Add(profile);
                    profile.Dock = DockStyle.Fill;
                    break;
            }
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox about = new AboutBox();
            about.Show(this);
        }
    }
}