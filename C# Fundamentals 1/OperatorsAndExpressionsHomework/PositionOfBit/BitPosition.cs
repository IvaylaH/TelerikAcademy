/*Write a boolean expression that returns if the bit at position p (counting from 0) in a given integer number v has value of 1. Example: v=5; p=1  false.*/

using System;

    class BitPosition
    {
        static void Main()
        {
            Console.WriteLine("Please enter and integer number of your choice.");
            int v = int.Parse(Console.ReadLine());
            int p = 4;
            int mask = 1;
            mask = 1 << p;
            int vAndMask = v & mask;
            int bit = vAndMask >> p;
            bool bitValue = (bit == 1);

            Console.WriteLine(bitValue == true ? "The bit at position {0} in number {1} is 1." : "The bit at position {0} in number {1} is 0.", p,v);
        }
    }