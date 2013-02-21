using System;
class Program
{
    static void Main()
    {
        Console.Write("Enter the company's name: ");
        string companyName = Console.ReadLine();
        Console.Write("Address: ");
        string companyAddress = Console.ReadLine();
        Console.Write("Phone number: ");
        string phoneNumber = Console.ReadLine();
        Console.Write("Fax number: ");
        string faxNumber = Console.ReadLine();
        Console.Write("Web site: ");
        string webSite = Console.ReadLine();
        Console.Write("Enter the manager's first name: ");
        string managerFName = Console.ReadLine();
        Console.Write("Last name: ");
        string managerLName = Console.ReadLine();
        Console.Write("Age: ");
        byte managerAge = byte.Parse(Console.ReadLine());
        Console.Write("Phone number: ");
        string managerPhoneNumber = Console.ReadLine();
        Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - ");
        Console.WriteLine("Comapny name: {0}", companyName);
        Console.WriteLine("Company address: {0}", companyAddress);
        Console.WriteLine("Company Phone Number: {0}", phoneNumber);
        Console.WriteLine("Company Fax Number: {0}", faxNumber);
        Console.WriteLine("Company web site: {0}", webSite);
        Console.WriteLine("Manager name: {0} {1}", managerFName, managerLName);
        Console.WriteLine("Manager age: {0}", managerAge);
        Console.WriteLine("Manager phone number: {0}", managerPhoneNumber);
    }
}
