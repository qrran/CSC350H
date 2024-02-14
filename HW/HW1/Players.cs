using System;
using System.Diagnostics.Tracing;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;
using Cards2;

namespace HW1
{
    internal class Player
    {
        List<Card> cards = new List<Card>();
        int ID;

        public Player(int id)
        {
            ID = id;
        }
        public List<Card> GetCards()
        {
            return cards;
        }

        public void AddCard(Card card)
        {
            cards.Add(card);
        }

        public void RemoveCard(int index)
        {
            if (index >= 0 && index < cards.Count)
            {
                cards.RemoveAt(index);
            }
            else
            {
                Console.WriteLine("No cards in hand.");

            }
        }

        public int Numcards(List<Card> cards) //cards.count
        {
            return cards.Count;
        }

    }
}


