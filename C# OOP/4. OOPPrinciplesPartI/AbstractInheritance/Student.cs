/* Student class with a grade field which holds
 * his grade in school. Inherits firstName and lastName
 * from Human class */

using System;

namespace AbstractInheritance
{
    public class Student : Human
    {
        private double grade;

        public Student(string firstName, string lastName) : this(firstName, lastName, 0.0)
        {
            
        }

        public Student(string firstName, string lastName, double grade)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.grade = grade;
        }

        public override string FirstName
        {
            get { return this.firstName; }
        }

        public override string LastName
        {
            get { return this.lastName; }
        }

        public double Grade
        {
            get { return this.grade; }
            set
            {
                if (value >= 0 && value < 7)
                {
                    this.grade = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Value", "Grade must be in the range 0 <= grade < 7");
                }
            }
        }
    }
}
