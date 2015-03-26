using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Problems_1To_4
{
    public static class PathStorage
    {
        private static Path newListOfPoints;

        public static void SavePath(Path myListOfPoints)
        {
            StreamWriter writer = new StreamWriter("PathStorage.txt", false);

            using (writer)
            {
                writer.WriteLine(myListOfPoints.ToString());
            }

        }

        public static Path LoadPath()
        {
            newListOfPoints = new Path();

            StreamReader reader = new StreamReader("PathStorage.txt");

            using(reader)
            {
                string line = reader.ReadLine();

                while (line != string.Empty)
                {
                    string[] pointCoords = line.Split(new char[] { ' ', '{', '}' }, StringSplitOptions.RemoveEmptyEntries);

                    double xCoord = double.Parse(pointCoords[0]); //??
                    double yCoord = double.Parse(pointCoords[1]);
                    double zCoord = double.Parse(pointCoords[2]);

                    newListOfPoints.AddPoints(new Point3D(xCoord, yCoord, zCoord));
                    line = reader.ReadLine();
                }
            }

            return newListOfPoints;
        }
    }
}
