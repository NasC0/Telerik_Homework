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

        Teacher Teacher
        {
            get;
            set;
        }
    }
}
