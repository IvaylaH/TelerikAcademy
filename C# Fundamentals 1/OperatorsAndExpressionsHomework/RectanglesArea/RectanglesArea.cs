/*Write an expression that calculates rectangle’s area by given width and height.*/

using System;

    class RectanglesArea
    {
        static void Main()
        {
            Console.WriteLine("Please enter a number for the height.");
            int height = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter a number for the width.");
            int width = int.Parse(Console.ReadLine());
            string RectanglesArea = "The area = " + (height * width) + ".";

            Console.WriteLine(RectanglesArea);
        }
    }
