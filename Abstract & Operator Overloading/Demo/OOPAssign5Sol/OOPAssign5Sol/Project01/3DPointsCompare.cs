using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace OOPAssign5Sol.Project01
{
    internal class _3DPointsCompare : IComparer<_3DPoint>
    {
        public int Compare(_3DPoint P1, _3DPoint P2)
        {
            if (P1.X.CompareTo(P2.X) != 0 )
            {
                return P1.X.CompareTo(P2.X);
            }
            else if(P1.Y.CompareTo(P2.Y) != 0)
            {
                return P1.Y.CompareTo(P2.Y);
            }
            return P1.Z.CompareTo(P2.Z);


        }
    }
}
