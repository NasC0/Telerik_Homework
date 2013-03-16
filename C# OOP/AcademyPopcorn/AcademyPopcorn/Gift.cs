using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyPopcorn
{
    public class Gift : MovingObject
    {
        public new const string CollisionGroupString = "gift";

        public Gift(MatrixCoords topLeft)
            : base(topLeft, new char[,] { { 'p' } }, new MatrixCoords(1, 0))
        {

        }

        public override bool CanCollideWith(string otherCollisionGroupString)
        {
            return otherCollisionGroupString == "racket";
        }

        public override IEnumerable<GameObject> ProduceObjects()
        {
            List<GameObject> producedObjects = new List<GameObject>();
            if (this.IsDestroyed == true)
            {
                producedObjects.Add(new ShootingRacket(new MatrixCoords(this.TopLeft.Row + 1, this.TopLeft.Col - 3), 6));
            }
            return producedObjects;
        }

        public override void RespondToCollision(CollisionData collisionData)
        {
            this.IsDestroyed = true;
        }
    }
}
