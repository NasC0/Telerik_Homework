/* Class Discipline, which describes the name of the course, 
 * the number of Lectures it has and the Hours of exercises */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolClasses
{
    public class Discipline : IComment
    {
        private string comment;
        private string name;
        private int lecturesNumber;
        private int numberOfExercises;

        public Discipline(string name, int lecturesNumber, int numberOfExercises)
        {
            this.name = name;
            this.lecturesNumber = lecturesNumber;
            this.numberOfExercises = numberOfExercises;
        }

        public string Comment
        {
            get { return this.comment; }
            set { this.comment = value; }
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
