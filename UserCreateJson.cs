using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beskrivande_Statistik
{
    public static class UserCreateJson
    {
        public static int[] UserJson()
        {
            Console.Write("Name of your list: ");
            string fileName = Console.ReadLine();
            List<int> IntList = new List<int>();
            Console.Write("Input integer number to your json file (ESCAPE TO EXIT): ");
            var input = Console.ReadKey();
            do
            {
                IntList.Add()
            } while (input.Key != ConsoleKey.Escape);

            // placeholder return to keep syntax errors away while coding
            return null;
        }
    }
}
