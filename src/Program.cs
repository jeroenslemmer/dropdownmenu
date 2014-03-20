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
            string[] menuText = { "Aperitief", "Voorgerecht", "Hoofdgerecht", "Nagerecht", "Slaapmutsje" };

            do
            {
                Console.Clear();
                for (int i = 0; i < menuText.Length; i++)
                {
                    Console.Write(menuText[i] + " ");
                }

                input = Console.ReadKey();
            } while (input.KeyChar != 'q');
        }
    }
}
