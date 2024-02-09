using System;

namespace CardGame
{

    internal class Deck
    {
        bool empty;

        int location;
        List<Card> cards = new List<Card>(); //only variable needded for Deck

        // Create constructor
        public Deck()
        {
            foreach (Rank rank in Enum.GetValues(typeof(Rank)))
            {
                foreach (Suit suit in Enum.GetValues(typeof(Suit))) //convert to array
                {
                    // Console.WriteLine(rank + " " + suit);
                    cards.Add(new Card(suit, rank));
                }
            }
        }
        // public List<Card> GetCards(){}

        // Properties
        public bool Empty { get { return empty; } }

        //Methods
        public void Cut(int location)
        {

        }

        public void Print()
        {

        }

        public void Shuffle()
        {

        }

        public Card TakeTopCard()
        {
            return
        }
    }

}