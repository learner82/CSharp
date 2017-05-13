using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karmantageddon
{
    public class PlayerPrinterConsole:IPlayerPrinter
    {
        public void DummyMethod()
        {
            throw new NotImplementedException();
        }

        public void PrintPlayerStatus(Player p)
        {
            if (p.Won)
                Console.WriteLine($"{p.Name} WON!!!! YEAH!!!");
            else
                Console.WriteLine($"{p.Name} He/She cheated...");
        }


    }
}
