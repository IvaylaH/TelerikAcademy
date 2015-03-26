/*Write a program that reads from the console a positive integer number N (N < 20) and outputs a matrix like the following:*/

using System;

    class PrintMatrix
    {
        static void Main()
        {
            Console.Write("Please enter value for N, such that N < 20, N = ");
            int n = int.Parse(Console.ReadLine());
            int row = n;

            if ((n > 0) && (n < 20))
            {
                for (int i = 1; i <= row; i++)
                {
                    if (i <= 9)
                    {
                        Console.Write(i + "  ");
                    }
                    else
                    {
                        Console.Write(i + " ");
                    }
                    
                    for (int j = i + 1; j <= i + n - 1; j++)
                    {
                        if (j <= 9)
                        {
                            Console.Write(j + "  ");
                        }
                        else
                        {
                            Console.Write(j + " ");
                        }
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Invalid input. Please start over and enter value in the specified range.");
            }
        }
    }