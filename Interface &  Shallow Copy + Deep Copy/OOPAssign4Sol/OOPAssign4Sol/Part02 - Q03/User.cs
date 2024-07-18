using System;
using System.Collections.Generic;
using System.Text;

namespace OOPAssign4Sol.Part02___Q03
{
    public enum Role
    {
        Admin = 10,
        Editor = 20,
        Viewer = 30
    }
    internal class User
    {
        public string Name;
        public string Password;
        public Role role { get; set; }
    }
}
