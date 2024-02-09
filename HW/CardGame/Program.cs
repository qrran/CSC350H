using System;

namespace CardGame
{
    // 5 files
    internal class Program
    {
        static void Main(string[] args)
        {
            foreach (Rank rank in Enum.GetValues(typeof(Rank)))
            {
                foreach (Suit suit in Enum.GetValues(typeof(Suit))) //convert to array
                {
                    Console.WriteLine(rank + " " + suit);
                }
            }

        }
    }

}