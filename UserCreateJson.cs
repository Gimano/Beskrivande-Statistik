using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Http.Headers;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
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
            Console.Clear();
            string jsonChoice = "";
        InvalidInput:
            while (jsonChoice != "0") 
            {
                Console.Write($"[1] Manually add integers to {fileName}.\n[2] Fill {fileName} with random integers.\n[0] Exit to menu\nInput: ");
                jsonChoice = Console.ReadLine();
                switch (jsonChoice)
                {
                    case "1":
                        // Let user add integers to IntList untill input is 0.
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

                    // lets the user chose how many integers to be added to the jsonfile and also chose within which range the numbers can be created from a random. (1 - 10 million capped)
                    // if the user choses more than 1 million - ask them if they want to proceed
                    case "2":
                        int numberOfInts = 0;
                        int lowRnd = 0;
                        int highRnd = 0;
                        string confirmInts = "";

                    regretDecision:
                        Console.Write("How many randomly generated integer numbers do you want to add to your list?: ");
                        numberOfInts = ExceptionHandling(numberOfInts);

                        while (numberOfInts < 1 || numberOfInts > 10000000)
                        {
                            Console.WriteLine("Range has to be between 1 - 10.000.000. Please try again.");
                            numberOfInts = ExceptionHandling(numberOfInts);
                        }

                        if (numberOfInts >= 1000000)
                        {
                            Console.Write("You chose to generate more than 1 million integers into a file.\nThis will take up alot of resources and space from your computer.\nAre you sure you want to continue? (Y/N): ");

                            while (confirmInts != "N")
                            {
                                confirmInts = Console.ReadLine().ToUpper();
                                if (confirmInts == "Y")
                                {
                                    Console.WriteLine($"Ok. Generating file with {numberOfInts} integers. We did warn you.");
                                    break;
                                }
                                else if (confirmInts == "N") goto regretDecision;
                                else Console.Write("Invalid option. Do you want to continue? (Y/N): ");
                            }
                        }

                        Console.Write("Lowest possible number to be generated: ");
                        lowRnd = ExceptionHandling(lowRnd);

                        do
                        {
                            Console.Write($"Highest possible number to be generated (can not be lower than {lowRnd}): ");
                            highRnd = ExceptionHandling(highRnd);
                        } while (lowRnd >= highRnd);

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
                    default:
                        Console.Clear();
                        Console.WriteLine("Felaktig inmatning");
                        break;
                }
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
