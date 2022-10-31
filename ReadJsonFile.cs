using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Beskrivande_Statistik;



// Niklas
public static class ReadJsonFile
{
    public static int[] Deserialize(string path)
    {
        try
        {
            if (File.Exists(path))
            {
                // läs in den json filen användaren väljer
                string jsonFile = File.ReadAllText(path);

                // returnera filen som en array av integers
                int[] NumbersData = JsonConvert.DeserializeObject<int[]>(jsonFile);
                Console.Clear();
                return NumbersData;
            }

            // om användarens inmatning inte matchar namnet med en jsonfil -> error message -> försök igen
            else
            {
                Console.WriteLine("Filen finns inte. Försök igen.");
                return null;
            }
        }
        catch (JsonReaderException)

        {
            Console.WriteLine("Json-filen innehåller data som ej kan deserialiseras.");
            return null;
        }
        catch (JsonSerializationException)
        {
            Console.WriteLine("Json-filen kan ej serialiseras.");
            return null;
        }
    }
}