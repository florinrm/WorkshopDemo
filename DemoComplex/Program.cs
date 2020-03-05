using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoComplex
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Complex c1 = new Complex(8, -4);
            Console.WriteLine(c1);
            Complex c2 = new Complex(2, 4);
            Console.WriteLine(c2);

            Console.WriteLine(c1 + c2);
            Console.WriteLine(c1 - c2);
            Console.WriteLine(c1 * c2);
            Console.WriteLine(c1 / c2);
        }
    }
}
