/*Write a program that, for given two integer numbers N and X, calculates the sumS = 1 + 1!/X + 2!/X2 + … + N!/XN */

using System;
using System.Numerics;

    class SumOfNAndX
    {
        static void Main()
        {
            Console.Write("Please enter value for N, N = ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Please enter value for X, X = ");
            int x = int.Parse(Console.ReadLine());
            decimal powerX;
            BigInteger factorialN = 1;
            decimal sum = 1;

            for (int i = 1; i <= n; i++)
            {
                factorialN *= i;
                powerX = (int)Math.Pow(x, i);
                sum += ((decimal)factorialN / powerX);
            }
            Console.WriteLine("Sum = {0:f3}", sum);
        }
    }
