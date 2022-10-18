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
            return source[0];
        }

        public static double Mean(int[] source)
        {
            return (double)source[0];
        }

        public static double Median(int[] source)
        {
            return Math.Sqrt(source[0]);
        }

        public static int Minimum(int[] source)
        {
            return source[0];
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
            return source[0];
        }
        public static double StandardDeviation(int[] source)
        {
            return (double)(source[0]);
        }
    }
}
