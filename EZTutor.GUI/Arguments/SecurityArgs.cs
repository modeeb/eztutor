using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EZTutor.GUI.Enums;

namespace EZTutor.GUI.Arguments
{
    public class SecurityArgs : EventArgs
    {
        public UserType UserType;

        public string UserName;
    }
}
