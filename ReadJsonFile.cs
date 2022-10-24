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






/*
string jsonSwitch = Console.ReadLine();
switch (jsonSwitch)
{
    case "1":
        // read the json file data.json
        path = "data.json";
        jsonFile = File.ReadAllText(path);
        // return the json file as an array of ints called NumbersData
        int[] NumbersData = JsonConvert.DeserializeObject<int[]>(jsonFile);
        Console.Clear();
        return NumbersData;
        break;
    default:
        // om ogiltigt val skicka tillbaka användaren för att göra ett nytt val
        Console.Write("Invalid option, please try again");
        for (int i = 0; i < 3; i++)
        {
            Console.Write(".");
            Thread.Sleep(350);
        }
        Console.Clear();
        goto invalidInput;
        break;
}

// BYGG OM HELA SKITEN SÅ VI SKRIVER UT VILKA .JSON FILER SOM FINNS, SEN FÅR MAN SKRIVA IN FILNAMNET AV FILEN SOM SKA KÖRAS.
// IF FILE DOES NOT EXIST FELMEDDELANDE & PROVA IGEN

*/

