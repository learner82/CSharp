using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sxhmata

{
    public class Sphere : Circle
    {
        public double radiance { get; set; }

        public Sphere()
        {
            radiance = 0;
        }
        public Sphere(double rad)
        {
            this.radiance = rad;
        }

        public double Ogkos
        {
            get { return (double)Math.Pow(3, radiance) * Math.PI * (4 / 3); }
           
        }
        public override string ToString()
        {
            return base.ToString() + "Ogkos = " + Ogkos;
        }
    }
}
