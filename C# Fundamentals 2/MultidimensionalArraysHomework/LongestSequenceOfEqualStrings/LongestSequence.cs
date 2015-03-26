/*We are given a matrix of strings of size N x M. Sequences in the matrix we define as sets of several neighbor elements located on the same line, column or diagonal. Write a program that finds the longest sequence of equal strings in the matrix.*/

using System;
using System.Collections.Generic;

class LongestSequence
{
    static void CheckHorizontals (string[,] matrix)
    {
        for (int row = 0; row < matrix.GetLength(0) - 1; row++)
        {
            string currentElement = "";
            int currentCount = 1;

            for (int col = row + 1; col < matrix.GetLength(1); col++)
            {
                if (currentElement == matrix[row, col])
                {
                    currentCount++;
                }
                else
                {
                    currentElement = matrix[row, col];
                }
            }
        }
    }
    static void Main()
    {
        Console.Write("Please enter a positive integer number for n, n = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Please enter a positive integer number for m, m = ");
        int m = int.Parse(Console.ReadLine());

        string[,] matrix = new string[n, m];

        Console.WriteLine("Please enter the elements of the matrix: ");

        //fillinf the matrix
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                matrix[row, col] = Console.ReadLine();
            }
        }

        //printing the matrix
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                if (matrix[row, col].Length > 1)
                {
                    Console.Write(" " + matrix[row, col]);
                }
                else
                {
                    Console.Write("  " + matrix[row, col]);
                }
            }
        }

        //looking throught the elements of the matrix
        string[] directions = new string[4] { "right", "down", "left", "up" };

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            string currentElement = "";
            string direction = "right";

            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                currentElement = matrix[row, col];

                if (col == matrix.GetLength(1)  - 1)
                {
                    direction = "down";

                    if (currentElement == matrix[row + 1, col])
                    {
                        currentElement = matrix[row + 1, col];
                        direction = "left";
                    }
                }
                else
	            {
                    if (currentElement == matrix[row, col + 1])
                    {
                        currentElement = matrix[row, col + 1];
                        direction = "down";
                    }
	            }
            }
        }
 /*       int count = 0;
        string sequenceElement = "";

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            string currentElement = "";
            int currentCount = 0;

            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                currentElement = matrix[row, col];
                if (row == 0 && col == 0)
                {
                    for (int nextRow = row; nextRow <= row + 1; nextRow++)
                    {
                        for (int nextCol = col; nextCol <= col + 1; nextCol++)
                        {
                            if (currentElement == matrix[nextRow, nextCol])
                            {
                                currentCount++;
                            }
                        }

                        if (currentCount > count)
                        {
                            count = currentCount;
                            sequenceElement = currentElement;
                        }
                    }
                }
                else if (row == 0 && col == matrix.GetLength(1) - 1)
                {
                    for (int nextRow = row - 1; nextRow <= row; nextRow++)
                    {
                        for (int nextCol = col; nextCol <= col + 1; nextCol++)
                        {
                            if (currentElement == matrix[nextRow, nextCol])
                            {
                                currentCount++;
                            }
                        }

                        if (currentCount > count)
                        {
                            count = currentCount;
                            sequenceElement = currentElement;
                        }
                    }
                }
                else if (row == 0 && (col != 0 || col != matrix.GetLength(1) - 1))
                {
                    for (int nextRow = row - 1; nextRow <= row + 1; nextRow++)
                    {
                        for (int nextCol = col; nextCol <= col + 1; nextCol++)
                        {
                            if (currentElement == matrix[nextRow, nextCol])
                            {
                                currentCount++;
                            }
                        }

                        if (currentCount > count)
                        {
                            count = currentCount;
                            sequenceElement = currentElement;
                        }
                    }
                }
                else if (row == 0 && (col != 0 || col != matrix.GetLength(1) - 1))
                {
                    for (int nextRow = row; nextRow <= row + 1; nextRow++)
                    {
                        for (int nextCol = col - 1; nextCol <= col + 1; nextCol++)
                        {
                            if (currentElement == matrix[nextRow, nextCol])
                            {
                                currentCount++;
                                row = nextRow;
                                col = nextCol;
                            }
                        }

                        if (currentCount > count)
                        {
                            count = currentCount;
                            sequenceElement = currentElement;
                        }
                    }
                }
                else if (row == matrix.GetLength(0) - 1 && (col != 0 || col != matrix.GetLength(1) - 1))
                {
                    for (int nextRow = row - 1; nextRow <= row; nextRow++)
                    {
                        for (int nextCol = col - 1; nextCol <= col + 1; nextCol++)
                        {
                            
                        }
                    }
                }
                else if (row == 0 && col == matrix.GetLength(1) - 1)
                {
                    for (int nextRow = row; nextRow <= row + 1; nextRow++)
                    {
                        for (int nextCol = col - 1; nextCol <= col; nextCol++)
                        {
                            if (currentElement == matrix[nextRow, nextCol])
                            {
                                currentCount++;
                            }
                        }

                        if (currentCount > count)
                        {
                            count = currentCount;
                            sequenceElement = currentElement;
                        }
                    }
                }
                else if (row == matrix.GetLength(0) - 1 && col == matrix.GetLength(1) - 1)
                {
                    for (int nextRow = row - 1; nextRow <= row; nextRow++)
                    {
                        for (int nextCol = col - 1; nextCol <= col; nextCol++)
                        {
                            if (currentElement == matrix[nextRow, nextCol])
                            {
                                currentCount++;
                            }
                        }

                        if (currentCount > count)
                        {
                            count = currentCount;
                            sequenceElement = currentElement;
                        }
                    }
                }
                else if ((row != 0 || row != matrix.GetLength(0) - 1) && col == matrix.GetLength(1) - 1)
                {
                    for (int nextRow = row - 1; nextRow < row + 1; nextRow++)
                    {
                        for (int nextCol = col - 1; nextCol <= col; nextCol++)
                        {
                            if (currentElement == matrix[nextRow, nextCol])
                            {
                                currentCount++;
                            }
                        }

                        if (currentCount > count)
                        {
                            count = currentCount;
                            sequenceElement = currentElement;
                        }
                    }
                }
            }
        }*/
    }
}
