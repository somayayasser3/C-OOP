//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace Demo.Interfaces
//{
//    // Default Access Modifier of Interface => Internal
//    interface IMyType // Public, Internal
//    {
//        // Default Access Modifier Inside Interface => Public
//        // Private Access Modifier is not allowed inside interface

//        // What You Can Write Inside The Interface
//        // 1. Signature for Property [Name - Type - [Set|Get]]
//        public int Id { get; set; }
//        // Inside Class, Struct   ==>  Automatic Property
//        // Compiler will Generate Private hidden Attribute [Backing Field]  

//        // Inside Interface ==> Signature for Property


//        // 2. Signature for Method [Name - Return Type - Parameters]
//        public void MyFun(int X); // Can't be private 

//        // 3. Default Implemented Method [C# 8 Feature - .Net Core 3.1 2019]

//        public void Print()
//        {
//            Console.WriteLine("Hello Default Implemented Method From Interface.");
//        }

//    }
//}
