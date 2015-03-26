/*Write a program that calculates N!*K! / (K-N)! for given N and K (1<N<K).*/

using System;
using System.Numerics;

    class ProductNK
    {
        static void Main()
        {
            Console.Write("Please enter a value for N, such that N > 1, N = ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Please enter a value for K, such that K > N > 1, K = ");
            int k = int.Parse(Console.ReadLine());
            int difference = k - n;
            BigInteger factorialN = 1;
            BigInteger factorialK = 1;
            BigInteger FactorialDifference = 1;
            BigInteger product;
            BigInteger result;

            if ((difference >= 1) && (n >= 1))
            {
                while (n >= 1)
                {
                    factorialN *= n;
                    n--;
                }

                while (k >= 1)
                {
                    factorialK *= k;
                    k--;
                }
                while (difference >= 1)
                {
                    FactorialDifference *= difference;
                    difference--;
                }
                product = factorialN * factorialK;
                result = product / FactorialDifference;

                Console.WriteLine();
                Console.WriteLine("The result of: n! * k! / (k - n)! = {0}", result);
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Invalid input. Please start over.");
            }
        }
    }
