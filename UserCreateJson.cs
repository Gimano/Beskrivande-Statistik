using Newtonsoft.Json;
using System;
using System.Collections;
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
            Console.Clear();
            Console.Write("Vad ska din fil heta: ");
            string fileName = Console.ReadLine();
            fileName = fileName + ".json";
            List<int> IntList = new List<int>();
            string jsonChoice = "";
            Console.Clear();

            while (jsonChoice != "0") 
            {
                Console.Write($"[1] Lägg till integers manuellt i {fileName}.\n[2] Fyll {fileName} med random integers.\n[0] Gå tillbaka till menyn\nDitt val: ");
                jsonChoice = Console.ReadLine();
                switch (jsonChoice)
                {

                    #region Case 1 - Lägg till integers manuellt
                    case "1":
                        // Låt användaren lägga till integers manuellt i IntList
                        // Sen serialiserar vi värdena i listan och skriver ut dom i json filen.
                        while (true)
                        {
                            int input = 0;
                            Console.WriteLine("Skriv in integer värden att lägga till. Avsluta med [0]");
                            Console.Write("Lägg till siffra: ");
                            input = ExceptionHandling(input);

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
                        jsonChoice = "0";
                        break;
                    #endregion

                    #region Case 2 - Fill list with random integers
                    // låt användaren välja hur många integers som ska läggas till med hjälp av en random, sen vad högsta och lägsta värdet på dessa siffror kan vara.
                    // Man får max skapa en lista med 10 miljoner värden i, detta på grund av att filen blir oerhört stor annars och det ska vara lämpligt att köra för alla oss i klassen.
                    // Om användaren väljer mer än 1 miljon värden att skapas får den frågan om den verkligen vill fortsätta.
                    case "2":
                        int numberOfInts = 0;
                        int lowRnd = 0;
                        int highRnd = 0;
                        string confirmInts = "";

                    regretDecision:
                        Console.Write("Hur många random integers vill du skapa till din json fil: ");
                        numberOfInts = ExceptionHandling(numberOfInts);

                        while (numberOfInts < 1 || numberOfInts > 10000000)
                        {
                            Console.WriteLine("Värden att skapa måste vara mellan 1 - 10000000");
                            numberOfInts = ExceptionHandling(numberOfInts);
                        }

                        if (numberOfInts >= 1000000)
                        {
                            Console.Write("Du valde att skapa fler än 1 miljon värden till din fil.\nDetta kommer att ta upp mycket utrymme och resurser.\nVill du fortsätta? (Y/N): ");

                            while (confirmInts != "N")
                            {
                                confirmInts = Console.ReadLine().ToUpper();
                                if (confirmInts == "Y")
                                {
                                    Console.WriteLine($"{fileName}.json kommer att skapas med {numberOfInts} integers. Vi varnade dig.");
                                    break;
                                }
                                else if (confirmInts == "N") goto regretDecision;
                                else Console.Write("Ogiltigt val. Vill du fortsätta? (Y/N): ");
                            }
                        }

                        Console.Write("Lägsta möjliga nummer att genereras: ");
                        lowRnd = ExceptionHandling(lowRnd);

                        do
                        {
                            Console.Write($"Högsta möjliga nummer att genereras (kan inte vara lägre än {lowRnd}): ");
                            highRnd = ExceptionHandling(highRnd);
                        } while (lowRnd >= highRnd);

                        for (int i = 0; i < numberOfInts; i++)
                        {
                            Random rnd = new Random();
                            int num = rnd.Next(lowRnd, highRnd);
                            IntList.Add(num);
                        }

                        // serialiserar elementen i IntList och skriver dom till fileName.json, med indentation
                        string jsonWithRnd = JsonConvert.SerializeObject(IntList, Formatting.Indented);
                        File.WriteAllText(fileName, jsonWithRnd);

                        jsonChoice = "0";
                        break;
                    #endregion

                    #region Default
                    default:
                        Console.Clear();
                        Console.WriteLine("Felaktig inmatning");
                        break;
                        #endregion

                }
            }
        }

        // En metod för att testa och fånga exceptions som rimligtvis kommer att ske i koden.
        // Detta för att undvika en massa onödig upprepning i resten av koden.
        public static int ExceptionHandling(int intToTry)
        {
            while (true)
            {
                try
                {
                    int temp = int.Parse(Console.ReadLine());
                    return temp;
                }
                catch (FormatException)
                {
                    Console.Write("Ogiltig inmatning. Inmatningen accepterar bara integers.\nVar god försök igen: ");
                }
                catch (OverflowException)
                {
                    Console.Write("Inmatningen är utanför tillåtet intervall\nMata in en giltig integer: ");
                }
            }
        }
    }
}
