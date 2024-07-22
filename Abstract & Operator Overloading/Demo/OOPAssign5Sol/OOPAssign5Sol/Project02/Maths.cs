using System;
using System.Collections.Generic;
using System.Text;

namespace OOPAssign5Sol.Project02
{
    internal static class Maths
    {
        public static double Add(double Left, double Right)
        {
            return Left + Right;
        }

        public static double Subtract(double Left, double Right)
        {
            return Left - Right;
        }

        public static double Multiply(double Left, double Right)
        {
            return Left * Right;
        }

        public static double Divide(double Left, double Right)
        {
            if(Right == 0)
            {
                Console.WriteLine("Divide By Zero is not allowed");
                // throw new DivideByZeroException();
            }
            return (double)Left / Right;
        }
    }
}
