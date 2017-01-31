using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadTemperture
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Start");

            Thread thread = new Thread(new ThreadStart(Temperture.RandomGenerator));
            thread.Start();


            thread.Join();
            thread.Abort();
            Console.WriteLine("\nEnter for Exit");
            Console.ReadLine();
            Console.WriteLine("EXIT");
        }
    }
}
