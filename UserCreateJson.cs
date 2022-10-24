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
            Console.Clear();
        InvalidInput:

            Console.Write($"[1] Manually add integers to {fileName}.\n[2] Fill {fileName} with random integers.\nInput: ");
            string jsonChoice = Console.ReadLine();
            switch (jsonChoice)
            {
                case "1":
                    // Let user add integers to IntList untill input is 0, also if formatexception go to label and keep looping
                    while (true)
                    {
                        try
                        {
                            Console.WriteLine("Input integer numbers to your json file, type 0 to finish.");
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
                        catch (FormatException)
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
                    break;


                // ej färdig, är det rimligt med try catch x3 med 3 olika labels att gå tillbaka till vid caught exception? finns det bättre sätt?
                case "2":
                    Console.Write("How many randomly generated integer numbers do you want to add to your list?: ");
                    int numberOfInts = int.Parse(Console.ReadLine());
                    Console.Write("Lowest possible number to be generated: ");
                    int lowRnd = int.Parse(Console.ReadLine());
                    Console.Write("Highest possible number to be generated: ");
                    int highRnd = int.Parse(Console.ReadLine());
                    for (int i = 0; i < numberOfInts; i++)
                    {
                        Random rnd = new Random();
                        int num = rnd.Next(lowRnd, highRnd);
                        IntList.Add(num);
                    }
                    string jsonWithRnd = JsonConvert.SerializeObject(IntList, Formatting.Indented);
                    File.WriteAllText(fileName, jsonWithRnd);
                    break;
            }
        }
        //public static int ErrorHandling()
        //{
        //    try
        //    {

        //    }
        //    return 0;
        //}

    }
}
