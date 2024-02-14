using System;
using Cards2;

namespace HW1 // should be the same name as directory
{
    // IMPORTANT: Only add code in the section
    // indicated below. The code I've provided

    /// <summary>
    /// Programming Assignment 1
    /// Your name: Dan Lin
    /// Date: 02/13/2024
    /// Ver: 
    /// </summary>
    class Program2
    {
        /// <summary>
        /// Programming Assignment 1
        /// </summary>
        /// <param name="args">command-line args</param>
        static void Main(string[] args)
        {
            Deck deck = new Deck();
            Card dealtCard;

            int playerNum = 4;
            Player[] players = new Player[playerNum];

            for (int i = 0; i < playerNum; i++)
            {
                Player player = new Player(i + 1);
                players.Append(player);
            }

            int cardNum = 2;
            for (int i = 0; i < cardNum; i++) //distrubute 2 cards to each player
            {
                for (int j = 0; j < playerNum; j++) // each player receive cards by order
                {
                    dealtCard = deck.TakeTopCard();
                    players[j].AddCard(dealtCard);
                }
            }


            for (int i = 0; i < 2; i++) //distribute 2 cards in a round
            {
                for (int j = 1; j < 3; j++) //players 2 and 3
                {
                    dealtCard = deck.TakeTopCard();
                    players[i - 1].AddCard(dealtCard);
                    string cardName = $"{dealtCard.Rank} {dealtCard.Suit}";
                    Console.WriteLine($"{players[i - 1]} received: {cardName}");
                }
            }

            for (int i = 0; i < playerNum; i++)
            {
                List<Card> cards = players[i].GetCards();
                foreach (Card card in cards)
                {
                    card.FlipOver();
                    string cardNameString = $"{card.Rank} {card.Suit}";
                    Console.WriteLine($"{cardNameString}");
                    Console.WriteLine("-----------------------------");
                }
            }
        }
    }
}

