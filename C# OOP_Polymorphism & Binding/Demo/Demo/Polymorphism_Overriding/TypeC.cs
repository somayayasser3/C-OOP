using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Polymorphism_Overriding
{
    internal class TypeC : TypeB
    {

        // TypeC ==> Direct Parent [TypeB]
        // TypeC ==> InDirect Parent [TypeA]
        public int C { get; set; }
        public TypeC(int a, int b, int c) :base(a , b )
        {
            C = c;
        }

        public new void Func01()
        {
            Console.WriteLine("I am Derived [Grand Child]");
        }

        public override void Func02()
        {
            Console.WriteLine($"TypeC: A = {A} , B = {B} , C = {C}");
        }
    }
}
