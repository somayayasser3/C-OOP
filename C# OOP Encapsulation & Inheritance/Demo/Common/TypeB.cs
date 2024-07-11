using System;
using System.Collections.Generic;
using System.Text;

namespace Common
{
    internal class TypeB : TypeA
    {
        internal void Print()
        {
            //TypeA obj = new TypeA();
            //// obj.X = 10; // invalid (internal private like Private ) without inheritance 
            //// obj.Y = 20; //invalid
            //obj.Z = 40; // valid 
            //// obj.M = 30; // invalid
            //X = 10; // X is inherited As Private // X is private also in TypeB Class
            //Y = 20; // Y is inherited as Private 
            //Z = 30; // Z is inherited as internal
            // M = 40; // invalid // private is not inherited 
        }
    }
}
