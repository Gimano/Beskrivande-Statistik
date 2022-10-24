//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Beskrivande_Statistik
//{
//    public static class Extensions
//    {
//        public static dynamic DescriptiveExtensions(int[] source)
//        {
//            Dictionary<string, dynamic> response = new Dictionary<string, dynamic>()
//            {
//                {"PrimeNumber", IsPrime(source)}
//            };
//            return response;
//        }
//            public static bool IsPrime(this int candidate)
//        {
//            for (int denominator = 2; denominator < candidate - 1; denominator++)
//                if (candidate % denominator == 0) return false;
//            return true;
//        }
//    }
//}
