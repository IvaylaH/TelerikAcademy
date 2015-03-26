/*Write a program that reads a number N and calculates the sum of the first N members of the sequence of Fibonacci: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, …
Each member of the Fibonacci sequence (except the first two) is a sum of the previous two members.*/

using System;
using System.Numerics;

class FibonacciSum
{
    static void Main()
    {
        Console.Write("Please enter positive integer number for N, N = ");
        int n = int.Parse(Console.ReadLine());
        long firstNum = 0;
        long secondNum = 1;
        long thirdNum;
        BigInteger sum = 1;

        for (int i = 1; i <= (n - 2); i++)
        {
            thirdNum = firstNum + secondNum;
            sum += thirdNum;
            firstNum = secondNum;
            secondNum = thirdNum;
        }
        Console.WriteLine();
        Console.WriteLine("The sum of the first {0} members of the Fibonacci sequence is: {1}", n, sum);
    }
}

