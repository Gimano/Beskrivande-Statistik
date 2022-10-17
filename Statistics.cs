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
            if (source == null || source.Length == 0)
                throw new ArgumentException("Array is empty.");

            var dictSource = source.ToLookup(x => x); // Convert the array to a Lookup

            // Find the number of modes
            var numberOfModes = dictSource.Max(x => x.Count());

            // Get only the modes
            var modes = dictSource.Where(x => x.Count() == numberOfModes).Select(x => x.Key);
            int[] mode = modes.ToArray();

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
