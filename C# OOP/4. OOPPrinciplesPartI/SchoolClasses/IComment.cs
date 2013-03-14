/* Interface which implements optional comments for
 * Teacher, Student, Classes and Discipline classes */

using System;

namespace SchoolClasses
{
    public interface IComment
    {
        string Comment  // optional comments to Students, classes, teachers and disciplines
        {
            get;
            set;
        }
    }
}
