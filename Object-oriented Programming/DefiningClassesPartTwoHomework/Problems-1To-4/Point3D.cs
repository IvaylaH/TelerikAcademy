using System;
using System.Collections.Generic;
using System.Text;

namespace Problems_1To_4
{
    public struct Point3D
    {
        private double xCoord;
        private double yCoord;
        private double zCoord;

        private static readonly Point3D O = new Point3D(0, 0, 0);

        public Point3D(double x, double y, double z)
        {
            this.xCoord = x;
            this.yCoord = y;
            this.zCoord = z;
        }

        public double XCoord
        {
            get
            {
                return this.xCoord;
            }
            set
            {
                this.xCoord = value;
            }
        }

        public double YCoord
        {
            get
            {
                return this.yCoord;
            }
            set
            {
                this.yCoord = value;
            }
        }

        public double ZCoord
        {
            get
            {
                return this.zCoord;
            }
            set
            {
                this.zCoord = value;
            }
        }

        // the property has only access method /getter/ because O is a constant and we can only access it, but not change its initial value
        public static Point3D PointO 
        {
            get
            {
                return Point3D.O;
            }
        }

        public override string ToString()
        {
            StringBuilder pointSb = new StringBuilder();

            pointSb.AppendFormat("The X coordinate of our point is: {0}", this.XCoord); //?? xCoord || XCoord
            pointSb.Append(Environment.NewLine);
            pointSb.AppendFormat("The Y coordinate of our point is: {0}", this.YCoord);
            pointSb.Append(Environment.NewLine);
            pointSb.AppendFormat("The Z coordinate of our point is: {0}", this.ZCoord);
            pointSb.Append(Environment.NewLine);

            return pointSb.ToString();
        }
    }
}
