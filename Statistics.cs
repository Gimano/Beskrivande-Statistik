using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beskrivande_Statistik
{
    public static class Statistics
    {
        public static dynamic DescriptiveStatistics(int[] source)
        {
            return source;
        }

        public static int Maximum(int[] source)
        {
            int maximum = 0;
            maximum = source.Max();
            return maximum;
        }

        public static double Mean(int[] source)
        {
            double mean = 0;
            mean = source.Average();
            return Math.Round(mean, 1);
        }

        // Niklas
        public static int Median(int[] source)
        {
            Array.Sort(source);

            if (source.Length % 2 == 0)
                return (source[source.Length / 2 - 1] + source[source.Length / 2]) / 2;
            else
                return source[source.Length / 2];
        }

        // Niklas
        public static int Minimum(int[] source)
        {
            int minimum = 0;
            minimum = source.Min();
            return minimum;
        }

        public static int[] Mode(int[] source)
        {
            if (source == null)
                throw new ArgumentNullException("Sequence is null.");
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
            int range = 0;
            range = source.Max() - source.Min();
            return range;
        }
        public static double StandardDeviation(int[] source)
        {
            return (double)(source[0]);
        }
    }
}
