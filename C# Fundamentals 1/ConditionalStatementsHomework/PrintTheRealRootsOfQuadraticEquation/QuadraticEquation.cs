/*Write a program that enters the coefficients a, b and c of a quadratic equation
		a*x2 + b*x + c = 0
		and calculates and prints its real roots. Note that quadratic equations may have 0, 1 or 2 real roots.*/

using System;

    class QuadraticEquation
    {
        static void Main()
        {
            Console.Write("Please enter a number for the first coefficient, a = ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Please enter a number for the second coefficient, b = ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Please enter a number for the third coefficient, c = ");
            double c = double.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("We have the following quadratic equation: {0}x2 + ({1}x) + ({2}) = 0", a, b, c);

            double d = Math.Pow(b, 2) - (4 * a * c);

            Console.WriteLine("d = {0}", d);

            if (d > 0)
            {
                double sqrtD = Math.Sqrt(d);
                double x1 = (-(b) + sqrtD) / (2 * a);
                double x2 = (-(b) - sqrtD) / (2 * a);

                Console.WriteLine("The equation has 2 real roots: x1 = {0:f3} and x2 = {1:f3}\n", x1, x2);
            }
            else if (d == 0)
            {
                double x = -(b) / (2 * a);

                Console.WriteLine("The equation has 1 real root: x1,2 = {0:f3}\n", x);
            }
            else
            {
                Console.WriteLine("The equation has no real roots.\n");
            }
        }
    }
