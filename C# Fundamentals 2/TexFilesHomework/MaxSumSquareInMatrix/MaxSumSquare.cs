/* Write a program that reads a text file containing a square matrix of numbers and finds in the matrix an area of size 2 x 2 with a maximal sum of its elements. The first line in the input file contains the size of matrix N. Each of the next N lines contain N numbers separated by space. The output should be a single number in a separate text file. Example:
4
2 3 3 4
0 2 3 4			--> 17
3 7 1 2
4 3 3 2   */

using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

class MaxSumSquare
{
    static void Main()
    {
        StreamReader reader = new StreamReader("matrix.txt");
        StreamWriter writer = new StreamWriter("problem - solved.txt");

        string line = reader.ReadLine();
        int n = int.Parse(line);

        int[,] matrix = new int[4, 4];
        int startIndex = 0;
        int endIndex = 0;

        using (reader)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                line = reader.ReadLine();

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    string[] digits = line.Split(' ');
                    matrix[i, j] = int.Parse(digits[j]);
                }
            }
        }

        int maxSum = int.MinValue;

        for (int i = 0; i < matrix.GetLength(0) - 1; i++)
        {
            for (int j = 0; j < matrix.GetLength(1) - 1; j++)
            {
               int currentSum = matrix[i, j] + matrix[i, j + 1] + matrix[i + 1, j] + matrix[i + 1, j + 1];

                if (currentSum > maxSum)
                {
                    maxSum = currentSum;
                }

            }
        }

        using (writer)
        {
            writer.Write(maxSum);
        }
    }
}
