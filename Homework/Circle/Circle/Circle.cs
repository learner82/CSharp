using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sxhmata
{
    public class Circle
    {
        public double radiance { get; set; }

        public Circle(double Radiance)
        {
            this.radiance = Radiance;

        }

              
        public Circle ()
        {
            this.radiance=0;
        }
        public double Diametros
        {
            get { return radiance * 2; }

        }

        public double perifereia
        {
          get { return radiance * Math.PI; }
        }

        public double embadon
        {
            get { return (double)Math.Pow(2, radiance) * Math.PI; }
        }

        public override string ToString()
        {
            return $"Circle : Aktina = {radiance}, Diametros = {Diametros}, Perifereia = {perifereia}, Embadon = {embadon}";
        }
        

    }
}
