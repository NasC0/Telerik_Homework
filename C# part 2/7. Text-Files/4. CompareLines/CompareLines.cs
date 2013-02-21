using System;
using System.IO;

class CompareLinesSecondVariant
{
    static void Compare(string firstPath, string secondPath)
    {
        try
        {
            StreamReader firstReader = new StreamReader(firstPath);
            int sameLines = 0, diffLines = 0;
            using (firstReader)
            {
                StreamReader secondReader = new StreamReader(secondPath);
                using (secondReader)
                {
                    string firstCheck = firstReader.ReadLine();
                    string secondCheck = secondReader.ReadLine();
                    while (firstCheck != null)
                    {
                        if (firstCheck == secondCheck)
                        {
                            sameLines++;
                        }
                        else
                        {
                            diffLines++;
                        }
                        firstCheck = firstReader.ReadLine();
                        secondCheck = secondReader.ReadLine();
                    }
                }
            }

            Console.WriteLine("The number of same lines is: {0}", sameLines);
            Console.WriteLine("The number of different lines is: {0}", diffLines);
        }
        catch (FileNotFoundException notFoundEx)
        {
            Console.WriteLine(notFoundEx.Message);
        }
    }

    static void Main()
    {
        string firstPath = @"..\..\alabala.txt";
        string secondPath = @"..\..\bla.txt";
        Compare(firstPath, secondPath);
    }
}
