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
    public class ShootRacketEngine : Engine // Task 4 and 13
    {
        public ShootRacketEngine(IRenderer renderer, IUserInterface userInterface)
            : this(renderer, userInterface, 500)
        {
        }

        public ShootRacketEngine(IRenderer renderer, IUserInterface userInterface, int gameSpeed)
            : base(renderer, userInterface, gameSpeed)
        {

        }

        public void ShootPlayerRacket() // Task 4 and 13
        {
            if (this.playerRacket is ShootingRacket)
            {
                (this.playerRacket as ShootingRacket).ShootRacket();
            }
        }
    }
}
