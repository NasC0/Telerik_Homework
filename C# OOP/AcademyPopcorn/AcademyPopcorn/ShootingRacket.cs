/* Task 13
 * Implement a shoot ability for the player racket. The ability should only 
 * be activated when a Gift object falls on the racket. The shot objects 
 * should be a new class (e.g. Bullet) and should destroy normal Block objects 
 * (and be destroyed on collision with any block). Use the engine and ShootPlayerRacket 
 * method you implemented in task 4, but don't add items in any of the engine lists 
 * through the ShootPlayerRacket method. Also don't edit the Racket.cs file. */

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
