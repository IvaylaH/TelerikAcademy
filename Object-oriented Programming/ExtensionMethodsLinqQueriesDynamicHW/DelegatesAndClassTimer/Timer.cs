/* Using delegates write a class Timer that can execute certain method at each t seconds.*/

using System;
using System.Collections.Generic;
using System.Threading;


namespace DelegatesAndClassTimer
{
    public delegate void CustomDelegate(int param);

    public class Timer
    {
        public static void ExecuteMeEachTSeconds(int seconds)
        {
            Console.WriteLine("Tick-tack! My {0} seconds have passed!", seconds);
            Console.WriteLine("See you again in {0} seconds!", seconds);
        }

        static void Main()
        {
            Console.WriteLine("Please enter a positive integer number for the seconds: ");
            Console.Write("t = ");
            int t = int.Parse(Console.ReadLine());

            CustomDelegate myDelegate = new CustomDelegate(ExecuteMeEachTSeconds);

            Console.WriteLine("Please enter a positive integer for the number of repetions of the method calling");
            Console.Write("repetitions = ");
            int repetitions = int.Parse(Console.ReadLine());


            // I am not sure if this is exactly what the problem is asking for, but still, here is my solution:
            for (int i = 0; i < repetitions; i++)
            {
                myDelegate(t);
                Thread.Sleep(t * 1000);
            }
        }
    }
}
