using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            
                Console.SetCursorPosition(25,10);
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            
                Console.WriteLine("Username:");
            Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.SetCursorPosition(25, 11);
                
                Console.ReadLine();
              Console.Clear();
            
            Console.ForegroundColor = ConsoleColor.DarkGreen;

            GameState game = new GameState();
            game.Run();
            while (true)
            {

               
                ConsoleKeyInfo consoleKeyInfo = Console.ReadKey();
                game.ProcessKeyEvent(consoleKeyInfo);
            }

        }
    }
}
