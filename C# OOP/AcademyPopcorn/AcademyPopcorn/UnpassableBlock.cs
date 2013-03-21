/* Task 8
 * Implement an indestructible UnpassableBlock. */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AcademyPopcorn
{
    public class UnpassableBlock : Block
    {
        public new const string CollisionGroupString = "unpassable block";
        public const char Symbol = '-';

        public UnpassableBlock(MatrixCoords topLeft)
            : base(topLeft)
        {
            this.body[0, 0] = Symbol;
        }

        public override string GetCollisionGroupString()
        {
            return UnpassableBlock.CollisionGroupString;
        }

        public override void RespondToCollision(CollisionData collisionData)
        {
            
        }
    }

    public class CopyOfUnpassableBlock : Block
    {
        public new const string CollisionGroupString = "unpassable block";

        public CopyOfUnpassableBlock(MatrixCoords topLeft)
            : base(topLeft)
        {

        }

        public override string GetCollisionGroupString()
        {
            return CopyOfUnpassableBlock.CollisionGroupString;
        }

        public override void RespondToCollision(CollisionData collisionData)
        {

        }
    }
}
