using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beskrivande_Statistik
{
    // Vill du mata in egna värden eller vill du generera ett antal random värden?????? BYGG DET - DU SKA JOBBA HÄR ( KANSKE SKA MAN FÅ VÄLJA VAD FÖR MEDELVÄRDEN .JSON FILEN SKA HA ETC)
    // NIKLAS
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
                        // serializes the elements of IntList and writes them to fileName.json, with indentation
                        string json = JsonConvert.SerializeObject(IntList, Formatting.Indented);
                        File.WriteAllText(fileName, json);
                        break;
                    }
                }
                // Catches possible exceptions and sends the user back to keep adding integers untill user enters 0 to exit.
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
