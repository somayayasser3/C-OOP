using System;
using System.Collections.Generic;
using System.Text;

namespace OOPAssign4Sol
{
    internal class Rectangle : IRectangle
    {
        public decimal Area {get ; set ; }

        public void DiplayShapeInfo()
        {
            Console.WriteLine($"The Area of Rectangle = {Area}");
        }
    }
}
