using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EZTutor.Enums;

namespace EZTutor.Arguments
{
    public class MenuArgs : EventArgs
    {
        public FormType FormType;
        public string ContentName;
    }
}
