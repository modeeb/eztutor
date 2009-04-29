using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EZTutor.GUI.Enums;

namespace EZTutor.GUI.Arguments
{
    public class MenuArgs : EventArgs
    {
        public FormType FormType;
        public string ContentName;
    }
}
