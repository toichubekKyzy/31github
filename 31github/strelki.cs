using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31github
{
    internal class strelki
    {
        public static void MoveMenu()
        {
            ConsoleKeyInfo keyInfo;
            List <> options = ;
            int indexVkladki = 0;

            for (int BookNumber = 0; BookNumber < options.Count; BookNumber++)
            {
                if (BookNumber == indexVkladki)
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.White;
                }
                Console.WriteLine(options[BookNumber].Title);

                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.Black;
            }

            keyInfo = Console.ReadKey(true);

            if (keyInfo.Key == ConsoleKey.UpArrow) { indexVkladki = (indexVkladki - 1 + options.Count()) % options.Count(); }
            if (keyInfo.Key == ConsoleKey.DownArrow) { indexVkladki = (indexVkladki + 1) % options.Count(); }

            if (keyInfo.Key == ConsoleKey.Enter)
            {
                options[indexVkladki].OpenNextOperation();

            }
        }
    }
}
