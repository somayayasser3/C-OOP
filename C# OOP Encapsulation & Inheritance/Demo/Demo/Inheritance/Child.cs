using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Inheritance
{
    internal class Child : Parent
    {
        public int Z { get; set; }

        public Child(int x , int y , int z) : base(x,y)
        {
            Z = z;
        }

        public override string ToString()
        {
            return $"X: {X} , Y: {Y}, Z: {Z}";
        }

        public /*override*/ new int Product() // new: make a new version from inherited Method (Product Method) | Hide
        {
            return /*X * Y **/ base.Product() * Z; // to get the parent of this class and add on it 
            // base of parent ==> object
            // new:
            // override: in Polymerphism 
            // override ==> inheritance
            // in C# ==> there is no Multi Inheritance
        }
    }
}
