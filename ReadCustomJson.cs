using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beskrivande_Statistik
{
    internal class ReadCustomJson //Martin. Markus hjälpte till på en rad
    {
        public static void Open()
        {
            Console.Clear();
            Display();
            Console.WriteLine("------------------------------------------------------");
            Input();
        }
        public static void Display()  //Visar alla json filer i rotmappen
        {
            string root = Directory.GetCurrentDirectory();

            string[] files = Directory.GetFiles(root, "*.json", SearchOption.AllDirectories).Where(name => !name.Contains("Beskrivande Statistik")).ToArray();
            ColorConsole.WriteWrappedHeader("Tillgängliga JSON filer:");
            foreach (var file in files)
            {
                ColorConsole.AlternateColor($"{Path.GetFileName(file)}");
            }
        }
        public static void Input() //Ber användaren skriva in vilken json som ska läsas och presenterar sen datan
        {
            Console.WriteLine("Skriv in namnet på filen du vill läsa (utan .json) eller tryck enter för att gå tillbaka:");

            while (true)
            {
                string fileName = Console.ReadLine() + ".json";

                if (fileName == ".json")
                    break;

                
                else if (ReadJsonFile.Deserialize(fileName) != null)
                {
                    dynamic data = Statistics.DescriptiveStatistics(ReadJsonFile.Deserialize(fileName));
                    Presentation_av_data.presentation_av_data(data);
                    break;
                }
            }
        }
    }
}
