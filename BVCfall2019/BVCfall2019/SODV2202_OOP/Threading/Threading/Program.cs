using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Threading
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread t = new Thread(work1);
            /// new Thread(work1).Start();  /// Alternate
            Thread t2 = new Thread(work2);
            /// new Thread(work2).Start();   /// Alternate
            t.Start();
            t2.Start();
        }
        public static void work1()
        {
            int k;                          /// for display
            for (int i = 0; i != 100; i++)
            {
                k = i + 1;
                Console.WriteLine("y  " + k);
            }
        }

        public static void work2()
        {
            int k;                          /// for display
            for (int i = 0; i != 100; i++)
            {
                k = i + 1;
                Console.WriteLine("x  " + k);
            }
        }
    }
}
