using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Polymorphism_Overriding
{
    // TypeA ==> InDirect Parent
    // TypeB ==> InDirect Parent
    // TypeC ==> InDirect Parent
    // TypeD ==> Direct Parent
    internal class TypeE : TypeD
    {
        public int E { get; set; }

        public TypeE(int a,  int b, int c, int d, int e):base(a , b , c , d)
        {
            E = e;
        }

        // In TypeD Func02 public new ==> You Can't Overriding Using KeyWord Override
        // In TypeD Func02 public new Virtual ==> You Can Overriding Using KeyWord Override [New Sequence]
        public override void Func02()
        {
            Console.WriteLine($"TypeD: A = {A} , B = {B} , C = {C} , D = {D} , E = {E}");
        }
    }

}

