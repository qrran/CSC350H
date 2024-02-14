using System;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

namespace LogMessage
{
    public class LogMessage
    {
        private String machineId;
        private String description;

        ////////////// Part a /////////////////////////
        public LogMessage(String message)
        {
            String[] messageSeparate = message.Split(":");

            if (messageSeparate.Length >= 2)
            {
                machineId = messageSeparate[0];
                for (int i = 0; i < messageSeparate.Length; i++)
                {
                    description = messageSeparate[i + 1];
                    // Console.WriteLine(containsWord(description));
                }
            }
            else if (messageSeparate.Length < 1)
            {
                Console.WriteLine("Error on message.");
            }
            else
            {
                description = message;
            }
            // message = machineID + ":" + description;
            // Console.WriteLine(message);
        }

        ///////////////// Part b ////////////////////////
        // define all the test cases before write the code
        // provide all the test cases
        // there are 8 test cases in the pdf
        public Boolean containsWord(String keyword)
        {
            String[] descriptionSeparate = description.Split(" ");
            // 1."disk"
            if (keyword == description)
                return true;
            // 2."error on disk"
            // 3."error on /dev/disk disk"
            // 4."error on disk DSK1"
            foreach (String word in descriptionSeparate)
            {
                string spaceKeyword = " " + keyword;
                if (keyword == spaceKeyword)
                    return true;
            }
            // -------False-------
            // 5. "DISK"
            // 6. "error on disk3"
            // 7. "error on /dev/disk"
            // 8. "diskette"

            return false;

            // substring, may search for d, then 4 after the index of d
        }

        public String getMachineId()
        {
            return machineId;
        }
        public String getDescription()
        {
            return description;
        }
    }
}
