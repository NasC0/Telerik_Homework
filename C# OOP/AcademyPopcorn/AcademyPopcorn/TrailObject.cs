/* Task 5
 * Implement a TrailObject class. It should inherit the 
 * GameObject class and should have a constructor which 
 * takes an additional "lifetime" integer. The TrailObject 
 * should disappear after a "lifetime" amount of turns. 
 * You must NOT edit any existing .cs file. */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AcademyPopcorn
{
    public class TrailObject : GameObject
    {
        protected int Lifetime { get; set; }

        public TrailObject(MatrixCoords topLeft, char[,] body, int lifetime) : base(topLeft, body)
        {
            this.Lifetime = lifetime;
        }

        public override void Update()
        {
            Lifetime--;
            if (Lifetime == 0)
            {
                this.IsDestroyed = true;
            }
        }
    }
}
