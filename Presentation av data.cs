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
            ColorConsole.WriteLine("\nVoilà", ConsoleColor.Cyan);
            ColorConsole.WriteLine("-------", ConsoleColor.Gray);

            ColorConsole.WriteLine($"\nMaximum: {presentFile["Maximum"]}", ConsoleColor.White);
            
            ColorConsole.WriteLine($"\nMinimum: {presentFile["Minimum"]}", ConsoleColor.Gray);
  
            ColorConsole.WriteLine($"\nMedelvärde: {Math.Round(presentFile["Mean"], 1)}", ConsoleColor.White);

            ColorConsole.WriteLine($"\nMedian: {Math.Round(presentFile["Median"], 1)}", ConsoleColor.Gray);
            
            ColorConsole.Write($"\nTypvärde: ", ConsoleColor.White);
            ColorConsole.WriteLine(string.Join(", ", presentFile["Mode"]), ConsoleColor.White);

            ColorConsole.WriteLine($"\nVariationsbredd: {presentFile["Range"]}", ConsoleColor.Gray);
           
            ColorConsole.WriteLine($"\nStandardavvikelse: {Math.Round(presentFile["StandardDeviation"], 1)} ", ConsoleColor.White);
                                                 
            ColorConsole.WriteLine("\n-------------------------------------------", ConsoleColor.Gray);
            
            Console.ReadKey(); 
        }
        
    } 
    // Helper class för att underlätta färgsättning
    class ColorConsole
    {
        public static void WriteLine(string text, ConsoleColor? color = null)
        {
            if (color.HasValue)
            {
                var oldColor = System.Console.ForegroundColor;
                if (color == oldColor)
                    Console.WriteLine(text);
                else
                {
                    Console.ForegroundColor = color.Value;
                    Console.WriteLine(text);
                    Console.ForegroundColor = oldColor;
                }
            }
            else
                Console.WriteLine(text);
        }
        public static void Write(string text, ConsoleColor? color = null)
        {
            if (color.HasValue)
            {
                var oldColor = System.Console.ForegroundColor;
                if (color == oldColor)
                    Console.Write(text);
                else
                {
                    Console.ForegroundColor = color.Value;
                    Console.Write(text);
                    Console.ForegroundColor = oldColor;
                }
            }
            else
                Console.Write(text);
        }
    }
}