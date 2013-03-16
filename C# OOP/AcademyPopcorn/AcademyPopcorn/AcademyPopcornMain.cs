using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyPopcorn
{
    class AcademyPopcornMain
    {
        const int WorldRows = 23;
        const int WorldCols = 40;
        const int RacketLength = 6;

        static void Initialize(Engine engine)
        {
            int startRow = 3;
            int startCol = 2;
            int endCol = WorldCols - 2;

            for (int i = startCol; i < 10; i++)
            {
                Block currBlock = new Block(new MatrixCoords(startRow, i));

                engine.AddObject(currBlock);
            }

            for (int i = 10; i < 20; i++)
            {
                GiftBlock currBlock = new GiftBlock(new MatrixCoords(startRow, i));

                engine.AddObject(currBlock);
            }

            for (int i = 20; i < endCol; i++)
            {
                ExplodingBlock currBlock = new ExplodingBlock(new MatrixCoords(startRow, i));

                engine.AddObject(currBlock);
            }

            for (int i = 0; i < WorldRows; i++)
            {
                IndestructibleBlock leftWalls = new IndestructibleBlock(new MatrixCoords(i, 0));
                IndestructibleBlock rightWalls = new IndestructibleBlock(new MatrixCoords(i, WorldCols - 1));

                engine.AddObject(leftWalls);
                engine.AddObject(rightWalls);
            }

            for (int i = 0; i < WorldCols; i++)
            {
                IndestructibleBlock ceiling = new IndestructibleBlock(new MatrixCoords(0, i));

                engine.AddObject(ceiling);
            }

            MeteoriteBall meteoriteBall = new MeteoriteBall(new MatrixCoords(WorldRows / 2, 0),
                new MatrixCoords(-1, 1));

            engine.AddObject(meteoriteBall);

            //UnstoppableBall unstoppableBall = new UnstoppableBall(new MatrixCoords(WorldRows / 2, 0),
            //    new MatrixCoords(-1, 1));

            //engine.AddObject(unstoppableBall);

            //Ball theBall = new Ball(new MatrixCoords(WorldRows / 2, 0),
            //    new MatrixCoords(-1, 1));

            //engine.AddObject(theBall);

            Racket theRacket = new Racket(new MatrixCoords(WorldRows - 1, WorldCols / 2), RacketLength);

            engine.AddObject(theRacket);


        }

        static void Main(string[] args)
        {
            IRenderer renderer = new ConsoleRenderer(WorldRows, WorldCols);
            IUserInterface keyboard = new KeyboardInterface();

            ShootRacketEngine gameEngine = new ShootRacketEngine(renderer, keyboard, 100);

            keyboard.OnLeftPressed += (sender, eventInfo) =>
            {
                gameEngine.MovePlayerRacketLeft();
            };

            keyboard.OnActionPressed += (sender, eventInfo) =>
            {
                gameEngine.ShootPlayerRacket();
            };

            keyboard.OnRightPressed += (sender, eventInfo) =>
            {
                gameEngine.MovePlayerRacketRight();
            };

            Initialize(gameEngine);

            //

            gameEngine.Run();
        }
    }
}
