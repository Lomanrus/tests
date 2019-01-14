using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fraction
{
    public class Fraction
    {
        int numerator;
        int denominator;

        public Fraction(int numerator, int denominator)
        {
            this.numerator = numerator;
            this.denominator = denominator;
        }

        public static Fraction Add(Fraction a, Fraction b)
        {
            Fraction c = new Fraction(a.numerator * b.denominator + a.denominator * b.numerator,
                a.denominator * b.denominator);
            return c;
        }

        public static Fraction Sub(Fraction a, Fraction b)
        {
            Fraction c = new Fraction(a.numerator * b.denominator - a.denominator * b.numerator,
                a.denominator * b.denominator);
            return c;
        }

        public static Fraction SetFormat(Fraction t)
        {
            double max = 0;


            if (t.numerator > t.denominator)
                max = Math.Abs(t.denominator);
            else
                max = Math.Abs(t.numerator);
            for (double i = max; i >= 2; i--)
            {
                if ((t.numerator % i == 0) & (t.denominator % i == 0))
                {
                    t.numerator = Convert.ToInt32(t.numerator / i);
                    t.denominator = Convert.ToInt32(t.denominator / i);
                }

            }
            return t;
        }
        public static double GetDouble(Fraction a)
        {
            double d = (double)a.numerator / (double)a.denominator;
            string s = String.Format("{0:#.##}", d);

            return double.Parse(s);
        }

        public static Fraction Mul(Fraction a, Fraction b)
        {
            Fraction c = new Fraction(a.numerator * b.numerator, a.denominator * b.denominator);
            return c;

        }

        public override bool Equals(object obj)
        {
            var toCompareWith = obj as Fraction;
            if (toCompareWith == null)
                return false;
            return this.numerator == toCompareWith.numerator &&
                   this.denominator == toCompareWith.denominator;
        }
    }
}
