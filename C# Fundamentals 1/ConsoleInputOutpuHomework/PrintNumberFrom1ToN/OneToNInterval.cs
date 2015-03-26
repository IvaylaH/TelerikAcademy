/*Write a program that reads an integer number n from the console and prints all the numbers in the interval [1..n], each on a single line.*/

using System;

    class OneToNInterval
    {
        static void Main()
        {
            Console.Write("Please enter a positive integer number for n, n = ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();
            bool valueN = n > 0;
            if (valueN == true)
            {
                for (int i = 1; i <= n; i++)
                {
                    Console.WriteLine(" " + i);
                }
                Console.WriteLine();
            }
            else
            {
                for (int j = 1; j >= n; j--)
                {
                    Console.WriteLine("{0, 10} ", j);
                }
                Console.WriteLine();
            }
            
        }
    }
