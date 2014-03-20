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
            string[][] submenuText = {  new string[] { "Aperitief1", "Aperitief2", "Aperitief3" },
                                        new string[] {"Voorgerecht1", "Voorgerecht2", "Voorgerecht3" },
                                        new string[] {"Hoofdgerecht1", "Hoofdgerecht2", "Hoofdgerecht3" },
                                        new string[] { "Nagerecht1", "Nagerecht2", "Nagerecht3" },
                                        new string[] { "Slaapmutsje1", "Slaapmutsje2", "Slaapmutsje3" }};
            bool droppedDown = false;
            int currentCursorLeft = 0;
            do
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Clear();
                Console.CursorVisible = false;
                Console.CursorTop = 0;
                Console.CursorLeft = 0;
                for (int i = 0; i < menuText.Length; i++)
                {
                    Console.CursorTop = 0;
                    if (i == currentOption)
                    {
                        currentCursorLeft = Console.CursorLeft;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.BackgroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.BackgroundColor = ConsoleColor.Black;
                    }
                    Console.Write(menuText[i]);
                }
                if (droppedDown)
                {
                    for (int j = 0; j < submenuText[currentOption].Length; j++)
                    {
                        Console.CursorTop = 1 + j;
                        Console.CursorLeft = currentCursorLeft;
                        Console.Write(submenuText[currentOption][j]);
                    }
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
                    case ConsoleKey.Enter:
                        droppedDown = !droppedDown;
                        break;
                }
            } while (input.KeyChar != 'q');
        }
    }
}
