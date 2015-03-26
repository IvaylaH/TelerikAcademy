/*Write an expression that checks for given point (x, y) if it is within the circle K( (1,1), 3) and out of the rectangle R(top=1, left=-1, width=6, height=2).*/

using System;

    class CircleRectanglePoint
    {
        static void Main()
        {
            Console.WriteLine("Please enter a number for the x coordinate of the point.");
            double x = double.Parse(Console.ReadLine());

            Console.WriteLine("Please enter a number for the y coordinate of the point.");
            double y = double.Parse(Console.ReadLine());

            bool check;
            check = ((y >= -3) && (y <= -1.1)) ^ ((y >= 1.1) && (y <= 3));
            bool secondCheck;
            secondCheck = ((y > -1.1) && (y < 1.1)) && ((x > -1) && (x < 5));
            bool pythagorean = (x * x) + (y * y) <= (3 * 3);
                
                if ((check == true) && (pythagorean == true))
                {
                    Console.WriteLine("Point ({0},{1}) is within circle K and out of rectangle R.", x,y);
                    return;
                }
                else
                {
                    Console.WriteLine(secondCheck == true ? "Point ({0},{1}) is out of circle K but within rectangle R." : "Point ({0},{1}) is out of circle K and out of rectangle R.", x,y);
                }
        }
    }
   
