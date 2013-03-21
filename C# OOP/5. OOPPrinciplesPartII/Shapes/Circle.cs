/* Task 1
 * Define class Circle and suitable constructor so that at initialization 
 * height must be kept equal to width and implement the CalculateSurface() method. */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Circle : Shape
    {
        public Circle(double width)
            : base(width, width)
        {

        }

        public override double CalculateSurface()
        {
            double area = (Math.PI * (this.Width * this.Width));
            return area;
        }
    }
}
