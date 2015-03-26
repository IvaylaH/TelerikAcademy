using System;

namespace Problem1_Shape
{
    public class Rectangle : Shape
    {
        // constructors
        public Rectangle(double inputWidth, double inputHeigth)
        {
            this.Width = inputWidth;
            this.Heigth = inputHeigth;
        }

        // properties
        public double Width 
        {
            get { return this.width; }  // do I need to declare width/heigth variables here?? 
            set                         // should I do the validation in the base class /in this particular case/
            {
                if (value <= 0)
                {
                    throw new ArgumentException("The rectangle cannot have for width a negative number or 0!");
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
                    throw new ArgumentException("The rectangle cannot have for heigth a negative number or 0!");
                }

                this.heigth = value;
            }
        }
            
        // methods

        public override double CalculateSurface()
        {
            return this.Heigth * this.Width;
        }
    }
}
