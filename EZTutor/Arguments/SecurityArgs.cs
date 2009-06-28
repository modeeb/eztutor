using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EZTutor.Enums;

namespace EZTutor.Arguments
{
    public class SecurityArgs : EventArgs
    {
        public UserType UserType;

        public string UserName;
    }
}
