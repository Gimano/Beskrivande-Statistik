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
        public static void presentation_av_data(dynamic presentFile)                                                  //ha olika färg då bli texten lättläst
        {
            //Statistics.DescriptiveStatistics(DeserializeJson.Deserialize());  //ropa till class Statistics 
            
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("\nVoilà");
            Console.WriteLine("-------"); 
            
            Console.ForegroundColor = ConsoleColor.White;   
            Console.WriteLine($"\nMaximum: {presentFile["Maximum"]}");                             //vit
            
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine($"\nMinimum: {presentFile["Minimum"]}");                             //grå
            
            Console.ForegroundColor = ConsoleColor.White;       
            Console.WriteLine($"\nMedelvärde: {presentFile["Mean"]}");                             //vit
            
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine($"\nMedian: {presentFile["Median"]}");                               //grå
            
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("Typvärde : ");

            foreach (var i in presentFile["Mode"])
            {
                Console.WriteLine($" {i}");                                                       //vit 
            }
            
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine($"\nVariationsbredd: {presentFile["Range"]}");                       //grå
            
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"\nStandardavvikelse: {presentFile["StandardDeviation"]} ");        //vit
            
            Console.ForegroundColor = ConsoleColor.Gray;                                       
            Console.WriteLine("\n-------------------------------------------");                    //grå
            
            Console.ForegroundColor = ConsoleColor.Gray;                                           //grå
            Console.ReadKey(); 
        }
    } 
}
// fixar Mode, börjar med foreach eller med loop  
// MODE ska inte skriva ut 3 gånger så där. utan skriver ut bara de MODE som finns i filen. för vi har en fil till som inte är Json filen  
// skriver ut hur många MODE som finns (inte 3 saker) 
 