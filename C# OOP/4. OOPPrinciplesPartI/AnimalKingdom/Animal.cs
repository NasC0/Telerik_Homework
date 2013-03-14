/* The Animal class with hidden Age Name and Sex properties.
 * Implements the ISound interface. */

using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace AnimalKingdom
{
    public class Animal : ISound
    {
        private static Random randGenerator = new Random();
        public int Age { get; set; }
        public string Name { get; protected set; }
        public string Sex { get; protected set; }

        public static double AverageAge(IEnumerable<Animal> animalList)  // Calculates the average age of the set of Animals provided
        {
            double age = animalList.Average(animal => animal.Age);
            return age;
        }

        public Animal(int age, string name) : this(age, name, "Male")
        {
            
        }

        public Animal(int age, string name, string sex)
        {
            this.Age = age;
            this.Name = name;
            this.Sex = sex;
        }

        public virtual void SetRandomAge(int min, int max)  // Sets a random age to the Animal instance
        {
            this.Age = randGenerator.Next(min, max + 1);
        }

        public virtual void Sound()
        {
            Console.WriteLine("Some sound");
        }

        internal ISound ISound
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }
    }
}
