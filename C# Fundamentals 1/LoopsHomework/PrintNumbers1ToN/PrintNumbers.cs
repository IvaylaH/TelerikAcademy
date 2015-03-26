/*Write a program that prints all the numbers from 1 to N.*/

using System;
using System.Numerics;

    class PrintNumbers
    {
        static void Main()
        {
            Console.Write("Please enter a number of your choice for n, n = ");
            int n = int.Parse(Console.ReadLine());
            long num = 1;

            while (num <= n)
            {
                Console.Write(num + " ");
                num++;
            }
            Console.WriteLine();
        }
    }
