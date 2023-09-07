using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    public class Deck
    {
        private Card[] cards;
        private int top = 0;
        private Random rnd = new Random();

        public Deck() 
        {
            cards = new Card[52];
            for (int i = 1; i < 4; i++)
            {
                for (int j = 0; j < 13; j++)
                {
                    cards[(i-1)*13 + j] = new Card(j+1, i);
                }
            }
        }
        public Card Peek() { return cards[top]; }
        private void Swap(int ind1, int ind2) 
        {
            Card s = cards[ind1];
            cards[ind1] = cards[ind2];
            cards[ind2] = s;
        }
        public void Shuffle()
        {
            for (int i = top; i < cards.Length*2; i++)
            {
                Swap(i, rnd.Next(i, cards.Length));
            }
        }
        public Card Deal() 
        {
            int temp = top;
            top++;
            return cards[temp];
        }
        public void Reset() 
        {
            top = 0;
        }
    }
}
