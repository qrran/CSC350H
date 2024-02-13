using System;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;
using Cards2;

namespace HW1
{
    internal class Player
    {

        List<Card> cards = new List<Card>();
        // Card cards;
        // int numcards;
        int index;

        // public Card Cards { get { return cards; } }
        // public Deck decks { get { return deck; } }
        // public int Numcards { get { return numcards; } }
        // public bool Validlocation { get { return validlocation; } }

        public void AddCard(Card card)
        {
            cards.Add(card);
        }

        public void RemoveCard(int index)
        {
            cards.RemoveAt(index);
        }

        public int Numcards(List<Card> cards) //cards.count
        {
            return cards.Count;
        }



    }
}


