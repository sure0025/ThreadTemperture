using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadTemperture
{
    static class Temperture
    {


        public static void RandomGenerator()
        {
            Random random = new Random();
            int alarmCount = 0;
           

            while (alarmCount < 3)
            {
                int randomTemperture = random.Next(-20, 121);
                Console.WriteLine(randomTemperture);
                Thread.Sleep(2000);

                if (randomTemperture < 0 || randomTemperture > 100)
                {
                    Console.WriteLine("Alarm");
                    alarmCount++; 
                }
            }

        }

    }
}
