/** Write a program that calculates for given N how many trailing zeros present at the end of the number N!. Examples:
	N = 10  N! = 3628800  2
	N = 20  N! = 2432902008176640000  4
	Does your program work for N = 50 000?
	Hint: The trailing zeros in N! are equal to the number of its prime divisors of value 5. Think why!*/

using System;
using System.Numerics;

   class TrailingZeros
    {
        static void Main()
        {
            Console.Write("Please enter value for N, N = ");
            int n = int.Parse(Console.ReadLine());
            BigInteger factorialN = 1;
            int divisionResult = 0;
            int zeroNumber = 0;

            //Since in Mathematics a number is divisible by 5 without remainder only if it ends with 0 or 5. 5 multiplied by even number gives a number with 0 at the end. 5 multiplied by odd number, returns number ending with 5. Since in N! we are multiplying each number by the next one, then 5, 15, 25, ... multiplied by it's neighbour (which is an even number) will return 0 (number divisible by 10). In order to solve the task correctly we also need to find how many multiples do 25, 125 etc. have in the given range from 1 to N.

            for (int i = 2; i <= n; i++)
            {
                factorialN *= i;
            }
            divisionResult = n / 5;
            zeroNumber = divisionResult;
            while (divisionResult >= 1)
            {
                divisionResult /= 5;
                zeroNumber += divisionResult;
            }
            Console.WriteLine();
            Console.WriteLine("There are {0} trailing zeros present at the end of N!", zeroNumber);
        }
    }

