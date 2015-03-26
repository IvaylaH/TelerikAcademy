/*Write a program that reads the radius r of a circle and prints its perimeter and area.*/

using System;

    class ReadRadius
    {
        static void Main()
        {
            Console.Write("Please enter a positive number for the radius, r = ");
            double r = double.Parse(Console.ReadLine());

            if (r > 0)
            {
                double squareR = r * r;
                double doubledR = 2 * r;
                double circlePerimeter = Math.PI * doubledR;
                double circleArea = Math.PI * squareR;

                Console.WriteLine("The perimeter of the circle is: {0:f3}.", circlePerimeter);
                Console.WriteLine("The area of the circle is: {0:f3}.", circleArea);
            }
            else
            {
                Console.WriteLine("You have entered an invalid number for r. Please start over.");
            }
        }
    }
