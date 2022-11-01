using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beskrivande_Statistik
{
    // Klass fylld med metoder för uträkningar av json filerna

    public static class Statistics
    {
        public static dynamic DescriptiveStatistics(int[] source)
        {
            if (source == null)
                throw new ArgumentNullException();
            if (source.Length == 0)
                throw new InvalidOperationException("Sequence contains no elements.");

            Dictionary<string, dynamic> response = new Dictionary<string, dynamic>()
            {
                {"Maximum", Maximum(source)},
                {"Minimum", Minimum(source)},
                {"Mean", Mean(source)},
                {"Median", Median(source)},
                {"Mode", Mode(source)},
                {"Range", Range(source)},
                {"StandardDeviation", StandardDeviation(source)}
            };
            return response;
        }

        public static int Maximum(int[] source)
        {
            if (source == null)
                throw new ArgumentNullException();
            if (source.Length == 0)
                throw new InvalidOperationException("Sequence contains no elements.");

            int maximum = 0;
            maximum = source.Max();
            return maximum;
        }

        public static double Mean(int[] source)
        {
            if (source == null)
                throw new ArgumentNullException();
            if (source.Length == 0)
                throw new InvalidOperationException("Sequence contains no elements.");

            double mean = 0;
            mean = source.Average();
            return mean;
        }


        public static double Median(int[] source)
        {
            if (source == null)
                throw new ArgumentNullException();
            if (source.Length == 0)
                throw new InvalidOperationException("Sequence contains no elements.");

            Array.Sort(source);

            if (source.Length % 2 == 0)
                return (source[source.Length / 2 - 1] + source[source.Length / 2]) / 2;
            else
                return source[source.Length / 2];
        }


        public static int Minimum(int[] source)
        {
            if (source == null)
                throw new ArgumentNullException();
            if (source.Length == 0)
                throw new InvalidOperationException("Sequence contains no elements.");

            int minimum = 0;
            minimum = source.Min();
            return minimum;
        }

        public static int[] Mode(int[] source)
        {
            if (source == null)
                throw new ArgumentNullException();
            if (source.Length == 0)
                throw new InvalidOperationException("Sequence contains no elements.");
                
            var dictSource = source.ToLookup(x => x); // Konverterar arrayen till en Lookup
            var numberOfModes = dictSource.Max(x => x.Count()); // Hittar antalet av typvärden
            // Hämtar bara typvärdena
            int[] mode = dictSource.Where(x => x.Count() == numberOfModes).Select(x => x.Key).ToArray();
            
            return mode;
        }

        public static int Range(int[] source)
        {
            if (source == null)
                throw new ArgumentNullException();
            if (source.Length == 0)
                throw new InvalidOperationException("Sequence contains no elements.");

            int range = 0;
            range = source.Max() - source.Min();
            return range;
        }
        public static double StandardDeviation(int[] source)
        {
            if (source == null)
                throw new ArgumentNullException();
            if (source.Length == 0)
                throw new InvalidOperationException("Sequence contains no elements.");

            double devation = 0.0;
            int count = source.Count();
            double medel = Mean(source);
            double u = 0; 

            if (count > 1)
            {
                double sum = source.Sum(d=> (d-medel) * (d-medel));
                
                devation = Math.Sqrt(sum / count);
                u = devation;
            }
            return u;

            //varje number i listan minus medelvärde för att få avvikelse för varje nummer
            //kvadera varje avvikelsen för varje tal

            //plus ihop alla kvaderade avvikelser och dela det på antalet nummer
            //sedan roten ur på svaret och efter det har du standardavvikelsen

           
        }
    }
}
