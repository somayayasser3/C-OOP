using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Polymorphism_Overriding
{
    internal class TypeA
    {
        public int A { set; get; }
        // Automatic Property
        // Compiler will Generate Hidden Private Attribute ==> Backing Field

        public TypeA(int a)
        {
            A = a;
        }

        // Non Static Method
        public void Func01()
        {
            Console.WriteLine("I am [Base] Parent Class.");
        }

        public virtual void Func02()
        {
            Console.WriteLine($"TypeA: A = {A}");
        }
    }
}
