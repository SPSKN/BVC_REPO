using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Threshold_Take_Us_To_The_Threshold
{ 
    /// <summary>
    /// Threshold
    /// </summary>
    class Program
    {
        public class cThreshold
        {
            public int threshold { get; set; }

            public bool IsGreater(int value)
            {
                return value > threshold;
            }
            public void PrintIf(int[] data, Predicate<int> predicate)
            {
                foreach (var d in data)
                    if (predicate(d))
                        Console.WriteLine(d);
            }
        }
       
        static void Main(string[] args)
        {
            cThreshold Threshold1 = new cThreshold();
            Threshold1.threshold = 4;


            int[] data = new int[] { 1, 2, 5, 7, 3 };
           // var com = new Comparer() { threshold = 3 };
           // Predicate<int> p = com.IsGreaterThan;

        }
    }
}
