using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace perfect_numbers
{
    class Program
    {

        static bool IsPerfectNumber(int number)
        {
            int sum = 0;
            for(int i= 1;i<number;i++)
            {
                if(number%i ==0)
                { sum += i; }
            }
            if (sum == number)
                return true;
            else
                return false;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(IsPerfectNumber(6));
            Console.WriteLine(IsPerfectNumber(7));
        }
    }
}
