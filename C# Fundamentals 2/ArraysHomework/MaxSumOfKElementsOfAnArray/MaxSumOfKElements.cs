/*Write a program that reads two integer numbers N and K and an array of N elements from the console. Find in the array those K elements that have maximal sum.*/

using System;
using System.Collections.Generic;

class MaxSumOfKElements
{
    static int checkInput (string numberStr)
    {
        int number;
        bool check = int.TryParse(numberStr, out number);

        while (check == false || number <= 0)
        {
            Console.WriteLine("Invalid input!");
            Console.WriteLine("Please enter a positive integer number greater than 0.");
            numberStr = Console.ReadLine();
            check = int.TryParse(numberStr, out number);
        }
        return number;
    }
    static void Main()
    {   
        //I decide to solve the problem for a sequence of consequtive numbers with max sum.

        Console.Write("Please enter a positive integer number for n, n = ");
        int n = checkInput(Console.ReadLine());
        Console.Write("Please enter a positive integer number for k, k = ");
        int k = checkInput(Console.ReadLine());

        if (k <= n)
        {
            int[] myArr = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Please enter the element with index {0}", i);
                myArr[i] = int.Parse(Console.ReadLine());
            }

            if (k == 1)
            {
                int maxNumber = myArr[0];
                for (int nextElement = 1; nextElement < myArr.Length; nextElement++)
                {
                    if (maxNumber < myArr[nextElement])
                    {
                        maxNumber = myArr[nextElement];
                    }
                }

                Console.WriteLine("The max element of the array is: {0}", maxNumber);
            }
            else
            {
                int maxSum = int.MinValue;
                int startIndex = 0;

                for (int nextElement = 0; nextElement <= n - k; nextElement++)
                {
                    int sum = 0;
                    for (int kNumOfElements = 0; kNumOfElements < k; kNumOfElements++)
                    {
                        sum += myArr[nextElement + kNumOfElements];
                    }
                    if (maxSum < sum)
                    {
                        maxSum = sum;
                        startIndex = nextElement;
                    }
                }

                Console.WriteLine();
                Console.Write("The elements of the sequence with max sum are: ");

                for (int i = 0; i < k; i++)
                {
                    Console.Write("{0} ", myArr[startIndex + i]);
                }

                Console.WriteLine();
                Console.WriteLine("The max sum of those {0} elements is: {1}", k, maxSum);
            }
        }
        else
        {
            Console.WriteLine("The array has only {0} elements. Please start over and for k enter an integer number less than or equal to {0}", n);
        }
    }
}
