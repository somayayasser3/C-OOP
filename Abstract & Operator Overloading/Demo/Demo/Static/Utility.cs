using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Static
{
    // Helper Class
    // Static Class: Container For Static Member [Property, Method, Constructor, Attribute] + Constant
    // Can Not Create Object From Static Class
    // Can Not Be Inherited

    internal static class Utility
    { 
        //public int X { get; set; }
        //public int Y { get; set; }

        // Object Member Attribute
        // Convert it to Class Member Attribute
        // Complier Always Intialize Static Attribute with default of data type[0]
        //private readonly static double pi /*= 3.14*/ ;

        // Object Member Property
        //  Convert it to Class Member Property [Static Property]
        // Must be {Get, Set}
        // 1. Static Attribute
        // 2. Constant
        public static double  PI
        {
            get { return pi; }
            // set { pi = value; }
        }

        // Object Member Constructor
        // Non - Static Constructor is not the Right Place to Initialize Static Attribute
        //public Utility(int x, int y)
        //{
        //    X = x;
        //    Y = y;
        //    // pi = 3.14;
        //}

        // Class Member Constructor
        // Static Constructor
        // 1. Static Constructor[Maximum Onl One Static Constructor Per Class].
        // 2. Can't Specify Access Modifiers or Parameters for Static Constructor .
        // 3. Will be Executed Just Only One Time Per Class Lifetime Before the first Usage of Class.

        // Usages Of Class
        //  1. Call Static Method or Static Property
        //  2. Create Object From This Class
        //  3. Create Object From Another Class Inheriting From This Class
        //static Utility()
        //{
        //    //  Used for Initialize Static Attribute
        //    pi = 3.14;
        //}

        // Constant
        private const double pi = 3.14;

        //public override string ToString()
        //{
        //    return $"X: {X} , Y: {Y}";
        //}

        // CM TO INCH
        // Object Member Function
        // Non Static Function

        // Convert it to Class Member Method
        // Static Method
        public static double CmToInch(double cm)
        {
            return cm / 2.54;
        }

        public static double CalcCircleArea(double R)
        {
            // PI is an Object Member Property
            // Can not be Used inside Static Method
            // To Use it, Create Object from Class in this Method
            // Then Use it for PI
            //Utility U01 = new Utility( 10 , 20 ); // The same of U02
            //Utility U02 = new Utility(100, 200); // So we make it Static Property
            return Utility.PI * R * R;
        }

    }
}
