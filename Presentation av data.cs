using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beskrivande_Statistik
{
    internal static class Presentation_av_data   //Krittapat 
    {
        public static void presentation_av_data(dynamic presentFile)            //ha olika färg då bli texten lättläst
        {
            ColorConsole.WriteWrappedHeader("Voilà!", headerColor: ConsoleColor.Yellow);

            ColorConsole.WriteLine($"\nMaximum: {presentFile["Maximum"]}", ConsoleColor.White);
            
            ColorConsole.WriteLine($"\nMinimum: {presentFile["Minimum"]}", ConsoleColor.Gray);
  
            ColorConsole.WriteLine($"\nMedelvärde: {Math.Round(presentFile["Mean"], 1)}", ConsoleColor.White);

            ColorConsole.WriteLine($"\nMedian: {Math.Round(presentFile["Median"], 1)}", ConsoleColor.Gray);
            
            ColorConsole.Write($"\nTypvärde: ", ConsoleColor.White);
            ColorConsole.WriteLine(string.Join(", ", presentFile["Mode"]), ConsoleColor.White);

            ColorConsole.WriteLine($"\nVariationsbredd: {presentFile["Range"]}", ConsoleColor.Gray);
           
            ColorConsole.WriteLine($"\nStandardavvikelse: {Math.Round(presentFile["StandardDeviation"], 1)} ", ConsoleColor.White);

            Console.ReadKey(); 
        }
    } 
    // Helper class för att underlätta estetiska val
    // Byggd och implementerad i denna och övriga klasser av Markus
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
        // Markus
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
        // Metod för att skapa headers till menyer /Markus
        public static void WriteWrappedHeader(string headerText,
                                            char wrapperChar = '-',
                                            ConsoleColor headerColor = ConsoleColor.Yellow,
                                            ConsoleColor dashColor = ConsoleColor.DarkGray)
        {
            if (string.IsNullOrEmpty(headerText))
                return;

            string line = new string(wrapperChar, headerText.Length);

            WriteLine(line, dashColor);
            WriteLine(headerText, headerColor);
            WriteLine(line, dashColor);
        }
        public static bool flag = false;
        // Metod med bool toggle för att alternera mellan vit och grå färg på text /Markus
        public static void AlternateColor(string text)
        {
            if (flag == false)
            {
                ColorConsole.WriteLine(text, ConsoleColor.White);
                flag = !flag;
            }
            else
            {
                ColorConsole.WriteLine(text, ConsoleColor.Gray);
                flag = !flag;
            }
        }
    }
}