/*Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer.*/

using System;

    class ExchangeBits
    {
        static void Main()
        {
            Console.WriteLine("Please enter a positive integer number of your choice.");
            uint number = uint.Parse(Console.ReadLine());

            uint firstMask = 7;
            firstMask = 7 << 3;
            uint numberAndFirstMask = number & firstMask;
            uint firstSetOfBits = numberAndFirstMask >> 3;
            Console.WriteLine("The third, forth and fifth bit in the number {0} are: {1}.\n", number, Convert.ToString(firstSetOfBits, 2).PadLeft(3,'0'));

            uint secondMask = 7;
            secondMask = 7 << 24;
            uint numberAndSecondMask = number & secondMask;
            uint secondSetOfBits = numberAndSecondMask >> 24;
            Console.WriteLine("The twenty-forth, twenty-fifth and twenty-sixth bit in the number {0} are: {1}.\n", number, Convert.ToString(secondSetOfBits, 2).PadLeft(3,'0'));

            //for the 3, 4 and 5 bit:

            uint firstNull = number & (~firstMask);
            uint exchangedNumber = firstNull | (secondSetOfBits << 3);

            //for the 24, 25, and 26 bit:

            uint secondNull = exchangedNumber & (~secondMask);
            exchangedNumber = secondNull | (firstSetOfBits << 24);

            Console.WriteLine("Number {0} in binary system looks this way:\n{1}.\n", number, Convert.ToString(number, 2).PadLeft(32,'0'));
            Console.WriteLine("The modified number is {0}. In binary system it looks this way:\n{1}.\n", exchangedNumber, Convert.ToString(exchangedNumber,2).PadLeft(32, '0'));
        }
    }
