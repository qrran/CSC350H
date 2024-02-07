using System;

namespace Exercise10
{
    class Program
    {
        // use switch to make the options active, not just printing out
        static void Main(string[] args)
        {
            Console.WriteLine("**************");
            Console.WriteLine("Menu:");
            Console.WriteLine("1 - New Game");
            Console.WriteLine("2 - Load Game");
            Console.WriteLine("3 - Options");
            Console.WriteLine("4 - Quit");
            Console.WriteLine("**************");

            // user input
            Console.WriteLine("Enter your choice: ");
            int choices = int.Parse(Console.ReadLine());

            switch (choices)
            {
                case 1:
                    Console.WriteLine("-----New Game-----");
                    break;
                case 2:
                    Console.WriteLine("-----Loading Game-----");
                    break;
                case 3:
                    Console.WriteLine("-----Options-----");
                    break;
                case 4:
                    Console.WriteLine("-----Quit-----");
                    break;
            }

        }
    }
}