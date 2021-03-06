﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AcademyPopcorn
{
    public class IndestructibleBlock : Block
    {
        public new const string CollisionGroupString = "indestructable block";
        public const char Symbol = '|';

        public IndestructibleBlock(MatrixCoords upperLeft)
            : base(upperLeft)
        {
            this.body[0, 0] = IndestructibleBlock.Symbol;
        }

        public override string GetCollisionGroupString()
        {
            return IndestructibleBlock.CollisionGroupString;
        }

        public override void RespondToCollision(CollisionData collisionData)
        {

        }
    }

    public class CopyOfIndestructibleBlock : Block
    {
        public new const string CollisionGroupString = "indestructable block";
        public const char Symbol = '|';

        public CopyOfIndestructibleBlock(MatrixCoords upperLeft)
            : base(upperLeft)
        {
            this.body[0, 0] = CopyOfIndestructibleBlock.Symbol;
        }

        public override string GetCollisionGroupString()
        {
            return CopyOfIndestructibleBlock.CollisionGroupString;
        }

        public override void RespondToCollision(CollisionData collisionData)
        {

        }
    }
}
