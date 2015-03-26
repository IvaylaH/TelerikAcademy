using System;
using System.Collections.Generic;

namespace Problem1_Shape
{
    public class Program_TestCalculateSurface
    {
        static void Main()
        {
            Shape[] shapes = 
            {
                new Circle(1.3),
                new Triangle(12, 3.5),
                new Rectangle(5.6, 7),
                new Circle(3.45)
            };

            foreach (var shape in shapes)
            {
                Console.WriteLine("Object of type: \"" + shape.GetType().Name + "\" has surface {0:f2}", shape.CalculateSurface());
            }
        }
    }
}
