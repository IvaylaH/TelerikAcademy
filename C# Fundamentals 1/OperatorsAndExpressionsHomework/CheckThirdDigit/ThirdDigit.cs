/*Write an expression that checks for given integer if its third digit (right-to-left) is 7. E. g. 1732  true.*/

using System;

    class ThirdDigit
    {
        static void Main()
        {
            Console.WriteLine("Please enter a number of your choice.");
            int number = int.Parse(Console.ReadLine());

            if (number < 100)
            {
                Console.WriteLine("You have entered a two-digit number.");
                return;
            }
            if ((number > 100) && (number < 1000))
            {
                int result = number / 100;
                Console.WriteLine((result == 7) ? "The third digit in number {0} is 7." : "The third digit in number {0} is NOT 7.",number);
                return;
            }
            if (number > 1000)
            {
                int remainder = ((number / 100) % 10);
                Console.WriteLine((remainder == 7) ? "The third digit in number {0} is 7." : "The third digit in number {0} is NOT 7.", number);
            }
       }
    }