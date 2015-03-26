/* *Write a program that exchanges bits {p, p+1, …, p+k-1) with bits {q, q+1, …, q+k-1} of given 32-bit unsigned integer.*/

using System;

    class ExchangeBitsGeneralCase
    {
        static void Main()
        {
            Console.Write("Please enter an integer number of your choice: ");
            uint number = uint.Parse(Console.ReadLine());
            Console.Write("Please enter a positive integer number less than 17 for p, p = ");
            int p = int.Parse(Console.ReadLine());
            Console.Write("Please enter a positive integer number greater than 16 for q, q = ");
            int q = int.Parse(Console.ReadLine());
            int k = 1;
            Console.Write("Please enter a max value for our coefficient k = ");
            uint maxValueK = uint.Parse(Console.ReadLine());
            Console.WriteLine();
            bool check = (p >= 0) && (p < 17);
            bool secondCheck = (q > 16) && (q < 33);

            Console.WriteLine("Number {0} in binary system is: \n{1}.\n", number, Convert.ToString(number,2).PadLeft(32, '0'));
            if ((check && secondCheck) == true)
            {
                for (int i = p + k - 1; i < 17; i++)
                {
                    for (int ii = q + k - 1; ii < 33; ii++)
                    {
                        bool valueK = k <= maxValueK;
                        if (valueK == true)
                        {
                            uint maskP = 1;
                            maskP = (uint)(1 << p);
                            uint numberAndMaskP = number & maskP;
                            uint bitP = numberAndMaskP >> p;

                            Console.WriteLine("The bit at position {0} is: {1}.", p, bitP);

                            uint maskQ = 1;
                            maskQ = (uint)(1 << q);
                            uint numberAndMaskQ = number & maskQ;
                            uint bitQ = numberAndMaskQ >> q;

                            Console.WriteLine("The bit at position {0} is: {1}.\n", q, bitQ);

                            uint nulledNumberP = number & (~maskP);
                            uint exchangedNumber = nulledNumberP | (bitQ << p);

                            uint nulledNumberQ = exchangedNumber & (~maskQ);
                            long finalNumber = nulledNumberQ | (bitP << q);

                            Console.WriteLine("The modified number is: {0}. In binary system it looks this way:\n{1}\n", finalNumber, Convert.ToString(finalNumber, 2).PadLeft(32, '0'));
                            k++;
                         }
                    }                    
                }    
            }           
        }
    }
