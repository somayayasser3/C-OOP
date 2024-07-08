using System;
using System.Collections.Generic;
using System.Text;

namespace OPPDemo1
{
    internal struct Point
    {
        #region What You Can Write Inside The Struct 

        // 1. Attributes[Fields] => Member Variable 
        #region Attributes
        public int X;
        public int Y;
        #endregion
        // 2. Functions[Constructor, Getter Setter, Method]
        #region  Constructors

        // Constructor 
        // Special Type Of Functions
        // 1. always its name is the Same of  its Class or its Struct
        // 2. No Return 
        // resposible for initialize the values of Atrributes

        // By Default ==> Compiler will always generate Parameterless Constuctor
        // That initialize Attributes of Struct with Default value of its Datatype
        //public Point()
        //{
        //    X = 1;
        //    Y = 2;
        //    // Valid from C#10 .Net 6
        //}

        // User Defined Constructor
        public Point( int _X, int _Y)
        {
            this.X = _X;
            this.Y = _Y;
        }

        // Multiple Constuctor --> Constructor Overloading

        public Point(int Number)
        {
            this.X = this.Y = Number;
        }
        #endregion

        #region Method
        public override string ToString() // Override on the Methods for Struct to Change Behaviour with this data type 
        {
            return $"({this.X} , {this.Y})"; // this --> Caller --> P1
        }
        #endregion



        // 3. Properties[Full Property, Automatic Property, Indexer]
        // 4. Events
        #endregion

        #region Access Modifier Allowed Inside Struct?
        // 1. Private[Default]
        // 2. Internal
        // 3. Public
        // Protected is't Allowed as Struct doesn't Support inheritance
        #endregion





    }
}
