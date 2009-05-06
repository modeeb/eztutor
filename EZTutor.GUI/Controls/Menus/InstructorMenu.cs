using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EZTutor.GUI.Arguments;
using EZTutor.GUI.Enums;

namespace EZTutor.GUI.Controls.Menus
{
    public partial class InstructorMenu : CollapsedControl
    {
        public delegate void MenuItemClickedHandler(object sender, MenuArgs args);

        public MenuItemClickedHandler MenuItemClicked;

        public InstructorMenu()
        {
            InitializeComponent();
        }

        public string UserName
        {
            set
            {
                label2.Text = value;
            }
        }

        private void OnMenuItemClicked(object sender, MenuArgs args)
        {
            if (MenuItemClicked != null)
            {
                MenuItemClicked(sender, args);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OnMenuItemClicked(sender, new MenuArgs { FormType = FormType.Home });
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OnMenuItemClicked(sender, new MenuArgs { FormType = FormType.Profile });
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OnMenuItemClicked(sender, new MenuArgs { FormType = FormType.Updates });
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OnMenuItemClicked(sender, new MenuArgs { FormType = FormType.Ask });
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OnMenuItemClicked(sender, new MenuArgs { FormType = FormType.Contact });
        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OnMenuItemClicked(sender, new MenuArgs { FormType = FormType.Answer });
        }
    }
}