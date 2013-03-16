using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AcademyPopcorn
{
    public class ShootingRacket : Racket
    {
        private int charges = 1;
        
        public ShootingRacket(MatrixCoords topLeft, int width)
            : base(topLeft, width)
        {
        }

        public void ShootRacket()
        {
            if (charges > 0)
            {
                charges--;
            }
        }

        public override IEnumerable<GameObject> ProduceObjects()
        {
            if (this.charges == 0)
            {
                this.charges = 1;
                List<Bullet> bullets = new List<Bullet>();

                // create a new bullet object
                Bullet bullet = new Bullet(
                    new MatrixCoords(this.TopLeft.Row - 2, this.TopLeft.Col + this.Width / 2));

                // add the bullet to the list of bullets produced
                bullets.Add(bullet);

                return bullets;
            }
            else
            {
                return base.ProduceObjects();
            }
        }
    }
}
