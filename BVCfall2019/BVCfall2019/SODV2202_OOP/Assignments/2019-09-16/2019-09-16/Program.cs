using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2019_09_16
{
    class Program
    {

        class Car
        {
            protected int wheels;
            protected int engine;

            

            public void Drive()
            {
                Console.WriteLine("Driving..");
            }

        }
        class PoliceCar : Car
        {
            protected int siren;

            public void TurnOnSiren()
            {
                Console.WriteLine("!!!!!!!!!!");
            }
        }

        static void Main(string[] args)
        {
            Car c1 = new Car();


            Console.WriteLine(c1.Drive();
        }
    }
}
