/* Define abstract class Human with first name and last name. 
 * Define new class Student which is derived from Human and has new field – grade. 
 * Define class Worker derived from Human with new property WeekSalary and WorkHoursPerDay 
 * and method MoneyPerHour() that returns money earned by hour by the worker. Define the proper 
 * constructors and properties for this hierarchy. Initialize a list of 10 students and 
 * sort them by grade in ascending order (use LINQ or OrderBy() extension method). Initialize a list 
 * of 10 workers and sort them by money per hour in descending order. Merge the lists and 
 * sort them by first name and last name. */

using System;
using System.Collections.Generic;
using System.Linq;
using AbstractInheritance;

class AbstractInheritanceTest
{
    static Random randomGenerator = new Random(); // random generator

    static string[] FirstNames =  // source of first names for the generator
    {
        "Atanas",
        "Georgi",
        "Spas",
        "Pesho",
        "Nikolai",
        "Ivan",
        "Stavri",
        "Mladen",
        "Boris",
        "Jivko"
    };

    static string[] LastNames = // source of last names for the generator
    {
        "Marinov",
        "Ruschev",
        "Georgiev",
        "Mavrov",
        "Germanov",
        "Tonchev",
        "Milanov",
        "Popov",
        "Jeliazkov",
        "Iliev",
        "Bonev"
    };

    /* Initialise students and workers with random values (Names, Grades, Salaries and Work Hours)
     * Then merge them in a list of their parent class Human */

    static void Main()
    {
        List<Student> studentList = new List<Student>();
        for (int i = 0; i < 10; i++)
        {
            studentList.Add(new Student(FirstNames[randomGenerator.Next(0, FirstNames.Length)], LastNames[randomGenerator.Next(0, LastNames.Length)]));
            studentList[i].Grade = randomGenerator.Next(0, 7);
        }

        studentList = studentList.OrderBy(student => student.Grade).ToList();

        for (int i = 0; i < studentList.Count; i++)
        {
            Console.WriteLine("{0} {1}, Grade: {2}", studentList[i].FirstName, studentList[i].LastName, studentList[i].Grade);
        }

        Console.WriteLine();

        List<Worker> workerList = new List<Worker>();

        for (int i = 0; i < 10; i++)
        {
            workerList.Add(new Worker(FirstNames[randomGenerator.Next(0, FirstNames.Length)], LastNames[randomGenerator.Next(0, LastNames.Length)]));
            workerList[i].weekSalary = randomGenerator.Next(300, 401);
            workerList[i].workHoursPerDay = randomGenerator.Next(6, 10);
        }

        workerList = workerList.OrderByDescending(worker => worker.MoneyPerHour()).ToList();

        for (int i = 0; i < workerList.Count; i++)
        {
            Console.WriteLine("{0} {1}, Pay per hour: {2}", workerList[i].FirstName, workerList[i].LastName, workerList[i].MoneyPerHour());
        }

        Console.WriteLine();

        List<Human> mergedList = new List<Human>();
        mergedList.AddRange(studentList);
        mergedList.AddRange(workerList);

        mergedList = mergedList.OrderBy(human => human.FirstName).ThenBy(human => human.LastName).ToList();

        Console.WriteLine("Sorted human list: ");
        foreach (Human human in mergedList)
        {
            Console.WriteLine("{0} {1}", human.FirstName, human.LastName);
        }
    }
}
