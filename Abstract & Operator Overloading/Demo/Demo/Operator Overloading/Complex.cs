using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Operator_Overloading
{
    internal class Complex
    {
        public int Real { get; set; }
        public int Imag { get; set; }
        public override string ToString()
        {
            return $"{Real} + {Imag}i";
        }

        // +
        // Non - Private Method 
        // Class Member Method [Static]
        #region Binary Operator Overloading
        public static Complex operator + (Complex Left, Complex Right)
        {
            return new Complex()
            {
                Real = (Left?.Real ?? 0) + (Right?.Real ?? 0), // Null Coaleasing Operator Occures after + 
                Imag = (Left?.Imag ?? 0) + (Right?.Imag ?? 0)
            };
        }

        // -
        // Non - Private Method 
        // Class Member Method [Static]
        public static Complex operator - (Complex Left, Complex Right)
        {
            return new Complex()
            {
                Real = (Left?.Real ?? 0) - (Right?.Real ?? 0), // Null Coaleasing Operator Occures after + 
                Imag = (Left?.Imag ?? 0) - (Right?.Imag ?? 0)
            };
        }
        #endregion

        #region Unary Operator Overloading
        public static Complex operator ++ (Complex C1)
        {
            return new Complex()
            {
                Real = (C1?.Real ?? 0) + 1,
                Imag = (C1?.Imag ?? 0) + 1
            };
        }

        public static Complex operator -- (Complex C1)
        {
            return new Complex()
            {
                Real = (C1?.Real ?? 0) - 1,
                Imag = (C1?.Imag ?? 0) - 1
            };
        }
        #endregion

        #region Relational Operator
        public static bool operator > (Complex Left, Complex Right)
        {
            if (Left.Real == Right.Real)
                return (Left.Imag > Right.Imag);
            else
                return (Left.Real > Right.Real) ;
        }
        // In Relational Operator , there is Coupling (Matching)
        // > , <
        // >= , <=
        // == , !=
        public static bool operator < (Complex Left, Complex Right)
        {
            if (Left.Real == Right.Real)
                return (Left.Imag < Right.Imag);
            else
                return (Left.Real < Right.Real);
        }

        #endregion

        #region Casting Operator Overloading
        // Explicit ==> Explicit Only (Recommended)
        // Implicit ==> (Implicit + Explicit)
        public static explicit operator int (Complex Num)
        {
            return Num?.Real ?? 0;
        }

        public static implicit operator string(Complex Num)
        {
            return Num?.ToString() ?? string.Empty;
        }
        #endregion
    }
}
