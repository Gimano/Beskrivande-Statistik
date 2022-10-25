using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beskrivande_Statistik
{
    internal class ReadCustomJson
    {
        public static void Open()
        {
            Console.Clear();
            Display(); //Visar alla json filer i rotmappen
            Console.WriteLine("------------------------------------------------------");
            Input(); //Ber användaren skriva in vilken json som ska läsas och presenterar sen datan
        }
        public static void Display()
        {
            string root = Directory.GetCurrentDirectory();

            string[] files = Directory.GetFiles(root, "*.json", SearchOption.AllDirectories).Where(name => !name.Contains("Beskrivande Statistik")).ToArray();
            Console.WriteLine("Tillgängliga JSON filer:");
            foreach (var file in files)
            {
                Console.WriteLine(Path.GetFileName(file));
            }
        }
        public static void Input()
        {
            while (true)
            {
                Console.WriteLine("Skriv in namnet på filen du vill läsa (med .json): ");
                string fileName = Console.ReadLine();
                if (ReadJsonFile.Deserialize(fileName) != null)
                {
                    dynamic data = Statistics.DescriptiveStatistics(ReadJsonFile.Deserialize(fileName));
                    Presentation_av_data.presentation_av_data(data);
                    break;
                }
            }
        }
    }
}
