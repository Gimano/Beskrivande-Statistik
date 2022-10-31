using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beskrivande_Statistik
{
    internal class DeleteJson
    {
        // En metod där användaren får välja en json fil den vill ta bort
        public static void Delete()
        {
            Console.Clear();
            ReadCustomJson.Display();
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("Skriv in namnet på filen du vill ta bort (utan .json) eller tryck enter för att gå tillbaka:");
            while (true)
            {
                string fileName = Console.ReadLine() + ".json";

                if (fileName == ".json")
                    break;

                else if (fileName == "data.json")
                {
                    Console.Write("Data.json är skrivskyddad och får ej tas bort.\nFil att ta bort (utan .json): ");
                }

                else if (ReadJsonFile.Deserialize(fileName) != null)
                {
                    File.Delete(fileName);
                    break;
                }
            }
        }


    }
}
