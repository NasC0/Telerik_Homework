/* Derived from the Cat class, but constraints the Sex field to only Male */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalKingdom
{
    public class Tomcat : Cat
    {
        public Tomcat(int age, string name) : base (age, name, "Male")
        {
            
        }

        public override void Sound()
        {
            Console.WriteLine("Growl");
        }
    }
}
