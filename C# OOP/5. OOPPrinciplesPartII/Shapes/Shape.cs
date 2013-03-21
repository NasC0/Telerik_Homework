/* Task 1
 * Define abstract class Shape with only one abstract method CalculateSurface() and fields width and height. */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public abstract class Shape
    {
        protected double width;
        protected double height;

        public Shape(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        public abstract double CalculateSurface();

        public double Width
        {
            get { return this.width; }
        }

        public double Height
        {
            get { return this.height; }
        }
    }
}
