/*Write a program to calculate the sum (with accuracy of 0.001): 1 + 1/2 - 1/3 + 1/4 - 1/5 + ...*/

using System;

    class SumWithAccuracy
    {
        static void Main()
        {
            double oldSum = 1.0;
            double newSum = 1.0;

            do
            {
                oldSum = newSum;
                for (int i = 2; i <= 1000; i++)
                {
                    if (i % 2 == 0)
                    {
                        newSum += (1.0 / i);
                    }
                    else
                    {
                        newSum -= (1.0 / i);
                    }
                }
            }
            while (Math.Abs(newSum - oldSum) < 0.001);

            Console.WriteLine("The new sum is: {0:f3}", newSum);
        }      
    }
