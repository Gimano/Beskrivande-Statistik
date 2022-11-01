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
        public static void presentation_av_data(dynamic presentFile)            //ha olika färg då bli texten lättläst
        {   
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nVoilà");
            Console.WriteLine("-------"); 
            
            Console.ForegroundColor = ConsoleColor.White;   
            Console.WriteLine($"\nMaximum: {presentFile["Maximum"]}");                             //vit
            
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine($"\nMinimum: {presentFile["Minimum"]}");                             //grå
            
            Console.ForegroundColor = ConsoleColor.White;   
            Console.WriteLine($"\nMedelvärde: {Math.Round(presentFile["Mean"], 1)}");              //vit
            
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine($"\nMedian: {Math.Round(presentFile["Median"], 1)}");                //grå
            
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write($"\nTypvärde: ");                                                        //vit
            Console.WriteLine(string.Join(", ", presentFile["Mode"]));          //Skriver ut så många Mode som finns i varje json fil 

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine($"\nVariationsbredd: {presentFile["Range"]}");                       //grå
            
            Console.ForegroundColor = ConsoleColor.White;           
            Console.WriteLine($"\nStandardavvikelse: {Math.Round(presentFile["StandardDeviation"], 1)} ");        //vit
            
            Console.ForegroundColor = ConsoleColor.Gray;                                       
            Console.WriteLine("\n-------------------------------------------");                    //grå
            
            Console.ReadKey(); 
        }
    } 
}