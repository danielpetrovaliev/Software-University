using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Fraction_Calculator
{
    public struct Fraction
    {
        private long numerator;
        private long denominator;

        public long Numerator 
        {
            get { return this.numerator;}
            set { this.numerator = value;}
        }
        public long Denominator 
        {
            get { return this.denominator;}
            set 
            {
                if (value == 0)
                {
                    throw new ArgumentException("Denominator can not be zero");
                }
                this.denominator = value;
            }
        }

        // Constructor
        public Fraction(long numerator, long denominator) : this()
        {
            this.Numerator = numerator;
            this.Denominator = denominator;
        }

        public static Fraction operator +(Fraction firstfraction, Fraction secondfraction)
        {
            long newNumerator = firstfraction.Numerator * secondfraction.Denominator + firstfraction.Denominator * secondfraction.Numerator;
            long newDenominator = firstfraction.Denominator * secondfraction.Denominator;

            return new Fraction { Numerator = newNumerator, Denominator = newDenominator };
        }
        public static Fraction operator -(Fraction firstfraction, Fraction secondfraction)
        {
            long newNumerator = firstfraction.Numerator * secondfraction.Denominator - firstfraction.Denominator * secondfraction.Numerator;
            long newDenominator = firstfraction.Denominator * secondfraction.Denominator;

            return new Fraction { Numerator = newNumerator, Denominator = newDenominator };
        }

        public override string ToString()
        {
            decimal result = (decimal)this.Numerator / this.Denominator;

            return result.ToString();
        }
    }
}
