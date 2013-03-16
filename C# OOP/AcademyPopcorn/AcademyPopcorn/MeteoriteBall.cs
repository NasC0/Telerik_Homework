using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AcademyPopcorn
{
    public class MeteoriteBall : Ball
    {
        protected int trailObjectLifetime = 3;

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
