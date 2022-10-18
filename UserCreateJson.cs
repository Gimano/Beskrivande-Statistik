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
            
            List<int> IntList = new List<int>();
            Console.WriteLine("Input integer numbers to your json file, type 0 to finish.");
            StreamWriter file = File.CreateText($"{fileName}.json");
            // Let user add integers to IntList untill input is 0, also if formatexception go to label and keep looping
            InvalidInput:
            while (true)
            {
                try
                {
                    Console.Write("Number to add: ");
                    IntList.Add(Convert.ToInt32(Console.ReadLine()));
                    if (IntList.Last() == 0)
                    {
                        foreach (int i in IntList)
                        {
                            
                        }
                        
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
