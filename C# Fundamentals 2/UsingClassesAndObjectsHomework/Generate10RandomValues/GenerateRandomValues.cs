/* Write a program that generates and prints to the console 10 random values in the range [100, 200].*/

using System;
using System.Collections.Generic;
using System.Text;

class GenerateRandomValues
{
    static void Main()
    {
        Random randGenerator = new Random();

        Console.WriteLine("We have a sequence of the following randomly generated numbers: ");

        for (int i = 1; i <= 10; i++)
        {
            int randNumber = randGenerator.Next(100, 201);
            Console.Write(" {0}", randNumber);
        }

        Console.WriteLine();
    }
}
