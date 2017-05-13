using ConsoleApplication1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            LetterPrinterGenerics<int> p1 = new LetterPrinterGenerics<int>(1,"A");
            LetterPrinterGenerics<string> p2 = new LetterPrinterGenerics<string>("WEF4455","B");
            Console.WriteLine(p1.GenerateRandomLengthSequence());
            Console.WriteLine(p2.GenerateRandomLengthSequence());
            Console.ReadKey();

            List<LetterPrinter> letterPrinters = new List<LetterPrinter>();
            List<int> numbers = new List<int>();
            List<string> strings = new List<string>();

            List<Object> objects = new List<object>();
            objects.Add(new LetterPrinter());
            objects.Add(1);
            objects.Add("Sfdgsdfg");


            ((LetterPrinter)objects[0]).




            numbers.Add(5);
            numbers.Add(3);
            
            strings.Add("Giannis");
            strings.Add("Petros");

            letterPrinters.Add(new LetterPrinter(1,"A"));
            letterPrinters.Add(new LetterPrinter(2,"B"));







        }
    }
}
