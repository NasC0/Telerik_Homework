using System;
using System.Collections.Generic;
using System.IO;

namespace Points
{
    public static class PathStorage
    {
        static public void SavePath(string filePath, Path path)
        {
            File.WriteAllText(filePath, path.ToString());
        }

        static public Path LoadPath(string filePath)
        {
            Path path = new Path();
            try
            {
                StreamReader reader = new StreamReader(filePath);
                using (reader)
                {
                    string line = reader.ReadLine();
                    while (line != null)
                    {
                        string[] lineArray = line.Split(' ');
                        path.AddPoint(new Point(int.Parse(lineArray[0]), int.Parse(lineArray[1]), int.Parse(lineArray[2])));
                        line = reader.ReadLine();
                    }
                }
            }
            catch (FileNotFoundException notFoundEx)
            {
                Console.WriteLine(notFoundEx.Message);
            }
            return path;
        }
    }
}
