using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Abstraction
{
    internal abstract class Shape
    {
        // Abstract Class: Partial Implementation to Another Class [Not Fully Implemented]
        // can't Create Object\Reference from Abstract Class like Interface
        public decimal Dim01 { get; set; }
        public decimal Dim02 { get; set; }

        public Shape(decimal dim01, decimal dim02) // We use it for create Object from Class [inherit & Implement] Abstract Class
        {
            Dim01 = dim01;
            Dim02 = dim02;
        }

        // Abstract Property  [Will not Generate Backing Field]
        public abstract decimal Perimeter{ get; }  // Read Only

        // Abstract Method -> Not Implemented 
        // Must be Contained inside Abstract Class
        // To prevent Create An Object From This Class as there is Functions Not Implemented

          public abstract decimal CalArea();
        //public decimal CalArea()  // it is only for Square and Rectangle but if we want another shape to implement this method with different Area Implementation
        //                          // So we need to make it abstract Method then make Class special for only Rectangle and Square  
        //                          // Class  As A [Layer] between this Classes
        //{
        //    return Dim01 * Dim02;
        //}
    }

    internal abstract class RectBase : Shape // Abstract: to avoid the [not implemented]  Abstract Property
                                             // Not Fully Implemented
                                             // then make Rectagle + Square Implement this Layer [RectBase]
    {
        public RectBase(decimal dim01, decimal dim02) : base(dim01, dim02)
        {

        }

        public override decimal CalArea()
        {
            return Dim01 * Dim02;
        }
    }

    // Class : Class ==> Inherit
    // Class : Interface ==> Implement
    // Class : Abstract ==> Inherit & Implement
    // Rectangle [Concrete Class] [Fully Implemeted Class] ==> Must Implement Method From the Class Shape
    // Rectangle [Concrete Class] ==> Implement Abstract Method Using Override Keyword 
    // Shape : Abstract Class
    internal class Rectangle : RectBase // Inherit & Implement
    {
        public Rectangle(decimal dim01, decimal dim02) : base(dim01, dim02)
        {
        }

        public override decimal Perimeter
        {
            get
            {
                return (Dim01 + Dim02) * 2;
            }
        }

        // Abstarct Method 
        // like Virtual Method in Class Inherited [ Implemented ] but in Abstract [Not Implemented]
        //public override decimal CalArea()
        //{
        //    return Dim01 * Dim02;
        //}
    }

    internal class Square : RectBase
    {
        public Square(decimal Dim) : base(Dim ,  Dim)
        {
            //Dim01 = Dim02 = Dim;
        }
        public override decimal Perimeter
        {
            get
            {
                return Dim01 * 4;
            }
        }

        //public override decimal CalArea()
        //{
        //    return Dim01 * Dim01;
        //}
    }

    // Rectangle + Square [Implement & Inherit] from RectBase
    // RectBase [Implement & Inherit] from Shape
    // Shape has 2 Abstract [Property (Perimeter) , Method (CalcArea)]
    // RectBase inherits & implements only CalcArea()
    // Rectangle inherits & Implements RectBase [Inherit CalcArea() , Implement Perimeter]
    // Square inherits & Implements RectBase [Inherit CalcArea() , Implement Perimeter]
    internal class Circle : Shape
    {
        public Circle(decimal Redius):base(Redius , Redius)
        {
            //Dim01 = Dim02 = Redius;
        }
        public override decimal Perimeter => 2 * 3.14M * Dim01; // Fat Arrow
        public override decimal CalArea()
        {
            return 3.14M * Dim01 * Dim01;
        }
    }
}
