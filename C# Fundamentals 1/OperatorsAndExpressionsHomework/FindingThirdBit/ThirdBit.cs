/*Write a boolean expression for finding if the bit 3 (counting from 0) of a given integer is 1 or 0.*/

using System;

    class ThirdBit
    {
        static void Main()
        {
            Console.WriteLine("Please enter a number of your choice.");
            int number = int.Parse(Console.ReadLine());
            int mask = 1;
            mask = 1 << 3;
            int numberAndMask = number & mask;
            int bit = numberAndMask >> 3;
            
            Console.WriteLine(bit);
            Console.WriteLine(bit == 0 ? "The third bit of the number {0} is 0." : "The third bit of the number {0} is 1.", number);
            
            //Second way of solving the problem

            Console.WriteLine("Please enter a new number.");
            int newNumber = int.Parse(Console.ReadLine());
            bool bit3 = (newNumber & 8) != 0;

            Console.WriteLine(bit3 == true ? "The third bit of the number {0} is 1." : "The third bit of the number {0} is 0.", newNumber);
        }
    }
