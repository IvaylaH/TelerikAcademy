/*Write a program that reads from the console a sequence of N integer numbers and returns the minimal and maximal of them.*/

using System;

    class MinMaxOfN
    {
        static void Main()
        {
            Console.Write("Please enter a positive integer number for n, n = ");
            int n = int.Parse(Console.ReadLine());

            int[] numbers = new int[n];
            Console.Write("Please enter a number of your choice: ");
            int firstNum = int.Parse(Console.ReadLine());
            int maxNum = firstNum;
            int minNum = int.MaxValue;

            for (int i = 0; i < n - 1; i++)
            {
                Console.Write("Please enter a number of your choice: ");
                numbers[i] = int.Parse(Console.ReadLine());
                if (maxNum < numbers[i])
                {
                    maxNum = numbers[i];
                }
                if (minNum > numbers[i])
                {
                    minNum = numbers[i];
                }
            }
            if (minNum > firstNum)
            {
                minNum = firstNum;
            }
            Console.WriteLine("The maximal number of the sequence is: {0}", maxNum);
            Console.WriteLine("The minimal number of the sequence is: {0}", minNum);

        }
    }
