/* Using the extension methods OrderBy() and ThenBy() 
 * with lambda expressions sort the students by 
 * first name and last name in descending order. 
 * Rewrite the same with LINQ. */

using System;
using System.Collections.Generic;
using System.Linq;

class SortStudentsByName
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

        var sortedStudentListLambda = studentList.OrderByDescending(student => student.firstName).ThenByDescending(student => student.lastName);

        foreach (var student in sortedStudentListLambda)
        {
            Console.WriteLine(student);
        }

        //LINQ operation
        var sortedStudentListLinq =
            from student in studentList
            orderby student.firstName descending, student.lastName descending
            select student;

        Console.WriteLine();

        foreach (var student in sortedStudentListLinq)
        {
            Console.WriteLine(student);
        }
    }
}
