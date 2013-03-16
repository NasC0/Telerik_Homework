using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AcademyPopcorn
{
    public class ShootRacketEngine : Engine
    {
        public ShootRacketEngine(IRenderer renderer, IUserInterface userInterface)
            : this(renderer, userInterface, 500)
        {
        }

        public ShootRacketEngine(IRenderer renderer, IUserInterface userInterface, int gameSpeed)
            : base(renderer, userInterface, gameSpeed)
        {

        }

        public void ShootPlayerRacket()
        {
            if (this.playerRacket is ShootingRacket)
            {
                (this.playerRacket as ShootingRacket).ShootRacket();
            }
        }
    }
}
