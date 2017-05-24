using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fraction
{
    public class Fraction : IComparable<Fraction>
    {
        private double numerator { get; set; }
        private double denominator { get; set; }
        //public double fractionResult { get; set; }
        public double Numerator
        {
            get { return numerator; }
            set { numerator = value; }
        }
        public double Denominator
        {
            get { return denominator; }
            set
            {
                if (value != 0)
                {
                    denominator = value;
                }
                else
                {
                    throw new ArithmeticException();
                }
            }
        }

        public Fraction(double a, double p)
        {
            
                this.numerator = a;
                this.denominator=p;
            
        }

        public override string ToString()
        {
            return $"{numerator} / {denominator}";
        }

        public static Fraction operator *(Fraction x ,Fraction y)
        {
            return new Fraction ((x.numerator * y.numerator) , (x.denominator * y.denominator) );
        }

        public static Fraction operator *(double x, Fraction y)
        {
            double num = x * y.Numerator;
            double den = y.Denominator;
            return new Fraction(num, den);
        }

        public static Fraction operator *(Fraction x, double y)
        {
            double num = y * x.Numerator;
            double den = x.Denominator;
            return new Fraction(num, den);
        }

        public static Fraction Parse (string c)
        {
            char[] delimiterChars = { '/'};            
            
            string[] words = c.Split(delimiterChars);

            double g=double.Parse(words[0]);
            double l=double.Parse(words[1]);

            if (double.Parse(words[1]) != 0)
            { }
               return new Fraction(g, l);
        }
        public decimal d {
            get
            {
                return  ((decimal)numerator )/( (decimal)denominator);
            }
                       
        }
        

        static double GCD(double a, double b)
        {
            return b == 0 ? a : GCD(b, a % b);
        }

        public void cancel()
        {
            if (denominator < 0)
            {
                numerator = -numerator;
                denominator = -denominator;
            }

            double gcd_ab = GCD( numerator,  denominator);
            numerator = numerator / gcd_ab;
            denominator = denominator / gcd_ab;
        }

     //  public void Cancel()
     //  {
     //      int  min = (int) Math.Min(this.Numerator, this.Denominator);
     //      for (int i = min; i >= 2; i--)
     //      {
     //          if ((this.Numerator % i)==0 && (this.Denominator % i) == 0)
     //          {
     //              this.Numerator /= i;
     //              this.Denominator /= i;
     //          }
     //      }
     //  }
     

        public int CompareTo(Fraction other)
        {
            if ((this.numerator / this.denominator) > (other.numerator / other.numerator))
            {
                return +1;
            }
            else if ((this.numerator / this.denominator) < (other.numerator / other.numerator))
            {
                return -1;
            }
            else
            {
                return 0;
            }
            
        }

        public static List<Fraction> Parsemulti(string c)
        {
            List<Fraction> output = new List<Fraction>();
            char[] delimiterChars = {',','/'};

            string[] words = c.Split(delimiterChars);
            foreach (string word in words)
            {
                output.Add(Fraction.Parse(word));
            }
            return output;
            
        }
    }
      
}