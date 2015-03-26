/*Write an expression that checks if given point (x,  y) is within a circle K(O, 5).*/

using System;

    class PointInCircle
    {
        static void Main()
        {
            Console.WriteLine("Please enter value for the x coordinate of the point.");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter value for the y coordinate of the point.");
            int y = int.Parse(Console.ReadLine());
            int radius = 5;
            bool pythagorean = (x * x) + (y * y) <= (radius * radius);

            Console.WriteLine(pythagorean == true ? "The point ({0},{1}) is within circle K (0,5)." : "The point ({0},{1}) is out of circle K (0,5).", x, y);
        }
    }