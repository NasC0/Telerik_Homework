/* Abstract Human class which serves as a template
 * for the Student and Worker classes */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractInheritance
{
    public abstract class Human
    {
        protected string firstName;
        protected string lastName;

        public abstract string FirstName { get; }
        public abstract string LastName { get; }
    }
}
