using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AcademyPopcorn
{
    public class UnstoppableBall : Ball
    {
        public const char Symbol = '+';
        public new const string CollisionGroupString = "unstoppable ball";

        public UnstoppableBall(MatrixCoords topleft, MatrixCoords speed)
            : base(topleft, speed)
        {
            this.body[0, 0] = Symbol;
        }

        public override bool CanCollideWith(string otherCollisionGroupString)
        {
            return otherCollisionGroupString == "racket" || otherCollisionGroupString == "unpassable block"
                || otherCollisionGroupString == "block" || otherCollisionGroupString == "indestructable block";
        }

        public override string GetCollisionGroupString()
        {
            return UnstoppableBall.CollisionGroupString;
        }

        public override void RespondToCollision(CollisionData collisionData)
        {
            for (int i = 0; i < collisionData.hitObjectsCollisionGroupStrings.Count; i++)
            {
                if (collisionData.hitObjectsCollisionGroupStrings[i] != "block")
                {
                    base.RespondToCollision(collisionData);
                }
            }
        }
    }
}
