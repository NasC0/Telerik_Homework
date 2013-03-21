/* Task 2
 * Customer class which serves as a base for the Individual and Company classes */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankModel
{
    public abstract class Customer
    {
        public string Name { get; protected set; }

        public Customer(string name)
        {
            this.Name = name;
        }
    }
}
