using System;
using System.Net;

class DownloadFile
{
    static void Main()
    {
        using (WebClient client = new WebClient())
        {
            try
            {
                Console.WriteLine("Downloading");
                string path = "http://www.devbg.org/img/Logo-BASD.jpg";
                client.DownloadFile("http://www.devbg.org/img/Logo-BASD.jpg", "logo.jpg");
                Console.WriteLine("Done");
            }
            catch (WebException we)
            {
                Console.WriteLine(we.Message);
            }
        }
    }
}
