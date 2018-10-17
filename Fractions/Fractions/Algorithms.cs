using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fractions
{
    class Algorithms
    {
        public static int Gcd (int a, int b)
        {
            int r;
            a = Math.Abs(a);
            b = Math.Abs(b);
            do
            {
                r = a % b;
                a = b;
                b = r;
            } while (r != 0);

            return a;
        }

        public static int Lcm (int a, int b)
        {
            return (a * b) / Gcd(a, b);
        }
    }
}
