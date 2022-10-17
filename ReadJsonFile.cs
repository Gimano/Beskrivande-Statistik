using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

public static class DeserializeJson
{
    public static int[] Deserialize()
    {
        // Read the json file
        var path = "data.json";
        string jsonFile = File.ReadAllText(path);

        // decerialize the json file into array Numbersdata
        int[] NumbersData = JsonConvert.DeserializeObject<int[]>(jsonFile);

        return NumbersData;
    }
}