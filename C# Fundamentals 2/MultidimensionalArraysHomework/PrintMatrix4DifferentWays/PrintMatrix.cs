/*Write a program that fills and prints a matrix of size (n, n) as shown below: (examples for n = 4)*/

using System;
using System.Collections.Generic;

class PrintMatrix
{
    static void PrintMatrixes(int[,] matrix)
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                if (matrix[row, col] > 9)
                {
                    Console.Write(" " + matrix[row, col] + " ");
                }
                else
                {
                    Console.Write("  " + matrix[row, col] + " ");
                }
            }
            Console.WriteLine();
        }
    }

    static void Main()
    {
        Console.WriteLine("Please enter a positive integer number for the size of the matrix, ");
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());

        int[,] matrix = new int[n, n];

        Console.BackgroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("\nMatrix - first way: ");

        //printing the matrix
        for (int row = 0; row < matrix.GetLength(0); row++)     //here I initialize and print the matrix at the same time
        {
            int currentCol = row + 1;
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                matrix[row, col] = currentCol;
                if (matrix[row, col] > 9)
                {
                    Console.Write(" " + matrix[row, col] + " ");
                }
                else
                {
                    Console.Write("  " + matrix[row, col] + " ");
                }
                currentCol += n;
            }
            Console.WriteLine();
        }
        Console.BackgroundColor = ConsoleColor.DarkMagenta;
        Console.WriteLine("\nMatrix - second way: ");

        //filling the matrix
        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int currentRow = 0;
                if ((col + 1) % 2 == 0)
                {
                    currentRow = (col + 1) * n - row;
                    matrix[row, col] = currentRow;
                }
                else
                {
                    currentRow = ((col + 1) * n - (n - 1)) + row;
                    matrix[row, col] = currentRow;
                }
            }
        }

        //printing the matrix - second way
        PrintMatrixes(matrix);

        Console.BackgroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine("\nMatrix - third way: ");

        //filling the matrix - I use 2 sets of nested for loops to initialize the matrix

        int filling = 1;
        for (int row = n - 1; row >= 0; row--)      //in the first set of nested loops I initialize the cells to the left of
        {                                           //the main diagonal of the matrix
            int currentRow = 0;

            for (int col = 0; col < n - row; col++)
            {
                currentRow = row + col;
                matrix[currentRow, col] = filling;
                filling++;                          //the variable filling increases with each iteration of the internal loop
            }                                       //it represents the value we're filling in the current cell
        }                                           //filling's max value is n^2

        for (int row = 0; row < matrix.GetLength(0) - 1; row++)        //with the second set of nested loops
        {                                                              //I fill the rest of the matrix 
            int currentRow = 0;                                        //(the cells to the right of the main diagonal)
            for (int col = 0; col < matrix.GetLength(1) - row; col++)
            {
                int currentCol = row + col + 1;

                if (currentCol <= n - 1)
                {
                    matrix[currentRow, currentCol] = filling;
                    currentRow++;
                    filling++;   
                }
            }
        }

        //printing the matrix
        PrintMatrixes(matrix);

        Console.BackgroundColor = ConsoleColor.DarkBlue;
        Console.WriteLine("\nMatrix - forth way(spiral): ");

        //filling the matrix

     /*   while (filling <= (n * n))
        {
            int currentRow = 0; //currentRow = 1;
            int currentCol = 0; //currentCol = 1;

            while (currentRow < n && currentCol < n) //(currentRow <= n && currentCol <= n)
            {
                if (currentCol == 0 && currentRow < n)
                {
                    currentRow++;
                    matrix[currentRow, currentCol] = filling;
                }
                if (currentRow == n - 1 && currentCol < n) //??!!!!!!
                {
                    currentCol++;
                    matrix[currentRow, currentCol] = filling;
                }
                if (currentCol == n - 1 && currentRow >= 0)
                {
                    currentRow--;
                    matrix[currentRow, currentCol] = filling;
                }
                if (currentRow == 0 && currentCol == n - 1)
                {
                    currentCol--;
                    matrix[currentRow, currentCol] = filling;
                }
                if (currentCol == 1 && currentRow <= n - 2)
                {
                    currentRow++;
                    matrix[currentRow, currentCol] = filling;
                }
                if (currentRow == n - 2 && currentCol <= n - 2 && currentCol != 0)
                {
                    currentCol++;
                    matrix[currentRow, currentCol] = filling;
                }
                if (currentCol == n - 2 && currentRow > 0)
                {
                    currentRow--;
                    matrix[currentRow, currentCol] = filling;
                }
                filling++;
            }
        }
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                if (matrix[row, col] > 9)
                {
                    Console.Write(" " + matrix[row, col] + " ");
                }
                else
                {
                    Console.Write("  " + matrix[row, col] + " ");
                }
            }
            Console.WriteLine();
        }*/

        int[,] spiral = new int[n, n];
        int maxCount = n * n;
        int presentRow = 0;
        int presentCol = 0;
        string direction = "down";

        for (int count = 1; count <= maxCount; count++)
        {
            spiral[presentRow, presentCol] = count;

            if (direction == "down")
            {
                presentRow++;
            }
            else if (direction == "right")
            {
                presentCol++;
            }
            else if (direction == "up")
            {
                presentRow--;
            }
            else if (direction == "left")
            {
                presentCol--;
            }

            if (direction == "down" && (presentRow >= n || spiral[presentRow, presentCol] != 0))
            {
                presentRow--;
                presentCol++;
                direction = "right";
            }
            else if (direction == "right" && (presentCol >= n || spiral[presentRow, presentCol] != 0))
	        {
                presentRow--;
                presentCol--;
                direction = "up";
	        }
            else if (direction == "up" && (presentRow < 0 || spiral[presentRow, presentCol] != 0))
            {
                presentRow++;
                presentCol--;
                direction = "left";
            }
            else if (direction == "left" && (presentCol < 0 || spiral[presentRow, presentCol] != 0))
            {
                presentRow++;
                presentCol++;
                direction = "down";
            }
        }

        PrintMatrixes(spiral);
        Console.WriteLine();
    }
}
