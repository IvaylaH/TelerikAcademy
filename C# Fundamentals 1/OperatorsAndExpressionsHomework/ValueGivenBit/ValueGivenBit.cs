/*Write an expression that extracts from a given integer i the value of a given bit number b. Example: i=5; b=2  value=1.*/

using System;

    class ValueGivenBit
    {
        static void Main()
        {
            Console.WriteLine("Please enter an integer number of your choice.");
            int i = int.Parse(Console.ReadLine());

            Console.WriteLine("Please choose and enter an integer number for the position we are going to check.");
            int b = int.Parse(Console.ReadLine());
            while ((b >= 0) && (b <= 33))
            {
                int mask = 1;
                // I take that 'b' is counting the number of bits in 'i' (1,2,3,...) not the position of the bit (0,1,2,3,...), therefore I'm using (b-1) to find the bit at bit number b.

                mask = 1 << (b - 1);
                long iAndMask = (long)(i & mask);
                long bit = iAndMask >> (b - 1);
                bool bitValue = bit == 1;

                Console.WriteLine(bit);
                Console.WriteLine(bitValue == true ? "In number {0} the bit at position {1} has value: 1." : "In number {0} the bit at position {1} has value: 0.", i,b);
                return;
            }
            Console.WriteLine("You have entered an invalid number for b.");
        }
    }
