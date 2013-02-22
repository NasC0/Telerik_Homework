using System;

namespace GSMType.Common
{
    public class Display
    {
        private double? size;
        private int? colorsNumber;

        public Display() : this(null, null)
        {
            
        }

        public Display(double? size)
            : this(size, null)
        {

        }

        public Display(double? size, int? colorsNumber)
        {
            if (size <= 0)
            {
                throw new ArgumentException();
            }
            else
            {
                this.size = size;
            }
            if (colorsNumber <= 0)
            {
                throw new ArgumentException();
            }
            else
            {
                this.colorsNumber = colorsNumber;
            }
        }

        public double? Size
        {
            get { return this.size; }
            set 
            {
                if (value <= 0)
                {
                    throw new ArgumentException();
                }
                else
                {
                    this.size = value;
                }
            }
        }

        public int? ColorsNumber
        {
            get { return this.colorsNumber; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException();
                }
                else
                {
                    this.colorsNumber = value;
                }
            }
        }
    }
}

