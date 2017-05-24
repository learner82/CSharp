using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseCoffee
{

    public class Order
    {

        List<Coffee> parag;

        public Order()
        {
            parag = new List<Coffee>();
        }

        public void Add(Coffee c)
        {
            parag.Add(c);
        }

        public double calculateCost()
        {
            double price = 0;

            for (int i = 0; i < parag.Count; i++)
            {

                if (Coffee.coffeeSize.small == parag[i].size)
                {
                    price += 0.5;
                }
                else if (Coffee.coffeeSize.normal == parag[i].size)
                {
                    price += 1.5;
                }
                else if (Coffee.coffeeSize.large == parag[i].size)
                {
                    price += 2.5;
                }

            }
            return price;

            //public void PlaceOrder()
            //{
            //    for (int i = 0; i < coffee.GetLength(0); i++) ;
            //    {
            //        coffee[i] = new Coffee[];
            //
            //    }
            // }
        }
    }
