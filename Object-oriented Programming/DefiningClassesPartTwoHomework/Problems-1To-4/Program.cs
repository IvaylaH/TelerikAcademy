using System;
using System.Collections.Generic;
using System.Text;

namespace Problems_1To_4
{
    class Program
    {
        static void Main(string[] args)
        {
            // we are going to create some instances of class Point3D
            Point3D firstPoint = new Point3D(1.5, 10, 3.6);
            Point3D secondPoint = new Point3D(); //??!?
            Point3D thirdPoint = new Point3D(6.4, 7.1, 15);
            Point3D startPoint = Point3D.PointO;

            // checking if the method for calculating the distance works correctly
            double firstDistance = CalcDistance.CalculateDistanceBetweenPoints(firstPoint, secondPoint);
            double secondDistance = CalcDistance.CalculateDistanceBetweenPoints(firstPoint, thirdPoint);
            double thirdDistance = CalcDistance.CalculateDistanceBetweenPoints(secondPoint, startPoint);

            // printing the distances
            Console.WriteLine(firstDistance);
            Console.WriteLine(secondDistance);
            Console.WriteLine(thirdDistance);

            // declaring an isntace of class Path taht will hold the points we have already declared
            var listOfPoints = new Path();
            listOfPoints.AddPoints(firstPoint);
            listOfPoints.AddPoints(secondPoint);
            listOfPoints.AddPoints(thirdPoint);
            listOfPoints.AddPoints(startPoint);

            // printing the elements of our list of points using the overridden ToString()
            Console.WriteLine(listOfPoints.ToString());

            // saving the list we have already created and filld to a .txt file
            PathStorage.SavePath(listOfPoints);

            // loading new list of point from a .txt file 
            var newListOfPoints = PathStorage.LoadPath();

            // printing the new list of point on the Console
            Console.WriteLine(newListOfPoints.ToString());
        }
    }
}
