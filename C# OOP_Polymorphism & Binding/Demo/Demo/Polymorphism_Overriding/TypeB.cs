using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Polymorphism_Overriding
{
    internal class TypeB : TypeA
    {
        public int B { set; get; }
        public TypeB(int a, int b) : base(a)
        {
            B = b;
        }

        #region Overriding
        // 1. Override: Public + Virtual [Function must be inherited]
        // Static Binding [Early Binding] // At Compilation Time 
        // Func01() --> Static Bounded Method 
        // Compiler will bind Function Call Based on Refernce Type not Object Type
        // 2. New

        // Function Override with New Keyword
        // Dynamic Bining [Run Time ] CLR [Late Binding]
        // Func02() ==> Dynamic Bounded Method
        // CLR will bind Function Call Based on Object Type not Reference Type
        public new void Func01() // New ==> New Version Of Func01() --> [Masking]
        {
            Console.WriteLine("I am Derived [Child]");
        }


        // Function Override with Override Keyword
        // Function must be inherited from parent [Public - Virtual Function] 
        public override void Func02()
        {
            Console.WriteLine($"TypeA: A = {A} , B = {B}");
            #endregion


        }
    }
}
