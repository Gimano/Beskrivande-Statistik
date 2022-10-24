using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;
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
                        int input = 0;
                            Console.WriteLine("Input integer numbers to your json file, type 0 to finish.");
                            Console.Write("Number to add: ");
                        input = ExceptionHandling(input);

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
                    break;

                // lets the user chose how many integers to be added to the jsonfile and also chose within which range the numbers can be created from a random.
                case "2":
                    int numberOfInts = 0;
                    int lowRnd = 0;
                    int highRnd = 0;
                    Console.Write("How many randomly generated integer numbers do you want to add to your list?: ");
                    numberOfInts = ExceptionHandling(numberOfInts);
                    Console.Write("Lowest possible number to be generated: ");
                    lowRnd = ExceptionHandling(lowRnd);
                    Console.Write("Highest possible number to be generated: ");
                    highRnd = ExceptionHandling(highRnd);
                    for (int i = 0; i < numberOfInts; i++)
                    {
                        Random rnd = new Random();
                        int num = rnd.Next(lowRnd, highRnd);
                        IntList.Add(num);
                    }
                    // serializes the elements of IntList and writes them to fileName.json, with indentation
                    string jsonWithRnd = JsonConvert.SerializeObject(IntList, Formatting.Indented);
                    File.WriteAllText(fileName, jsonWithRnd);
                    break;
            }
        }

        // A method to try and catch exceptions and retry taking inputs untill no exception is caught.
        // I made this to avoid repeating myself with alot of try catches in the rest of the code.
        public static int ExceptionHandling(int intToTry)
        {
            ExceptionHandlingLabel:
            try
            {
                int temp = int.Parse(Console.ReadLine());
                return temp;
            }
            catch (FormatException)
            {
                Console.Write("Invalid input. Input only accept integers.\nPlease try again: ");
                goto ExceptionHandlingLabel;
            }
            catch (OverflowException)
            {
                Console.Write("Input out of range, stay inside integer range please.\nPlease try again: ");
                goto ExceptionHandlingLabel;
            }
        }

    }
}
