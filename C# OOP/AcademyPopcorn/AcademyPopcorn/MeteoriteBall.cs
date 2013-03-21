/* Task 6
 * Implement a MeteoriteBall. It should inherit the Ball class 
 * and should leave a trail of TrailObject objects. Each trail 
 * objects should last for 3 "turns". Other than that, the Meteorite 
 * ball should behave the same way as the normal ball. You must NOT 
 * edit any existing .cs file. */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AcademyPopcorn
{
    public class MeteoriteBall : Ball
    {
        private int trailObjectLifetime = 3;

        public MeteoriteBall(MatrixCoords topLeft, MatrixCoords speed)
            : base(topLeft, speed)
        {

        }

        public override IEnumerable<GameObject> ProduceObjects()
        {
            List<GameObject> producedObjects = new List<GameObject>();
            TrailObject trailingObject = new TrailObject(base.topLeft, new char[,] { { '*' } }, this.TrailLifetime);
            producedObjects.Add(trailingObject);
            return producedObjects;
        }

        public int TrailLifetime
        {
            get { return this.trailObjectLifetime; }
            set { this.trailObjectLifetime = value; }
        }
    }
}
