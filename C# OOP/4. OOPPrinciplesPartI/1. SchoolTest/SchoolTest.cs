using System;
using SchoolClasses;
using System.Collections.Generic;

class SchoolTest
{
    static void Main()
    {
        School school = new School();

        Classes firstGrade = new Classes("First grade");
        List<Student> student = new List<Student>();
        for (int i = 0; i < 5; i++)
        {
            student.Add(new Student("Teehee", "1"));
        }
        firstGrade.AddStudents(new Student("teehee", "blabla"));
        firstGrade.AddStudentsList(student);

    }
}
