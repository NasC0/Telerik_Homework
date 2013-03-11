using System;
using System.Collections.Generic;
using System.Linq;

class GetStudentsByAge
{
    static void Main()
    {
        var studentList = new[]
        {
            new { firstName = "Atanas", lastName = "Marinov", age = 21 },
            new { firstName = "Rosen", lastName = "Georgiev", age = 21 },
            new { firstName = "Spas", lastName = "Stoqnov", age = 15 },
            new { firstName = "Gurbav", lastName = "Vasilev", age = 30 },
            new { firstName = "Hristo", lastName = "Smirnenski", age = 45 }
        };

        var students =
            from student in studentList
            where student.age >= 18 && student.age <= 24
            select new { firstName = student.firstName, lastName = student.lastName };

        foreach (var student in students)
        {
            Console.WriteLine(student);
        }

    }
}
