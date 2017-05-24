using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseCoffee
{

    public class Coffee
    {
        public enum coffeeSize
        {
            small = 100,
            normal = 150,
            large = 300
        }
        public coffeeSize size;
        private double price;


        public Coffee(coffeeSize size)
        {

            this.size = size;
            this.price = 0;

        }

        public override string ToString()
        {
            string val = "Your coffee costs " + this.price + "€," + (int)this.size + " ml" + "!";// to int sthn paren8esh to exw balei gia na kanei to size se noumero.
            return val;
        }

    }
}
