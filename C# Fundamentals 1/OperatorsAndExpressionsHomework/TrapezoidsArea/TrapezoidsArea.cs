/*Write an expression that calculates trapezoid's area by given sides a and b and height h.*/

using System;

    class TrapezoidsArea
    {
        static void Main()
        {
            Console.WriteLine("Please enter a positive number for the first side.");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter a positive number for the second side.");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter a positive number for the height.");
            int h = int.Parse(Console.ReadLine());

            
            if ((a > 0) && (b > 0) && (h > 0))
            {
                int trapeziodsArea = (a + b) * h / 2;
                Console.WriteLine("The area of the trapezoid is: " + trapeziodsArea);
                return;
            }
            Console.WriteLine("You have entered an invalid number for either the height or one of the sides of the trapezoid." );
        }
    }
