/* Derived from the Animal class, overridden the Sound() method from the ISound interface */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalKingdom
{
    public class Dog : Animal
    {
        public Dog(int age, string name, string sex) : base(age, name, sex)
        {
            this.Age = age;
            this.Name = name;
            this.Sex = sex;
        }

        public override void SetRandomAge(int min, int max) // Constraints the maximum generated age
        {
            if (min > 19)
            {
                throw new ArgumentOutOfRangeException("Min", "Must be in the range 0 < age < 16");
            }
            else if (max > 19)
            {
                throw new ArgumentOutOfRangeException("Max", "Must be in the range 0 < age < 16");
            }
            else
            {
                base.SetRandomAge(min, max);
            }
        }

        public override void Sound()
        {
            Console.WriteLine("Bark");
        }
    }
}
