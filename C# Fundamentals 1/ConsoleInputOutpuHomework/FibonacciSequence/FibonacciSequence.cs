/*Write a program to print the first 100 members of the sequence of Fibonacci: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, …*/

using System;
using System.Numerics;

    class FibonacciSequence
    {
        static void Main()
        {
            BigInteger firstNum = 0;
            BigInteger secondNum = 1;
            BigInteger nextNum;

            Console.WriteLine("Fibonacci sequence: ");
            Console.WriteLine(firstNum);
            Console.WriteLine(secondNum);

            //since in the Fibonacci sequence the counting start from 0, which means F0 = 0; F1 = 1; F2 = 1; F3 = 2; ... Fn, and I start the count from: 1, 2, 3, ...n; in order to finish at the 100th member, the counter <= 101
            for (int counter = 3; counter <= 101; counter++)
            {
                nextNum = firstNum + secondNum;
                Console.WriteLine(nextNum);
                firstNum = secondNum;
                secondNum = nextNum;
            }
        }
    }
