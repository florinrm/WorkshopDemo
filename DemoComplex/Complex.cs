using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoComplex
{
    public class Complex
    {

        public Complex(double real, double imaginary)
        {
            Real = real;
            Imaginary = imaginary;
        }

        public double Real
        {
            get; set;
        }

        public double Imaginary
        {
            get;
            set;
        }

        public override string ToString()
        {
            string result = "";

            if (Real >= 0)
            {
                result += Real;
            }
            else
            {
                result += "(" + Real + ")";
            }

            result += " + i * ";

            if (Imaginary >= 0)
            {
                result += Imaginary;
            }
            else
            {
                result += "(" + Imaginary + ")";
            }

            return result;
        }

        public static Complex operator +(Complex c1, Complex c2)
        {
            return new Complex(c1.Real + c2.Real, c1.Imaginary + c2.Imaginary);
        }

        public static Complex operator -(Complex c1, Complex c2)
        {
            return new Complex(c1.Real - c2.Real, c1.Imaginary - c2.Imaginary);
        }

        public static Complex operator *(Complex c1, Complex c2)
        {
            return new Complex(c1.Real * c2.Real - c1.Imaginary * c2.Imaginary,
                c1.Real * c2.Imaginary + c1.Imaginary * c2.Real);
        }

        public static Complex operator /(Complex c1, Complex c2)
        {
            double numitor = c2.Real * c2.Real + c2.Imaginary * c2.Imaginary;

            return new Complex((c1.Real * c2.Real + c1.Imaginary * c2.Imaginary) / numitor,
                (c2.Real * c1.Imaginary - c2.Imaginary * c1.Real) / numitor);
        }

        public override bool Equals(object obj)
        {
            Complex c = obj as Complex;
            if (c == null)
                return false;
            else
                return Equals(Real, c.Real) && Equals(Imaginary, c.Imaginary);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
