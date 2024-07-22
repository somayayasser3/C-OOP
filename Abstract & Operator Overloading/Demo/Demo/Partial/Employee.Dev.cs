using Demo.Sealed;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Partial
{
    internal partial class Employee //: Child // invalid // Multi Inheritance
    {
        public void Print()
        {
            Console.WriteLine("I am Employee.");
        }

        public int Test { get; set; }

        //public partial void TestMethod()
        //{
        //    Console.WriteLine("Somaya");
        //}
    }
}
