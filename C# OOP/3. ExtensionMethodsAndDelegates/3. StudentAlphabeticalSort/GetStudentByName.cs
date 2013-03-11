using System;
using System.Collections.Generic;
using System.Linq;

class GetStudentByName
{
    static void Main()
    {
        var studentList = new[]
        {
            new { firstName = "Atanas", lastName = "Marinov" },
            new { firstName = "Rosen", lastName = "Georgiev" },
            new { firstName = "Spas", lastName = "Stoqnov" },
            new { firstName = "Gurbav", lastName = "Vasilev" },
            new { firstName = "Hristo", lastName = "Smirnenski" }
        };

        var students = 
            from student in studentList
            where student.lastName.CompareTo(student.firstName) == -1
            select student;

        foreach (var student in students)
        {
            Console.WriteLine(student);
        }
    }
}