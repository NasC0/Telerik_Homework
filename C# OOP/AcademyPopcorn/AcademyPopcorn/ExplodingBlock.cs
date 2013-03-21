/* Task 10.
 * Implement an ExplodingBlock. It should destroy all blocks 
 * around it when it is destroyed. You must NOT edit any existing .cs file. */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AcademyPopcorn
{
    public class ExplodingBlock : Block
    {
        public new const string CollisionGroupString = "block";
        public const char Symbol = '@';

        public ExplodingBlock(MatrixCoords topLeft )
            : base(topLeft)
        {
            this.body[0, 0] = Symbol;
        }

        public override IEnumerable<GameObject> ProduceObjects()
        {
            List<GameObject> explosions = new List<GameObject>();
            if (this.IsDestroyed == true)
            {
                explosions.Add(new ExplosionWave(this.TopLeft, new char[,] { { ' ' } }, new MatrixCoords(-1, -1)));
                explosions.Add(new ExplosionWave(this.TopLeft, new char[,] { { ' ' } }, new MatrixCoords(-1, 0)));
                explosions.Add(new ExplosionWave(this.TopLeft, new char[,] { { ' ' } }, new MatrixCoords(-1, 1)));
                explosions.Add(new ExplosionWave(this.TopLeft, new char[,] { { ' ' } }, new MatrixCoords(0, -1)));
                explosions.Add(new ExplosionWave(this.TopLeft, new char[,] { { ' ' } }, new MatrixCoords(0, 0)));
                explosions.Add(new ExplosionWave(this.TopLeft, new char[,] { { ' ' } }, new MatrixCoords(0, 1)));
                explosions.Add(new ExplosionWave(this.TopLeft, new char[,] { { ' ' } }, new MatrixCoords(1, -1)));
                explosions.Add(new ExplosionWave(this.TopLeft, new char[,] { { ' ' } }, new MatrixCoords(1, 0)));
                explosions.Add(new ExplosionWave(this.TopLeft, new char[,] { { ' ' } }, new MatrixCoords(1, 1)));
            }
            return explosions;
        }

        public override void RespondToCollision(CollisionData collisionData)
        {
            this.IsDestroyed = true;
        }
    }

    public class CopyOfExplodingBlock : Block
    {
        public new const string CollisionGroupString = "block";
        public const char Symbol = '@';

        public CopyOfExplodingBlock(MatrixCoords topLeft)
            : base(topLeft)
        {
            this.body[0, 0] = Symbol;
        }

        public override IEnumerable<GameObject> ProduceObjects()
        {
            List<GameObject> explosions = new List<GameObject>();
            if (this.IsDestroyed)
            {
                explosions.Add(new ExplosionWave(this.TopLeft, new char[,] { { ' ' } }, new MatrixCoords(-1, 0)));
                explosions.Add(new ExplosionWave(this.TopLeft, new char[,] { { ' ' } }, new MatrixCoords(0, -1)));
                explosions.Add(new ExplosionWave(this.TopLeft, new char[,] { { ' ' } }, new MatrixCoords(0, 1)));
                explosions.Add(new ExplosionWave(this.TopLeft, new char[,] { { ' ' } }, new MatrixCoords(1, 0)));
            }
            return explosions;
        }

        public override void RespondToCollision(CollisionData collisionData)
        {
            this.IsDestroyed = true;
        }
    }
}
