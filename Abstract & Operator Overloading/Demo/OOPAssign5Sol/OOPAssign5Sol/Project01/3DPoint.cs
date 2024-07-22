using System;
using System.Collections.Generic;
using System.Text;

namespace OOPAssign5Sol.Project01
{
    internal class _3DPoint:  ICloneable
    {

        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }

        public _3DPoint(int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public _3DPoint(int x, int y) : this(x, y, 0)
        {
            // In 2D
        }

        public _3DPoint():this(0 , 0 , 0)
        {
            // Origin 
            // Initailize Point
            // parameterless Constructor
        }

        public override string ToString()
        {
            return $"Point Coordinates: ({X} , {Y} , {Z})";
        }

        public object Clone()
        {
            return new _3DPoint(X , Y , Z);
        }

        public static bool operator == (_3DPoint p1 , _3DPoint p2)
        {
            return ((p1.X == p2.X) && (p1.Y == p2.Y) && (p1.Z == p2.Z));
        }

        public static bool operator != (_3DPoint p1, _3DPoint p2)
        {
            return ((p1.X != p2.X) || (p1.Y != p2.Y) || (p1.Z != p2.Z));
        }
    }
}
