/*Write a program that prints the first 10 members of the sequence: 2, -3, 4, -5, 6, -7, ...*/

using System;

    class PrintsFirstMembers
    {
        static void Main()
        {
            int i = 2;

            for (i = 2; i <= 11; i++ )
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine("{0}", i);
                }
                else
                {
                    Console.WriteLine("{0}", i * (-1));
                }
            }
        }
    }
