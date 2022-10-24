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
            Display();
            Console.WriteLine("------------------------------------------------------");
            Input();
        }
        public static void Input()
        {
            Console.WriteLine("Skriv in namnet på filen du vill läsa (utan .json): ");
            string fileName = Console.ReadLine();
            var data = Statistics.DescriptiveStatistics(Deserialize(fileName));
            Presentation_av_data.presentation_av_data(data);
        }

        public static void Display()
        {
            string root = Directory.GetCurrentDirectory();

            var files = Directory.GetFiles(root, "*.json", SearchOption.AllDirectories);
            Console.WriteLine("Tillgängliga JSON filer:");
            foreach (var file in files)
            {
                Console.WriteLine(Path.GetFileName(file));
            }
        }

        public static int[] Deserialize(string fileName)
        {
            // Read the json file
            var path = fileName + ".json";
            string jsonFile = File.ReadAllText(path);

            // decerialize the json file into array Numbersdata
            int[] NumbersData = JsonConvert.DeserializeObject<int[]>(jsonFile);

            return NumbersData;
        }
    }
}
