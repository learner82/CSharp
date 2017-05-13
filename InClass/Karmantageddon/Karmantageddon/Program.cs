using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karmantageddon
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            
            Player p1 = new Player(2);
            Console.WriteLine("Give p1 name:");
            p1.Name = Console.ReadLine();
            p1.AddKey("a");
            p1.AddKey("q");
            p1.AddKey("w");
            p1.AddKey("z");

            Player p2 = new Player(2);
            Console.WriteLine("Give p2 name:");
            p2.Name = Console.ReadLine();
            p2.AddKey("p");
            p2.AddKey("o");
            p2.AddKey("k");
            p2.AddKey("m");

            //TODO: Check lists for equal keys with a method and throw excption if error
            // CheckDuplicates(p1,p2), CheckDuplicates(List<string>,List<string>)

            while (!p1.Won && !p2.Won)
            {
                int milliseconds = r.Next(1, 2) * 1000;
                System.Threading.Thread.Sleep(milliseconds);

                // generate keys to press
                string p1Key = p1.GetNextKey();
                string p2key = p2.GetNextKey();

                Console.WriteLine($"Player1: {p1Key}     Player2: {p2key} ");


                // Get key pressed
                string keyPressedStr = "-";
                while (!p1.MyKey(keyPressedStr) && !p2.MyKey(keyPressedStr) ) {
                    ConsoleKeyInfo KeyPressed = Console.ReadKey();
                    keyPressedStr = KeyPressed.Key.ToString();
                }

                // Evaluate outcome
                p1.ActOnKey(keyPressedStr);
                p2.ActOnKey(keyPressedStr);

                Console.WriteLine(p1.ToString());
                Console.WriteLine(p2.ToString());

                Console.WriteLine("GET READY FOR THE NEXT ROUND (press enter)!");
                Console.ReadLine();
                System.Threading.Thread.Sleep(1000);
            }


            //PlayerPrinterConsole printer = new PlayerPrinterConsole();
            //PlayerPrinterWindows printer = new PlayerPrinterWindows();


            IPlayerPrinter printer = new PlayerPrinterConsole();

            printer.PrintPlayerStatus(p1);
            printer.PrintPlayerStatus(p2);

            Console.ReadKey();
        }
    }
}
