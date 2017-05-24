using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseComplex
{
    public class Complex
    {
        private double Re;
        private double Im;

        public double Real
        {
            get { return Re; }
            set { Re = value; }
        }

        public double Imagin
        {
            get { return Im; }
            set { Im = value; }
        }

        public Complex()
        {
            Re = 0;
            Im = 0;
        }
        public Complex (double x, double y)
        {
            this.Re = x;
            this.Im = y;
        }

        public static Complex Add (Complex x, Complex y)
        {
            var re = x.Re + y.Re;
            var im = x.Im + y.Im;
            return new Complex(re, im);
        }

        public  Complex Add (Complex x)
        {
            var re = this.Re + x.Re;
            var im = this.Im + x.Im;
            return new Complex(re, im);
        }

        public static Complex operator +(Complex x, Complex y)
        {
            return new Complex(x.Re + y.Re, x.Im + y.Im);
        }


        public static Complex operator -(Complex x, Complex y)
        {
            return new Complex(x.Re - y.Re, x.Im - y.Im);
        }


        public static Complex operator *(Complex x, Complex y)
        {

        double a = (x.Re) * (y.Re);
        double b = (-((x.Im) * (y.Im)));
        double c = ((x.Re) * y.Im) + ((y.Re) * x.Im);
            return new Complex (a + b, c);
        }

        public static Complex divide(Complex z, Complex g)
        {
        double a = (((z.Re) * (g.Re)) - ((z.Im) * (g.Im))) / ((Math.Pow(g.Re, 2)) - ((Math.Pow(g.Im, 2))));
        double b = (((z.Re) * (g.Im)) + ((g.Re) * (z.Im))) / ((Math.Pow(g.Re, 2)) - ((Math.Pow(g.Im, 2))));
        return new Complex(a, b);
        }

        public double Norm
        {
            get { return Math.Sqrt(Math.Pow(Re, 2) + Math.Pow(Im, 2)); }
        }

        public static bool operator ==(Complex x, Complex y)
        {
            if (x.Re == y.Re && x.Im == y.Im)
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(Complex x, Complex y)
        {
            if (x.Re != y.Re || x.Im != y.Im)
            {
                return true;
            }
            return false;
        }
         
        public Complex Add(Complex x ,double y)
        {
            return new Complex(x.Re + y, x.Im );
        }

        public Complex Sub(Complex x, double y)
        {
            return new Complex(x.Re - y, x.Im);
        }

        public Complex Multi(Complex x, double y)
        {
            return new Complex(x.Re * y, x.Im*y);
        }
        public override string ToString()
        {

            if (this.Im < 0)
            {
                return this.Re + " - " + this.Im + "i";
            }
            else if (this.Im >= 0)
            {
                return this.Re + " + " + this.Im + "i";
            }
            else
            {
                return "" + this.Re;
            }
        }

    }
}
