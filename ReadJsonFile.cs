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
        invalidInput:
        Console.WriteLine("[1] data.json");
        Console.Write("Which file do you want to use: ");
        var path = "";
        string jsonFile = "";
        string jsonSwitch = Console.ReadLine();
        switch (jsonSwitch)
        {
            case "1":
                // Read the json file
                path = "data.json";
                jsonFile = File.ReadAllText(path);
                // return the json file into int array NumbersData
                int[] NumbersData = JsonConvert.DeserializeObject<int[]>(jsonFile);
                Console.Clear();
                return NumbersData;
                break;
            default:
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
        
        
        

        
    }
}