using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bouncy
{
    class Program
    {
        static void Main(string[] args)
        {
            int right=20;
            int bottom=20;

            bool endloop = false;
            
            for (int i = 0; i < right+1; i++)
            {
                Console.SetCursorPosition(i, bottom+1);
                Console.Write("-");
            }
            for (int i = 0; i < bottom+1; i++)
            {
                Console.SetCursorPosition(right+1, i);
                Console.Write("|");
            }

            List<ISprite> Sprites = new List<ISprite>()
            {
                new Ball(1,1,3,6,"a",bottom, right),
                new Ball(1,-1,5,6,"b",bottom, right),
                new Ball(-1,-1,3,3,"c",bottom, right),
                new Ball(-1,1,1,6,"d",bottom, right),
                new Ball(1,-1,6,6,"e",bottom,right),
                new Ball(-1,1,3,2,"f",bottom,right)

            };
            while (!endloop)
            {
                System.Threading.Thread.Sleep(100);
                foreach (var sprite in Sprites)
                    sprite.Update();
                foreach (var sprite in Sprites)
                    sprite.Draw();

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                    if (keyInfo.Key == ConsoleKey.A)
                        endloop = true;
                    foreach (var sprite in Sprites)
                        sprite.OnInput(keyInfo.Key.ToString());
                }
            }
        }
    }
}
