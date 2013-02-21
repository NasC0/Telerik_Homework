using System;
using System.IO;

class ReadText
{
    static void Main()
    {
        try
        {
            string path = Console.ReadLine();
            Console.WriteLine(File.ReadAllText(path));
        }
        catch (ArgumentException)
        {
            Console.WriteLine("Invalid path");
        }
        catch (DirectoryNotFoundException)
        {
            Console.WriteLine("Invalid path");
        }
        catch (IOException ioEx)
        {
            Console.WriteLine(ioEx.Message);
        }
        catch (UnauthorizedAccessException accesEx)
        {
            Console.WriteLine(accesEx.Message);
        }
        catch (NotSupportedException nse)
        {
            Console.WriteLine(nse.Message);
        }
    }
}
