using System;

namespace Problem1_Shape
{
    public class Circle : Shape
    {
        // constructors
        public Circle(double radius)
        {
            this.Width = radius;
            this.Heigth = radius;
        }

        // properties
        public double Width
        {
            get { return this.width; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("The circle cannot have for radius a negative number or 0!");
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
                    throw new ArgumentException("The circle cannot have for radius a negative number or 0!");
                }

                this.heigth = value;
            }
        }
        // methods
        public override double CalculateSurface()
        {
            return Math.PI * this.Heigth * this.Width;
        }
    }
}
