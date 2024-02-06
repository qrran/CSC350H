using System;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

namespace LogMessage
{
    class Program
    {
        // static void Main(string[] args)
        // {

        // }
        public class LogMessage
        {
            private String machineId;
            private String description;

            ////////////// Part a /////////////////////////
            public LogMessage(String message)
            {
                String[] messageSeparate = message.Split(":");
                machineId = messageSeparate[0];
                description = messageSeparate[1];
                // message = machineID + ":" + description;
                // Console.WriteLine(message);
            }

            ///////////////// Part b ////////////////////////
            // public Boolean containsWord(String keyword)
            // {
            //     String[] descriptionSeparate = description.Split(" ");
            //     for (int i = 0; i < descriptionSeparate.Length; i++)
            //     {
            //         if (keyword == descriptionSeparate[i])
            //             return true;
            //     }
            //     return false;
            // }

            ///////////////// Part b ////////////////////////
            public Boolean containsWord(String keyword)
            {
                String[] descriptionSeparate = description.Split(" ");
                foreach (String word in descriptionSeparate)
                {
                    if (word == keyword)
                        return true;
                }
                return false;
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
}