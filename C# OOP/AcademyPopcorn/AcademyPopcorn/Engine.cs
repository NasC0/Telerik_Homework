﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AcademyPopcorn
{
    public class Engine
    {
        IRenderer renderer;
        protected IUserInterface userInterface;
        protected List<GameObject> allObjects;
        protected List<MovingObject> movingObjects;
        protected List<GameObject> staticObjects;
        protected Racket playerRacket;
        int gameSpeed;

        public Engine(IRenderer renderer, IUserInterface userInterface)
            : this(renderer, userInterface, 500)
        {
        }

        public Engine(IRenderer renderer, IUserInterface userInterface, int gameSpeed)  // Task 2 Implement a "Game Speed" constructor
        {
            this.renderer = renderer;
            this.userInterface = userInterface;
            this.allObjects = new List<GameObject>();
            this.movingObjects = new List<MovingObject>();
            this.staticObjects = new List<GameObject>();
            this.gameSpeed = gameSpeed;
        }

        private void AddStaticObject(GameObject obj)
        {
            this.staticObjects.Add(obj);
            this.allObjects.Add(obj);
        }

        private void AddMovingObject(MovingObject obj)
        {
            this.movingObjects.Add(obj);
            this.allObjects.Add(obj);
        }

        public virtual void AddObject(GameObject obj)
        {
            if (obj is MovingObject)
            {
                this.AddMovingObject(obj as MovingObject);
            }
            else
            {
                if (obj is Racket)
                {
                    AddRacket(obj);
                }
                else
                {
                    this.AddStaticObject(obj);
                }
            }
        }

        private void AddRacket(GameObject obj) // Task 3. There should be only 1 racket at all times.
        {
            this.allObjects.RemoveAll(racket => racket is Racket); // At method call destroy all the old rackets in the allObjects list
            this.staticObjects.RemoveAll(racket => racket is Racket); // and in the staticObjects list

            this.playerRacket = obj as Racket; // add the new racket
            this.AddStaticObject(obj);
        }

        public virtual void MovePlayerRacketLeft()
        {
            this.playerRacket.MoveLeft();
        }

        public virtual void MovePlayerRacketRight()
        {
            this.playerRacket.MoveRight();
        }

        public virtual void Run()
        {
            while (true)
            {
                this.renderer.RenderAll();

                System.Threading.Thread.Sleep(this.gameSpeed);

                this.userInterface.ProcessInput();

                this.renderer.ClearQueue();

                foreach (var obj in this.allObjects)
                {
                    obj.Update();
                    this.renderer.EnqueueForRendering(obj);
                }

                CollisionDispatcher.HandleCollisions(this.movingObjects, this.staticObjects);

                List<GameObject> producedObjects = new List<GameObject>();

                foreach (var obj in this.allObjects)
                {
                    producedObjects.AddRange(obj.ProduceObjects());
                }

                this.allObjects.RemoveAll(obj => obj.IsDestroyed);
                this.movingObjects.RemoveAll(obj => obj.IsDestroyed);
                this.staticObjects.RemoveAll(obj => obj.IsDestroyed);

                foreach (var obj in producedObjects)
                {
                    this.AddObject(obj);
                }
            }
        }
    }
}
