﻿/* Task 10.
 * Implement an ExplodingBlock. It should destroy all blocks 
 * around it when it is destroyed. You must NOT edit any existing .cs file. */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AcademyPopcorn
{
    public class ExplosionWave : MovingObject
    {
        public ExplosionWave(MatrixCoords topLeft, char[,] body, MatrixCoords speed)
            : base(topLeft, body, speed)
        {
            this.IsDestroyed = true;
        }

        public override bool CanCollideWith(string otherCollisionGroupString)
        {
            return otherCollisionGroupString == "block";
        }


        public override void Update()
        {
            this.IsDestroyed = true;
        }
    }
}
