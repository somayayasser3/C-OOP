using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Polymorphism_Overriding
{
    internal class TypeD : TypeC
    {
        // TypeA ==> InDirect Parent
        // TypeB ==> InDirect Parent
        // TypeC ==> Direct Parent
        public int D { get; set; }

        public TypeD(int a, int b, int c, int d):base(a,b,c)
        {
            D = d;
        }

        public new void Func01()
        {
            Console.WriteLine("I am Derived [Child Of Grand Child.]");
        }

        // Func02 ==> Public Virtual
        // New ==> End Sequence
        // Virtual ==> Start New Sequence
        public new virtual void Func02()
        {
            Console.WriteLine($"TypeD: A = {A} , B = {B} , C = {C} , D = {D}");
        }
    }
}
