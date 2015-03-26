/*Write a program that reads the coefficients a, b and c of a quadratic equation ax2+bx+c=0 and solves it (prints its real roots).*/

using System;

    class QuadraticEquation
    {
        static void Main()
        {
            Console.WriteLine("We are given the quadratic equation: ax2 + bx +c=0. i order to solve it, please enter numbers for a, b and c.");
            Console.Write("a = ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b = ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("c = ");
            double c = double.Parse(Console.ReadLine());
            Console.WriteLine("Your quadratic equation is: {0}x2 + ({1}x) + ({2}) = 0\n", a, b, c);
            string equation = a +"x2 + (" + b + ")x + (" + c + ") = 0";
            double d = ((b * b) - 4 * (a) * (c));

            Console.WriteLine("d = {0}.\n", d);

            if (d > 0)
            {
                double firstX;
                double secondX;
                double sqrtD = Math.Sqrt(d);
                firstX = (- b + sqrtD) / (2 * a);
                secondX = (- b - sqrtD) / (2 * a);

                Console.WriteLine("The equation has 2 real roots:\nx1 = {0:f3} and x2 = {1:f3}.\n", firstX, secondX);
            }
            else if (d == 0)
            {
                double x = (-b) / (2 * a);
                Console.WriteLine("The equation has 1 real root:\nx = {0}.\n", x);
            }
            else
            {
                Console.WriteLine("The equation has no real roots.\n");
            }
        }
    }
