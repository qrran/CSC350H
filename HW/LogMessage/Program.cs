using System;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

namespace LogMessage
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] testCases = new string[8]
            {"disk",
            "error on disk",
            "error on /dev/disk disk",
            "error on disk DSK1",
            "DISK",
            "error on disk3",
            "error on /dev/disk",
            "diskette"};

            foreach (string message in testCases)
            {
                LogMessage log = new LogMessage(message); //create new object for each message
                Console.WriteLine(log);

                bool result = log.containsWord(log.getDescription());
                Console.WriteLine(result);
                // Console.WriteLine(containsWord(description));

            }


        }
    }
}