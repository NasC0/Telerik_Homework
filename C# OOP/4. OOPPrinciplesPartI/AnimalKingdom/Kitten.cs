/* Inherits everything from Cat, but constraints the Sex field to Female only */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalKingdom
{
    public class Kitten : Cat
    {
        public Kitten(int age, string name) : base(age, name, "Female")
        {

        }

        public override void Sound()
        {
            Console.WriteLine("Purr");
        }
    }
}
