using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beskrivande_Statistik
{
    public static class UserCreateJson
    {
        public static void UserJson()
        {
            Console.Write("Name of your list: ");
            string fileName = Console.ReadLine();
            fileName = fileName + ".json";
            List<int> IntList = new List<int>();
            Console.WriteLine("Input integer numbers to your json file, type 0 to finish.");
            // Let user add integers to IntList untill input is 0, also if formatexception go to label and keep looping
            InvalidInput:
            while (true)
            {
                try
                {
                    Console.Write("Number to add: ");
                    int input = int.Parse(Console.ReadLine());

                    if (input != 0)
                    {
                        IntList.Add(input);
                    }
                    else
                    {
                        string json = JsonConvert.SerializeObject(IntList, Formatting.Indented);
                        File.WriteAllText(fileName, json);
                        break;
                    }
                }
                catch(FormatException)
                {
                    Console.WriteLine("Invalid input. Input only accept integers.");
                    goto InvalidInput;
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Input out of range, stay inside integer range please.");
                    goto InvalidInput;
                }
            }
        }
    }
}
