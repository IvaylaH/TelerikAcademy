using System;

namespace Problem5_BitArray
{
    class TestBitArray64
    {
        static void Main()
        {
            ulong number = 135;
            BitArray64 numberBitsArr = new BitArray64(number);

            ulong secondNumber = 3592;
            BitArray64 secondNumBitsArr = new BitArray64(secondNumber);

            Console.WriteLine("Print the bits of the first array:");
            foreach (var bit in numberBitsArr)
            {
                Console.Write(bit);
            }

            Console.WriteLine();
            Console.WriteLine("Print the bits of the second array:");
            Console.WriteLine("{0}", string.Join("", secondNumBitsArr));

            Console.WriteLine();

            BitArray64 thirdArr = new BitArray64(secondNumber);
            Console.WriteLine("Print the bits of the third array:");
            Console.WriteLine("{0}", string.Join("", thirdArr));
            Console.WriteLine();

            Console.WriteLine("Result from comapring the first and second arrays:");
            CheckForEqualityAndPrintResult(numberBitsArr, secondNumBitsArr);

            Console.WriteLine("Result from comapring the second and third arrays:");
            CheckForEqualityAndPrintResult(secondNumBitsArr, thirdArr);
        }

        private static void CheckForEqualityAndPrintResult(BitArray64 firstArr, BitArray64 secondArr)
        {
            if (firstArr.Equals(secondArr))
            {
                Console.WriteLine("The 2 numbers are equal!");
            }
            else
            {
                Console.WriteLine("The 2 numbers are different!");
            }

            Console.WriteLine();
        }
    }
}
