/* Write methods that calculate the surface of a triangle by given:
Side and an altitude to it; Three sides; Two sides and an angle between them. Use System.Math.*/

using System;
using System.Collections.Generic;
using System.Text;

class TriangleSurface
{
    static double CalculateUsingSideAndAltitude()
    {
        Console.WriteLine("\nPlease enter a side and the altitude towards it.");
        Console.Write("side = ");
        double side = double.Parse(Console.ReadLine());

        Console.WriteLine();

        Console.Write("altitude = ");
        double altitude = double.Parse(Console.ReadLine());

        double surface = 0.5 * (side * altitude);

        return surface;
    }

    static double CalculateUsingThreeSides()        //using Heron's formula
    {
        Console.WriteLine("Please enter all 3 sides of the triangle: ");
        Console.Write("first side = ");
        double firstSide = double.Parse(Console.ReadLine());

        Console.WriteLine();

        Console.Write("second side = ");
        double secondSide = double.Parse(Console.ReadLine());

        Console.WriteLine();

        Console.Write("third side = ");
        double thirdSide = double.Parse(Console.ReadLine());

        double s = (firstSide + secondSide + thirdSide) / 2;
        double surface = Math.Sqrt(s * (s - firstSide) * (s - secondSide) * (s - thirdSide));

        return surface;
    }

    static double CaltulateUsingTwoSidesAndAngle()
    {
        Console.WriteLine("Please enter 2 of the sides of the trianle and the angle between them: ");
        Console.Write("first side = ");
        double firstSide = double.Parse(Console.ReadLine());

        Console.WriteLine();

        Console.Write("second side = ");
        double secondSide = double.Parse(Console.ReadLine());

        Console.WriteLine();

        Console.Write("angle = ");
        int angle = int.Parse(Console.ReadLine());

        double surface = 0.5 * firstSide * secondSide * Math.Sin(angle);

        return surface;
    }


    static void Main()
    {
        Console.WriteLine("The present program will calculate the surface of a tringle of your choice.");
        Console.WriteLine("Please enter some information for the triangle: ");
        Console.WriteLine("\nFrom the following menu choose: ");
        Console.WriteLine("\n '1' --> if you would like the program to calculate the surface using a side and the altitude towards it.");
        Console.WriteLine(" '2' --> if you would like the program to calculate the surface using all 3 sides of the triangle.");
        Console.WriteLine(" '3' --> if you would like the program to calculate the surface using 2 of the sides of the triangle and the angle between them.");

        int input = int.Parse(Console.ReadLine());
        double surface = 0;

        if (input == 1)
        {
            surface = CalculateUsingSideAndAltitude();

            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("\nThe surface of the triangle is: {0:f2}", surface);

            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine();
        }
        else if (input == 2)
        {
            surface = CalculateUsingThreeSides();

            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("\nThe surface of the triangle is: {0:f2}", surface);

            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine();
        }
        else if (input == 3)
        {
            surface = CaltulateUsingTwoSidesAndAngle();

            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("\nThe surface of the triangle is: {0:f2}", surface);

            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine();
        }
    }
}
