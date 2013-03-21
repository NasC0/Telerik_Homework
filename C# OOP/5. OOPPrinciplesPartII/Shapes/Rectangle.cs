/* Task 1
 * Define class Rectangle that implements the virtual method and return the surface of the figure */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Rectangle : Shape
    {
        public Rectangle(double width, double height)
            : base(width, height)
        {
            
        }

        public override double CalculateSurface()
        {
            return this.Width * this.Height;
        }
    }
}
