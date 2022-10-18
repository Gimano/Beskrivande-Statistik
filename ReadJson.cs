using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Beskrivande_Statistik
{
    internal static class ReadJson
    {

        public static void Open()
        {
            Console.Clear();
            Display();
            Create();
        }
        public static void Create()
        {
            Console.WriteLine("Skriv in filnamnet, skriv sedan in så många siffror du vill lägga till");
            Console.Write("Filnamn: ");
            string fileName = Console.ReadLine();
            do
            {
                int tal;
                Console.Write("Skriv in ett tal: ");
                while (!int.TryParse(Console.ReadLine(), out tal)) ;

            } while (fileName == "");

            using (StreamWriter file = File.CreateText($"{fileName}.json"))
            using (JsonTextWriter writer = new JsonTextWriter(file))
            {
                //videogameRatings.WriteTo(writer);
                //file.WriteLine(writer);
            }
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
    }
}
