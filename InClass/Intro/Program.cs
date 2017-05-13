using Intro.lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro
{
    class Program
    {
        static void Main(string[] args)
        {
            Helloer h1 = new Helloer("Hello John");
            Console.WriteLine(h1.message);

            Helloer h2 = new Helloer("Hello Panagopoulos");
            Console.WriteLine(h2.message);

            HelloerStatic.message = "Hello from Static";
            Console.WriteLine(HelloerStatic.message);

            HelloerLib h3 = new HelloerLib("Hello from .dll");
            h3.ShowMessage();

            Console.ReadKey();

        }
    }
}
