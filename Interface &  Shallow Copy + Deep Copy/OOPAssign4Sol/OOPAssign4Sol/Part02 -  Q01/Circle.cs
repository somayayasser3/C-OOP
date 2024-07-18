using System;
using System.Collections.Generic;
using System.Text;

namespace OOPAssign4Sol
{
    internal class Circle : ICircle
    {
        public decimal Area { get; set; }

        public void DiplayShapeInfo()
        {
            Console.WriteLine($"The Area of the Circle = {Area}");
        }
    }
}
