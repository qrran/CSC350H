using System;

namespace CardGame
{

    internal class Card
    {
        Suit suit;
        Rank rank;
        bool faceUp;


        // Properties
        public Suit Suit { get { return suit; } }

        public Rank Rank { get { return rank; } }

        public bool FaceUp { get { return faceUp; } }

        // Constructor
        public Card(Suit suit, Rank rank)// why not(string suit, string rank)?
        {
            this.suit = suit;
            this.rank = rank;
            this.faceUp = false;
        }
        // Method
        public void FlipOver()
        {
            this.faceUp = true;
        }

    }

}