/*Write a program to calculate the Nth Catalan number by given N.*/

using System;
using System.Numerics;

class CatalanNumber
{
    static void Main()
    {
        Console.Write("Please enter value for N, such that N >= 0, N = ");
        int n = int.Parse(Console.ReadLine());
        BigInteger factorialN = 1;
        BigInteger factorial2N = 1;
        BigInteger factorialNPlusOne = 1;
        BigInteger product;
        BigInteger result;

        if (n >= 0)
        {
            for (int i = 2 * n; i > 0; i--)
            {
                factorial2N *= i;
            }
           
            for (int i = n + 1; i > 0; i--)
            {
                factorialNPlusOne *= i;
            }
            for (int i = 2; i <= n; i++)
            {
                factorialN *= i;
            }
            product = factorialNPlusOne * factorialN;
            result = factorial2N / product;

            Console.WriteLine();
            Console.WriteLine("The {0}th Catalan number is: {1}", n, result);
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine("Invalid input. Please start over and enter value for N in the specified range.");
        }

    }
}
