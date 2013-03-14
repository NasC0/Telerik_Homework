/* Worker class with Week Salary and Work Hours Per Day properties.
 * Inherits firstName and lastName from Human class. */

using System;

namespace AbstractInheritance
{
    public class Worker : Human
    {
        public int weekSalary { get; set; }
        public int workHoursPerDay { get; set; }

        public Worker(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public int MoneyPerHour()
        {
            int payByHour = 0;
            int hoursPerWeek = this.workHoursPerDay * 5;
            payByHour = this.weekSalary / hoursPerWeek;
            return payByHour;
        }

        public override string FirstName
        {
            get { return this.firstName; }
        }

        public override string LastName
        {
            get { return this.lastName; }
        }
    }
}
