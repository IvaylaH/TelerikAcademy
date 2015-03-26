/*Write methods to calculate minimum, maximum, average, sum and product of given set of integer numbers. Use variable number of arguments.*/

using System;
using System.Collections.Generic;

class SetOfInts
{
    static int CalculateMin(int[] sequence, int start, int end)
    {
        int minNumber = int.MaxValue;

        for (int i = start; i <= end; i++)
        {
            if (minNumber > sequence[i])
            {
                minNumber = sequence[i];
            }
        }

        return minNumber;
    }

    static int CalculateMax(int[] sequence, int start, int end)
    {
        int maxNumber = int.MinValue;

        for (int i = start; i <= end; i++)
        {
            if (maxNumber < sequence[i])
            {
                maxNumber = sequence[i];
            }
        }

        return maxNumber;
    }

    static int CalculateAverage(int[] sequence, int start, int end)
    {
        int sum = 0;

        for (int i = start; i <= end; i++)
        {
            sum += sequence[i];
        }

        int average = sum / ((end - start) + 1);

        return average;
    }

    static void CalculateSumProduct(int[] sequence, int start, int end, out int sum, out int product)
    {
        sum = 0;
        product = 1;

        for (int i = start; i <= end; i++)
        {
            sum += sequence[i];
            product *= sequence[i];
        }
    }

    static bool CheckStartEnd(int start, int end, int[] sequence)
    {
        bool insideSequence = false;

        if (start >= 0 && end < sequence.Length)
        {
            insideSequence = true;

            return insideSequence;
        }
        else
        {
            insideSequence = false;

            return insideSequence;
        }
    }

    static void Main()
    {
        Console.WriteLine("Please enter a positive integer number for the length of the sequence, ");
        Console.Write("n = ");

        int n = int.Parse(Console.ReadLine());

        int[] numSequence = new int[n];

        Console.WriteLine("Please enter the elements of the sequence: ");

        for (int i = 0; i < n; i++)
        {
            numSequence[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Please enter a positive integer number for the start of the set, ");
        Console.Write("start = ");

        int startIndex = int.Parse(Console.ReadLine());

        Console.WriteLine("Please enter a positive integer number for the end of the set, ");
        Console.Write("end = ");

        int endIndex = int.Parse(Console.ReadLine());

        bool insideSequence = CheckStartEnd(startIndex, endIndex, numSequence);
        
        if (insideSequence)
        {
            Console.Write("\nWe are working with the following set of numbers: " );
            for (int i = startIndex; i <= endIndex; i++)
            {
                Console.Write(numSequence[i] + " ");
            }

            int minimum = CalculateMin(numSequence, startIndex, endIndex);
            int maximum = CalculateMax(numSequence, startIndex, endIndex);
            int average = CalculateAverage(numSequence, startIndex, endIndex);
            int sum;
            int product;

            CalculateSumProduct(numSequence, startIndex, endIndex, out sum, out product);

            Console.WriteLine();
            Console.WriteLine("\n --> the minimum number in the sequence is: {0} ", minimum);
            Console.WriteLine(" --> the maximum number in the sequence is: {0} ", maximum);
            Console.WriteLine(" --> the average of the numbers in the sequence is: {0} ", average);
            Console.WriteLine(" --> the sum of the elements of the sequence is: {0} ", sum);
            Console.WriteLine(" --> the product of the elements of the sequence is: {0} ", product);
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("\nEither the start or end index is outside the boarders of the sequence.");
            Console.WriteLine("Please start over!");
            Console.WriteLine();
        }
    }
}
