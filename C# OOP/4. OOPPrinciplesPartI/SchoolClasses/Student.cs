/* Student class, derived from Human class */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolClasses
{
    public class Student : Human, IComment
    {
        private string comment;
        private string classNumber;

        public Student(string name, string classNumber)
            : base(name)
        {
            this.classNumber = classNumber;
        }

        public string Comment
        {
            get { return this.comment; }
            set { this.comment = value; }
        }

        public string ClassNumber
        {
            get { return this.classNumber; }
        }

        public IComment IComment
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
