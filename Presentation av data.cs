using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beskrivande_Statistik
{
    internal static class Presentation_av_data   
    {
        public static void presentation_av_data()                                                  //ha olika färg då bli texten lättläst
        {
            dynamic presentFile = Statistics.DescriptiveStatistics(DeserializeJson.Deserialize());  //ropa till class Statistics 
            
            Console.ForegroundColor = ConsoleColor.White;   
            Console.WriteLine($"\nMaximum: {presentFile["Maximum"]}");                             //vit
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine($"\nMinimum: {presentFile["Minimum"]}");                             //grå
            Console.ForegroundColor = ConsoleColor.White;       
            Console.WriteLine($"\nMedelvärde: {presentFile["Mean"]}");                             //vit
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine($"\nMedian: {presentFile["Median"]}");                               //grå
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"\nTypvärde: {presentFile["Mode"]}");                               //vit 
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine($"\nVariationsbredd: {presentFile["Range"]}");                       //grå
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"\nStandardavvikelse: {presentFile["StandardDeviation"]} ");        //vit
            Console.ForegroundColor = ConsoleColor.Gray;                                           //grå 

            Console.ReadKey(); 
        }
    } 
}
