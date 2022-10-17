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

        public static double Median(int[] source)
        {
            return Math.Sqrt(source[0]);
        }

        public static int Minimum(int[] source)
        {
            int minimum = 0;
            minimum = source.Min();
            return minimum;
        }

        public static int[] Mode(int[] source)
        {
            return source;
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
