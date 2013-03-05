using System;
using Version;

[Version(1, 1)]
class VersionAttributeTest
{
    static void Main()
    {
        Type type = typeof(VersionAttributeTest);
        object[] versionAttribute = type.GetCustomAttributes(false);
        foreach (VersionAttribute version in versionAttribute)
        {
            Console.WriteLine("Version: {0}", version.FullVersion);
        }
    }
}
