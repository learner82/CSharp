using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crypto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me your sentence, word whatever you wish!!!");

            string ystr =  Console.ReadLine();

            int y = Convert.ToInt32(ystr);

            Console.WriteLine(y);
            
            //List<char> x = y.ToList<char>();
            
          //  for(int i=0; i<y.Length;i++)

          //  {
          //      x[i] = x[i + 2];
                
          //      Console.WriteLine(x.ToArray<char>());           
          //  }
          //  Console.ReadKey();
        }
    }
}
