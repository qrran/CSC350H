```cs
using System;
using Cards2;

namespace HW1 // should be the same name as directory
{
    // IMPORTANT: Only add code in the section
    // indicated below. The code I've provided
    // makes your solution work with the
    // automated grader on Coursera

    /// <summary>
    /// Programming Assignment 1
    /// Your name: Dan Lin
    /// Date: 02/02/2024
    /// Ver:
    /// </summary>
    class Program
    {
        /// <summary>
        /// Programming Assignment 1
        /// </summary>
        /// <param name="args">command-line args</param>
        static void Main(string[] args)
        {
            // loop while there's more input
            // string input = Console.ReadLine();
            // while ( /* input is not 'q'  */ )
            {
                // Add your code between this comment
                // and the comment below. You can of
                // course add more space between the
                // comments as needed

                // declare a deck variables and create a deck object
                // DON'T SHUFFLE THE DECK
                Deck deck = new Deck();

                // deal 2 cards each to 4 players (deal properly, dealing
                // the first card to each player before dealing the
                // second card to each player)
                string[] players = { "player1", "player2", "player3", "player4" };
                string[] player1 = new string[2];
                string[] player2 = new string[3];
                string[] player3 = new string[3];
                string[] player4 = new string[2];

                Card dealtCard;

                for (int i = 0; i < 2; i++) //distrubute 2 cards to each player
                {
                    for (int j = 0; j < players.Length; j++) // each player receive cards by order
                    {
                        dealtCard = deck.TakeTopCard();
                        string cardName = $"{dealtCard.Rank} {dealtCard.Suit}";
                        switch (j)
                        {
                            case 0:
                                player1[i] = cardName;
                                break;
                            case 1:
                                player2[i] = cardName;
                                break;
                            case 2:
                                player3[i] = cardName;
                                break;
                            case 3:
                                player4[i] = cardName;
                                break;
                            default:
                                break;
                        }
                        Console.WriteLine($"{players[j]} received: {cardName}");
                        Console.WriteLine($"Is the card face up? {dealtCard.FaceUp}"); // Output: Is the card face up? False
                    }
                    Console.WriteLine("-----------------------------");
                }

                // deal 1 more card to players 2 and 3
                for (int i = 2; i < 3; i++)
                {
                    for (int j = 1; j < 3; j++) //distribute 2 cards in a round
                    {
                        dealtCard = deck.TakeTopCard();
                        string cardName = $"{dealtCard.Rank} {dealtCard.Suit}";
                        switch (j)
                        {
                            case 1:
                                player2[i] = cardName;
                                break;
                            case 2:
                                player3[i] = cardName;
                                break;
                        }
                        Console.WriteLine($"{players[j]} received: {cardName}");
                    }
                    Console.WriteLine("-----------------------------");
                }

                // flip all the cards over

                // print the cards for player 1
                Console.WriteLine("Player 1 has: ");
                foreach (string cardName in player1)
                {
                    Console.WriteLine($"{cardName}");
                }
                Console.WriteLine("-----------------------------");

                // print the cards for player 2
                Console.WriteLine("Player 2 has: ");
                foreach (string cardName in player2)
                {
                    Console.WriteLine($"{cardName}");
                }
                Console.WriteLine("-----------------------------");

                // print the cards for player 3
                Console.WriteLine("Player 3 has: ");
                foreach (string cardName in player3)
                {
                    Console.WriteLine($"{cardName}");
                }
                Console.WriteLine("-----------------------------");

                // print the cards for player 4
                Console.WriteLine("Player 4 has: ");
                foreach (string cardName in player4)
                {
                    Console.WriteLine($"{cardName}");
                }

                // Don't add or modify any code below
                // this comment
                // input = Console.ReadLine();
            }
        }
    }
}


//input[0] != 'q'
```
