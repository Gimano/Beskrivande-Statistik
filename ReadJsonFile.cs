using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;


// Niklas
public static class ReadJsonFile
{
    public static int[] Deserialize()
    {
    noFileLabel:
        // let the user make a choice of which file to use
        Console.Write("Which file do you want to use: ");
        string path = Console.ReadLine();

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
            Console.Clear();
            Console.WriteLine("File does not exist. Please try again.");
            goto noFileLabel;
        }

    }
}