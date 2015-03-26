using System;
using System.Collections.Generic;
using System.Text;

namespace Problems_1To_4
{
    public static class CalcDistance
    {
        private static Point3D firstPoint = new Point3D();
        private static Point3D secondPoint = new Point3D();

        public static double CalculateDistanceBetweenPoints(Point3D firstPoint, Point3D secondPoint)
        {
            double distance = Math.Sqrt(((firstPoint.XCoord - secondPoint.XCoord) * (firstPoint.XCoord - secondPoint.XCoord)) + ((firstPoint.YCoord - secondPoint.YCoord) * (firstPoint.YCoord - secondPoint.YCoord)) + ((firstPoint.ZCoord - secondPoint.ZCoord) * (firstPoint.ZCoord - secondPoint.ZCoord)));
            
            return distance;
        }
    }
}
