using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exe4Mich
{
    class Program
    {
        static void Main(string[] args)
        {
            var proswpata = new List<Person>();

            bool kati = false;
            int idx = 0;
            int currentidx = 1;
            while (!kati)
            {
                
                Console.WriteLine("Ξεκινηστέ να προσθέτε άτομα ");
                Console.WriteLine($"Δώστε μου την ηλικία του {currentidx}ου άτομου");
                string xstr = Console.ReadLine();
                int x = Convert.ToInt32(xstr);
                Console.WriteLine($"Δώσε μου το όνομα του {currentidx}ου άτομου");
                string y = Console.ReadLine();
                Console.WriteLine($"Δώσε μου το επώνυμο του {currentidx}ου άτομου");
                string z = Console.ReadLine();
                Console.WriteLine($"Δώσε μου το πατρώνυμο του {currentidx}ου άτομου");
                string w = Console.ReadLine();
                Console.WriteLine($"Δώστε μου τo afm {currentidx} άτομου");
                string kstr = Console.ReadLine();
                double k = Convert.ToDouble(xstr);
                Person p = new Person(x, y, z, k, w);
                proswpata.Add(p);
                
                Console.WriteLine("An epi8umeite na teleiwsete thn eisagwgh stoixeiwn pathste 0, αλλίως πατήστε οποιοδήποτε άλλο πλήκτρο");
                idx++;
                currentidx = currentidx++;
                string ostr = Console.ReadLine();
                if (ostr == "0")
                {
                    kati = true;
                }
                else { kati = false; }

                
            }
            
            Console.WriteLine("result is "+ Minage(proswpata) );
            
        }

        public static Person Minage(List<Person> persons)
        {
            //persons = new List<Person>();

            var query1 = (from p in persons
                          where p.Age == persons.Min(r => r.Age)
                          select p).FirstOrDefault();
            return query1;

        }

    }

}
