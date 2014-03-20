using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DropdownMenu
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo input;
            int currentOption = 0;
            string[] menuText = { "Aperitief", "Voorgerecht", "Hoofdgerecht", "Nagerecht", "Slaapmutsje" };

            do
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Clear();
                for (int i = 0; i < menuText.Length; i++)
                {
                    if (i == currentOption)
                    {
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.BackgroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.BackgroundColor = ConsoleColor.Black;
                    }
                    Console.Write(menuText[i] + " ");
                }
                input = Console.ReadKey();
                switch (input.Key)
                {
                    case ConsoleKey.RightArrow:
                        if (currentOption < menuText.Length - 1)
                        {
                            currentOption++;
                        }
                        break;
                    case ConsoleKey.LeftArrow:
                        if (currentOption > 0)
                        {
                            currentOption--;
                        }
                        break;

                }
            } while (input.KeyChar != 'q');
        }
    }
}
