/*Write a program that reads a rectangular matrix of size N x M and finds in it the square 3 x 3 that has maximal sum of its elements.*/

using System;
using System.Collections.Generic;

class SquareWithMaxSum
{
    static void Main()
    {
        Console.Write("Please enter a positive integer number for n, n = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Please enter a positive integer number for m, m = ");
        int m = int.Parse(Console.ReadLine());

        int[,] matrix = new int[n, m];

        Console.WriteLine("Please enter the elements of the matrix: ");

        //filling the matrix
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                matrix[row, col] = int.Parse(Console.ReadLine());
            }
        }

        //printing the matrix

        Console.WriteLine();
        Console.WriteLine("This is the matrix we'll be checking:");

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                if (matrix[row, col] > 9)
                {
                    Console.Write(" " + matrix[row, col]);
                }
                else
                {
                    Console.Write("  " + matrix[row, col]);
                }

            }
            Console.WriteLine();
        }

        Console.WriteLine();
        Console.Write("Please enter a positive integer number for the dimensions of the square we'll be checking, k = ");
        int k = int.Parse(Console.ReadLine());

        bool hasSquare = false;
        int maxSum = int.MinValue;
        int[,] squareMatrix = new int[k, k];

        if (k > n || k > m)
        {
            Console.WriteLine();
            Console.WriteLine("In the matrix we're checking there is no such square with dimensions {0} x {0}!", k);
        }
        else
        {
            for (int row = 0; row <= matrix.GetLength(0) - k; row++) // finding the square matrix
            {
                int currentElement = 0;

                for (int col = 0; col <= matrix.GetLength(1) - k; col++)
                {
                    currentElement = matrix[row, col];
                    int tempSum = 0;

                    for (int currentRow = row; currentRow < row + k; currentRow++)
                    {
                        for (int currentCol = col; currentCol < col + k; currentCol++)
                        {
                            tempSum += matrix[currentRow, currentCol];
                        }
                    }

                    if (tempSum > maxSum)
                    {
                        maxSum = tempSum;
                        hasSquare = true;
                        for (int currentRow = 0; currentRow < squareMatrix.GetLength(0); currentRow++) //!!
                        {
                            for (int currentCol = 0; currentCol < squareMatrix.GetLength(1); currentCol++) //!!
                            {
                                squareMatrix[currentRow, currentCol] = matrix[row + currentRow, col + currentCol];
                            }
                        }
                    }
                }
            }

            //priting the square matrix

            Console.WriteLine();
            Console.WriteLine("The square with maximal sum and dimensions {0} x {0} in the matrix is: ", k);

            for (int row = 0; row < squareMatrix.GetLength(0); row++)
            {
                for (int col = 0; col < squareMatrix.GetLength(1); col++)
                {
                    if (squareMatrix[row, col] > 9)
                    {
                        Console.Write(" " + squareMatrix[row, col]);
                    }
                    else
                    {
                        Console.Write("  " + squareMatrix[row, col]);
                    }
                }
                Console.WriteLine();
            }
        }

        if (hasSquare)
        {
            Console.WriteLine("The max sum = {0}", maxSum);
        }
    }
}