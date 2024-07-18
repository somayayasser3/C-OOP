//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace Demo.Interfaces
//{
//    // Interface is a Code Contract Between 2 Developers 

//    // Class : Class ==> inherit
//    // Class : Interface ==> Implement
//    // Struct : Interface ==> Implement
//    // Interface : Interface ==> Inherit

//    // Interface Can Be Implemented Through Class Or Struct
//    internal class MyType : IMyType // --> Implement without any change in its Signature
//    {
//        //// Full Property
//        //private int id;
//        //public int Id
//        //{
//        //    get { return id; }
//        //    set { id = value; }
//        //}
//        public int Id { get ; set ; } // Automatic Property
//                                      // Compiler will Generate Private hidden Attribute [Backing Field] 
//                                      // if Property has get, set ==> the Class must implement it with get , set
//                                      // we can add set or get not remove from interface

//        // Non Static Function [Object Member Function]
//        public void MyFun()
//        {
//            Console.WriteLine($"Hello Somaya , X: {X}, ID = {Id}");
//        }

//        public void Print()
//        {
//            throw new NotImplementedException();
//        }
//    }
//}
