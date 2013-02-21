using System;

namespace GSMType.Common
{
    public class Display
    {
        private double? size;
        private int? colorsNumber;

        public Display(double? size)
            : this(size, null)
        {

        }

        public Display(double? size, int? colorsNumber)
        {
            this.size = size;
            this.colorsNumber = colorsNumber;
        }

        public double? Size
        {
            get { return this.size; }
            set { this.size = value; }
        }

        public int? ColorsNumber
        {
            get { return this.colorsNumber; }
            set { this.colorsNumber = value; }
        }
    }
}

