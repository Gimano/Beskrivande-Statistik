using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beskrivande_Statistik
{
    internal class Presentation_av_data    //Vill testa merge/ pull / push till Git 
    {
        public static void presentation_av_data()    //vill ha olika färg då bli texten lättläst
        {
            Console.ForegroundColor = ConsoleColor.White;   
            Console.WriteLine($"Maximun:  ");                   //vit
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine($"\nMinimum: ");                  //grå
            Console.ForegroundColor = ConsoleColor.White;       
            Console.WriteLine($"\nMedelvärde: ");               //vit
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine($"\nMedian: ");                   //grå
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"\nTypvärde: ");                 //vit 
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine($"\nVariationsbredd: ");           //grå
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"\nStandardavvikelse: ");        //vit
            Console.ForegroundColor = ConsoleColor.Gray;        //grå 

        }
    }
}
