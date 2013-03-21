/* Task 12
 * Implement a GiftBlock class. It should be a block, which "drops" 
 * a Gift object when it is destroyed. You must NOT edit any existing .cs file. */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AcademyPopcorn
{
    public class GiftBlock : Block
    {
        public const char Symbol = '&';

        public GiftBlock(MatrixCoords topLeft)
            : base(topLeft)
        {
            this.body[0, 0] = Symbol;
        }

        public override IEnumerable<GameObject> ProduceObjects()
        {
            List<Gift> produceObjects = new List<Gift>();
            if (this.IsDestroyed == true)
            {
                produceObjects.Add(new Gift(this.topLeft));
            }
            return produceObjects;
        }

        public override void RespondToCollision(CollisionData collisionData)
        {
            this.IsDestroyed = true;
        }
    }
}
