/*We are given 5 integer numbers. Write a program that checks if the sum of some subset of them is 0. Example: 3, -2, 1, 1, 8  1+1-2=0.*/

using System;

class SubsetSum
{
    static void Main()
    {   //The problem is solved using bitwise operators
        Console.WriteLine("Please enter value for N, N = "); // If you enter a number for N bigger than 5 the program is still 
        int n = int.Parse(Console.ReadLine());               // working.
        int[] numbers = new int[n];
        int count = 0;
        int tempSum = 0;

        Console.WriteLine("Please enter your {0} numbers: ", n);

        for (int i = 0; i < n; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        int maxValueI = (int)Math.Pow((double)2, n);// maxValueI gives the number of the different combinations between all n numbers
                                                    //for which the sum of the subset is 0;
                                                    // in order to exclude the zero set we do this: maxValueI - 1
        for (int i = 1; i <= maxValueI - 1; i++)
        {
            tempSum = 0;
            for (int j = 0; j < numbers.Length; j++) //
            {
                int mask = 0;
                mask = 1 << j;
                int iAndMask = i & mask;            // we apply the mask for each and every number between 1 and maxValueI - 1
                int bit = iAndMask >> j;

                if (bit == 1)
                {
                    tempSum += numbers[j];
                }
            }
            if (tempSum == 0)
            {
                count++;
            }
        }
        if (count != 0)
        {
            Console.WriteLine("In those {0} numbers there is/are {1} subsets whose sum is 0.", n, count);
        }
        else
        {
            Console.WriteLine("In those {0} numbers there are no subsets whose sum is 0.", n);
        }
    }
}