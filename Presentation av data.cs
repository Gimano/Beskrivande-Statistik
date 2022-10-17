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
        public static void presentation_av_data()    //vill ha olika bakgrundfärg då bli texten lättläst
        {
            Console.WriteLine($"Maximun:  " + 
                $"\nMinimum: " +
                $"\nMedelvärde: " +
                $"\nMedian: " +
                $"\nTypvärde: " +
                $"\nVaiationsbredd: " +
                $"\nStandardavvikelse: ");
        }
    }
}
