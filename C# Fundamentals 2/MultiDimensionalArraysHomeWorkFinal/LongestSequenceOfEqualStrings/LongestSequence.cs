/* We are given a matrix of strings of size N x M. Sequences in the matrix we define as sets of several neighbor elements located on the same line, column or diagonal. Write a program that finds the longest sequence of equal strings in the matrix. */

using System;
using System.Collections.Generic;

class LongestSequence
{
    static void CheckHorizontals(string[,] matrix, out int maxCount, out string sequenceElement)
    {
        maxCount = 1;
        sequenceElement = "";

        for (int row = 0; row < matrix.GetLength(0); row++) //checking the horizontals
        {
            string currentElement = "";
            int currentCount = 1;

            for (int col = 0; col < matrix.GetLength(1) - 1; col++)
            {
                currentElement = matrix[row, col];

                if (currentElement == matrix[row, col + 1])
                {
                    currentCount++;
                }

                if (maxCount < currentCount)
                {
                    maxCount = currentCount;
                    sequenceElement = "direction --> horizontal; element \"" + currentElement + "\"";
                }
            }
        }
    }

    static void CheckVerticals(string[,] matrix, out int maxCount, out string sequenceElement)
    {
        maxCount = 1;
        sequenceElement = "";

        for (int col = 0; col < matrix.GetLength(1); col++)   //checking the verticals
        {
            string currentElement = "";
            int currentCount = 1;

            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                currentElement = matrix[row, col];

                if (currentElement == matrix[row + 1, col])
                {
                    currentCount++;
                }

                if (maxCount < currentCount)
                {
                    maxCount = currentCount;
                    sequenceElement = "direction --> vertical; element \"" + currentElement + "\"";
                }
            }
        }
    }

    static void CheckRightDiagonals(string[,] matrix, out int maxCount, out string sequenceElement)
    {
        maxCount = 1;
        sequenceElement = "";

        for (int col = 0; col < matrix.GetLength(1) - 1; col++) //checking diagonals - left to right
        {
            int currentCount = 1;
            string currentElement = "";

            for (int row = 0; row < matrix.GetLength(0) - 1; row++)     //check the matrix moving from left to right
            {
                int currentRow = row;
                int currentCol = col;

                while (currentCol < matrix.GetLength(1) - 1 && currentRow < matrix.GetLength(0) - 1)
                {
                    currentElement = matrix[currentRow, currentCol];

                    if (currentElement == matrix[currentRow + 1, currentCol + 1])
                    {
                        currentCount++;
                    }
                    else
                    {
                        break;
                    }

                    currentRow++;
                    currentCol++;
                }

                if (maxCount < currentCount)
                {
                    maxCount = currentCount;
                    sequenceElement = "direction --> left to right diagonal; element \"" + currentElement + "\"";
                }

                currentCount = 1;
            }
        }
    }

    static void CheckLeftDiagonals(string[,] matrix, out int maxCount, out string sequenceElement)
    {
        maxCount = 1;
        sequenceElement = "";

        for (int col = matrix.GetLength(1) - 1; col > 0; col--)     //check the matrix moving from right to left)
        {
            int currentCount = 1;
            string currentElement = "";

            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                int currentRow = row;
                int currentCol = col;

                while (currentRow < matrix.GetLength(0) - 1 && currentCol > 0)
                {
                    currentElement = matrix[currentRow, currentCol];

                    if (currentElement == matrix[currentRow + 1, currentCol - 1])
                    {
                        currentCount++;
                    }
                    else
                    {
                        break;
                    }

                    currentRow++;
                    currentCol--;
                }

                if (maxCount < currentCount)
                {
                    maxCount = currentCount;
                    sequenceElement = "direction --> right to left diagonal; element \"" + currentElement + "\"";
                }

                currentCount = 1;
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

        //filling the matrix                                    
        /* {ha fifi ho ho}      {ha fifi ho ha}   --> I used those 2 matrices to check whether the program works correct
            * {ha ha ha ho}        {fifi hi ha ha}
            * {hi hi ha ho}        {hi ha fifi ha}*/

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
            Console.WriteLine();
        }

        int horizontalCount = 1;
        string horizontalSequenceElement = "";
        int verticalCount = 1;
        string verticalSequenceElement = "";
        int rDCount = 1;                // rD == right diagonal (moves from left to right)
        string rDSequenceElement = "";
        int lDCount = 1;                //ld == left diagonal (moves from right to left)
        string lDSequenceElement = "";

        CheckHorizontals(matrix, out horizontalCount, out horizontalSequenceElement);
        CheckVerticals(matrix, out verticalCount, out verticalSequenceElement);
        CheckRightDiagonals(matrix, out rDCount, out rDSequenceElement);
        CheckLeftDiagonals(matrix, out lDCount, out lDSequenceElement);

        //here I put the different counts and elements in 2 arrays
        int[] counts = new int[4] { horizontalCount, verticalCount, rDCount, lDCount };
        string[] elements = new string[4] { horizontalSequenceElement, verticalSequenceElement, rDSequenceElement, lDSequenceElement };

        Array.Sort(counts, elements);       //sorting the arrays to get the max sequence and the corresponding element

        if (counts[counts.Length - 1] == 1)
        {
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.WriteLine();
            Console.WriteLine("There is no such sequence in the present matrix.");
            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.Black;
        }
        else
        {
            Console.Write("\nThe longest sequences found in the matrix are printed in green: ");
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Green;   //printing the count and element of the max sequence
            Console.WriteLine(counts[counts.Length - 1] + " - " + elements[elements.Length - 1]);

            for (int i = counts.Length - 2; i >= 0; i--)
            {
                if (counts[counts.Length - 1] == counts[i])     //checking if there's another sequence with the same length 
                {                                               //but different direction and printing the sequence if such is 
                    //found
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(counts[i] + " - " + elements[i]);
                }
            }

            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.Black;
        }
    }
}
