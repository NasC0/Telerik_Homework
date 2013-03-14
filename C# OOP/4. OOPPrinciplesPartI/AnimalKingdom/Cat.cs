/* The Cat class, derived from Animal class
 * Overrides the Sound() method from the ISound interface */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalKingdom
{
    public class Cat : Animal
    {
        public Cat(int age, string name, string sex) : base(age, name, sex)
        {
            
        }

        public override void SetRandomAge(int min, int max) // Constraints the maximum generated age
        {
            if (min > 22)
            {
                throw new ArgumentOutOfRangeException("Min", "Must be in the range 0 < age < 22");
            }
            else if (max > 22)
            {
                throw new ArgumentOutOfRangeException("Max", "Must be in the range 0 < age < 22");
            }
            else
            {
                base.SetRandomAge(min, max);
            }
        }

        public override void Sound()
        {
            Console.WriteLine("Meow");
        }
    }
}
