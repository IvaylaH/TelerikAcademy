using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems_1_7
{
    class Display
    {
        // private fields
        private double? size;
        private int? numberOfColors;

        // properties
    /*    public double? Size 
        {
            get 
            {
                return this.size;
            }
            set 
            {
                if (size < 0)
                {
                    throw new ArgumentOutOfRangeException("Invalid input! The value you're entering should enter a positive number.");
                }
                else
                {
                    this.size = value;       
                }
            }
        }

        public int? NumOfColors
        {
            get 
            {
                return this.numberOfColors;
            }
            set 
            {
                if (numberOfColors < 0)
                {
                    throw new ArgumentOutOfRangeException("Invalid input! The value you're entering should enter a positive number.");
                }
                else
                {
                    this.numberOfColors = value;
                }
            }
        }*/

        //constructors
        public Display()
        {
            this.size = null;
            this.numberOfColors = null;
        }

        public Display(double size)
        {
            if (size < 0)
            {
                throw new ArgumentOutOfRangeException("Invalid input! The value you're entering should enter a positive number.");
            }
            else
            {
                this.size = size;
            }
            this.numberOfColors = null;
        }

        public Display(int numberOfColors)
        {
            this.size = null;
            if (numberOfColors < 0)
            {
                throw new ArgumentOutOfRangeException("Invalid input! The value you're entering should enter a positive number.");
            }
            else
            {
                this.numberOfColors = numberOfColors;
            }
        }

        public Display(double size, int numberOfColors)
        {
            if (size < 0)
            {
                throw new ArgumentOutOfRangeException("Invalid input! The value you're entering should enter a positive number.");
            }
            else
            {
                this.size = size;
            }
            if (numberOfColors < 0)
            {
                throw new ArgumentOutOfRangeException("Invalid input! The value you're entering should enter a positive number.");
            }
            else
            {
                this.numberOfColors = numberOfColors;
            }
        }

        public override string ToString()
        {
            return "Size: " + size.ToString() + " Display Colors: " + numberOfColors.ToString();
        }
    }
}
