/*Write an expression that checks if given positive integer number n (n ≤ 100) is prime. E.g. 37 is prime.*/

using System;

    class PrimeNumbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a positive integer number less than or equal to 100.");
            int number = int.Parse(Console.ReadLine());

            if ((number < 2) || (number > 100))
            {
                Console.WriteLine("Invalid number.");
                return;
            }

            bool primeNum = ((number == 2) || (number == 3) || (number == 5) || (number == 7)) ^ ((number % 2 != 0) && (number % 3 != 0) && (number % 5 != 0) && (number % 7 != 0));
            Console.WriteLine(primeNum == true ? "Number {0} is prime." : "Number {0} is NOT prime.",number);

            //Solving the problem using loops.

            Console.WriteLine("Please enter a new positive integer number less than or equal to 100." );
            int n = int.Parse(Console.ReadLine());

            if ((n < 2) || (n > 100))
            {
                Console.WriteLine("Invalid number.");
                return;
            }

            int divider;
            for (divider = 2; divider <= (int)Math.Sqrt(n); divider++)
            {
                int remainder = n % divider;
                if (remainder == 0)
                {
                    Console.WriteLine("Number {0} is NOT prime and can be divided by {1}: {1} * {2} = {0}.", n, divider, n / divider);
                    return;
                }
            }
                Console.WriteLine("Number {0} is prime.", n);
        }
    }
