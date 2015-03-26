/*Write a program that prints all the numbers from 1 to N, that are not divisible by 3 and 7 at the same time.*/

using System;

class NumbersNotDivisible
{
    static void Main()
    {
        Console.Write("Please enter a number of your choice for n, n = ");
        int n = int.Parse(Console.ReadLine());
      
        if (n > 0)
        {
                for (int num = 1; num <= n; num++)
                {
                    if (num % 21 != 0)
                    {
                        Console.Write(num + " ");
                    }
                }
        }
        else
        {
            for (int num = 1; num >= n; num--)
            {
                if (num % 21 != 0)
                {
                    Console.Write(num + " ");
                }
            }
        }

    }
}
