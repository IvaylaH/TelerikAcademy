using System;

namespace Problem1_Shape
{
    public class Triangle : Shape
    {
        // cosntructors
        public Triangle(double inputWidth, double inputHeigth)
        {
            this.Width = inputWidth;
            this.Heigth = inputHeigth;
        }

        // properties
        public double Width
        {
            get { return this.width; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("The triangle cannot have for side a negative number or 0!");
                }

                this.width = value;
            }
        }

        public double Heigth
        {
            get { return this.heigth; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("The triangle cannot have for heigth a negative number or 0!");
                }

                this.heigth = value;
            }
        }

        // methods
        public override double CalculateSurface()
        {
            return (this.Width * this.Heigth) / 2;
        }
    }
}
