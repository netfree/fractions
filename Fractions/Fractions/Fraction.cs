using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fractions
{
    class Fraction
    {
        private int _numerator;
        private int _denominator;

        public int Numerator
        {
            get
            {
                return _numerator;
            }
            set
            {
                _numerator = value;
            }
        }
        public int Denominator
        {
            get
            {
                return _denominator;
            }
            set
            {
                if(value != 0)
                    _denominator = value;
            }
        }

        public Fraction()
        {
            Numerator = 1;
            Denominator = 1;
        }

        public Fraction(int a, int b)
        {
            Numerator = a;
            Denominator = b;
        }

        public void Reduction()
        {
            int gcd = Algorithms.Gcd(Numerator, Denominator);
            Numerator /= gcd;
            Denominator /= gcd;
        }

        public static Fraction operator+ (Fraction a, Fraction b)
        {
            a.Reduction(); b.Reduction();
            var c = new Fraction();

            int lcm = Algorithms.Lcm(a.Denominator, b.Denominator);
            c.Denominator = lcm;
            c.Numerator = (lcm / a.Denominator) * a.Numerator + (lcm / b.Denominator) * b.Numerator;
            c.Reduction();
            return c;
        }

        public override string ToString()
        {
            return "(" + this.Numerator.ToString() + ")/(" + this.Denominator.ToString() + ")";
        }
    }
}
