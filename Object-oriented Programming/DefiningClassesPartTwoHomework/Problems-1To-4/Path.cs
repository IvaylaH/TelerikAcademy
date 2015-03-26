using System;
using System.Collections.Generic;
using System.Text;

namespace Problems_1To_4
{
    public class Path
    {
        private List<Point3D> listOfPoints;

        // the constructor will create an instance of the class List<>
        public Path()
        {
            listOfPoints = new List<Point3D>();
        }

        // we declare the list holding the points as a private field and access it through its property
        public List<Point3D> ListOfPoints
        {
            get
            {
                return this.listOfPoints;
            }
        }

        // when acesses this method will be adding new points to our list of points
        public List<Point3D> AddPoints(Point3D newPoint)
        {
            listOfPoints.Add(newPoint);

            return listOfPoints;
        }

        // overriding of the ToString() so we can easily print the content of our list of points
        public override string ToString()
        {
            StringBuilder pointsSb = new StringBuilder();

            foreach (var point in listOfPoints)
            {
                pointsSb.Append("{");
                pointsSb.AppendFormat(" {0} {1} {2} ", point.XCoord, point.YCoord, point.ZCoord);
                pointsSb.Append("}");
                pointsSb.Append(Environment.NewLine);
            }

            return pointsSb.ToString();
        }
    }
}
