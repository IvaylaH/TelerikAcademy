/*Write a program that calculates N!/K! for given N and K (1<K<N).*/

using System;
using System.Numerics;

    class NKFactorial
    {
        static void Main()
        {
            Console.Write("Please enter a number for K, such that 1 < K, K = ");
            int k = int.Parse(Console.ReadLine());
            Console.Write("Please enter a number for N, such that 1 < K < N, N = ");
            int n = int.Parse(Console.ReadLine());
            BigInteger factorialK = 1;
            BigInteger factorialN = 1;
            BigInteger result;

            if ((k > 1) && (k < n))
            {
                for (int i = 2; i <= k; i++) 
                {
                    factorialK *= i;
                }

                for (int i = 2; i <= n; i++)
                {
                    factorialN *= i;
                }
                result = factorialN / factorialK;

                Console.WriteLine();
                Console.WriteLine("The result of {0}! / {1}! = {2}", n, k, result);
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Invalid input. Please start over.");
            }
        }
    }