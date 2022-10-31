﻿using System;
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
                // reads the json file the user has chosen
                string jsonFile = File.ReadAllText(path);

                // return the json file as an array of ints called NumbersData
                int[] NumbersData = JsonConvert.DeserializeObject<int[]>(jsonFile);
                Console.Clear();
                return NumbersData;
            }

            // if the user input does not match a json file throw error message and try again
            else
            {
                Console.WriteLine("File does not exist. Please try again.");
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