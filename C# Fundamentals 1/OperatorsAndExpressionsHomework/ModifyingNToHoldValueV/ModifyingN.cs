/*We are given integer number n, value v (v=0 or 1) and a position p. Write a sequence of operators that modifies n to hold the value v at the position p from the binary representation of n.
	Example: n = 5 (00000101), p=3, v=1  13 (00001101)
	n = 5 (00000101), p=2, v=0  1 (00000001)*/

using System;

    class ModifyingN
    {
        static void Main()
        {
            Console.Write("Please enter an interger number of your choice, n = ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Please enter either '1' or '0' as value for v, v = ");
            int v = int.Parse(Console.ReadLine());
            bool vCheck = (v == 0) || (v==1);

            if (vCheck == false)
            {
                Console.WriteLine("You have entered an invalid number for v.");
                return;
            }

            Console.Write("Please enter an integer number for the position p, p = ");
            int p = int.Parse(Console.ReadLine());

            while ((p >= 0) && (p <= 32))
            {
                if (v == 1)
                {
                    int firstMask = 1;
                    firstMask = 1 << p;
                    long newValueN = (long)(n | firstMask);
                    Console.WriteLine(n == newValueN ? "Number {0} already had {1} at position {2} so it remains the same." : "We have modified number {0} to hold {1} at position {2} and the new number is: {3}.", n,v,p,newValueN);
                    return;
                }
                else
                {
                    int secondMask = 1;
                    secondMask = ~(1 << p);
                    long secondNewValue = (long)(n & secondMask);
                    Console.WriteLine(n == secondNewValue ? "Number {0} already had {1} at position {2} so it remains the same." : "We have modified number {0} to hold {1} at position {2} and the new number is: {3}.", n, v, p, secondNewValue);
                    return;
                }
            }
            Console.WriteLine("You have entered an invalid number for p.");
        }
    }
