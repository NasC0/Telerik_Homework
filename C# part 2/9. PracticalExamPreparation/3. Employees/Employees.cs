using System;
using System.Collections.Generic;
using System.Linq;

class Employees
{
    static void Main()
    {
        Dictionary<string, int> positionDictionary = new Dictionary<string, int>();
        SortedList<string, int> employeeDictionary = new SortedList<string, int>();
        int positionNumber = int.Parse(Console.ReadLine());
        string[] positions = new string[positionNumber];
        for (int i = 0; i < positionNumber; i++)
        {
            positions[i] = Console.ReadLine().TrimEnd();
            int dashIndex = positions[i].IndexOf('-');
            positionDictionary.Add(positions[i].Substring(0, dashIndex - 1), int.Parse(positions[i].Substring(dashIndex + 1)));
        }
        int employeesNumber = int.Parse(Console.ReadLine());
        string[] employees = new string[employeesNumber];
        for (int i = 0; i < employees.Length; i++)
        {
            employees[i] = Console.ReadLine();
            int dashIndex = employees[i].IndexOf('-');
            string subString = employees[i].Substring(dashIndex + 2); 
            if (positionDictionary.ContainsKey(subString))
            {
                int value = positionDictionary[subString];
                employeeDictionary.Add(employees[i].Substring(0, dashIndex - 1), value);
            }
        }
        foreach (KeyValuePair<string, int> pair in employeeDictionary.OrderBy(key => key.Value))
        {
            Console.WriteLine(pair.Key);
        }
    }
}