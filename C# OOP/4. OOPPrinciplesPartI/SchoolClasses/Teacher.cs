/* Teacher class, derived from Human class */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolClasses
{
    public class Teacher : Human, IComment
    {
        private string comment;

        public Teacher(string name) : base(name)
        {
            
        }

        public string Comment
        {
            get { return this.comment; }
            set { this.comment = value; }
        }
    }
}
