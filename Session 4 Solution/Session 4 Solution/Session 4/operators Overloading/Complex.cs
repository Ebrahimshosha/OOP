using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_4.operators_Overloading
{
    internal class Complex
    {
        public int Real { get; set; }
        public int Imag { get; set; }

        #region Operators overloading

        // Operator overloading : Public Class Member Method
        public static Complex operator +(Complex left, Complex right)
        {
            return new Complex
            {
                Real = (left?.Real ?? 0) + (right?.Real ?? 0),
                Imag = (left?.Imag ?? 0) + (right?.Imag ?? 0)

            };
        }
        public static Complex operator -(Complex left, Complex right)
        {
            return new Complex
            {
                Real = (left?.Real ?? 0) - (right?.Real ?? 0),
                Imag = (left?.Imag ?? 0) - (right?.Imag ?? 0)

            };
        }
        public static Complex operator ++(Complex C)
        {
            if (C is not null)
            {
                C.Real++;
            }
            return C;

            //return new Complex
            //{
            //    Real = C?.Real ?? 0 + 1,
            //    Imag = C.Imag
            //};
        }
        public static bool operator >(Complex left, Complex right)
        {
            if (left.Real == right.Real)
                return left.Imag > right.Imag;
            else
                return left.Real > right.Real;
            
        }
        public static bool operator <(Complex left, Complex right)
        {
            if (left.Real == right.Real)
                return left.Imag < right.Imag;
            else
                return left.Real < right.Real;

        }

        public static /*int*/ explicit operator int (Complex C)
        {
            return C.Real;
        }

        public static /*string*/ implicit operator string (Complex C)
        {
            return C?.ToString()??string.Empty;
        }

        #endregion

        public override string ToString()
        {
            return $"{Real} + {Imag}i";
        }
    }
}
