using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beskrivande_Statistik
{
    public static class Statistics
    {
        public static dynamic DescriptiveStatistics(int[] i)
        {
            return i;
        }

        public static int Maximum(int[] i)
        {
            return i[0];
        }

        public static double Mean(int[] i)
        {
            return (double)i[0];
        }

        public static double Median(int[] i)
        {
            return Math.Sqrt(i[0]);
        }

        public static int Minimum(int[] i)
        {
            return i[0];
        }

        public static int[] Mode(int[] i)
        {
            return i;
        }

        public static int Range(int[] i)
        {
            return i[0];
        }
        public static double StandardDeviation(int[] i)
        {
            return (double)(i[0]);
        }
    }
}
