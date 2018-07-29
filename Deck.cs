using System;
using System.Collections.Generic;

namespace Deck_of_Cards
{
    class Deck
    {
        ////Give the Deck class a property called "cards" which is a list of Card objects.
        public List<Card> cards = new List<Card>();

        public Deck()
        {
            ////Declaring arrays of card suits, string/integer values. (All values needed for our card objects)
            string[] suits = {"Heart", "Spade", "Club", "Diamond"};
            string[] stringValues = {"Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King"};
            int[] integerValues = {1,2,3,4,5,6,7,8,9,10,11,12,13};
            ////Creates a card object for every possible value of each suite
            for(int i=0; i<suits.Length; i++)
            {
                for(int j=0; j<stringValues.Length; j++)
                {
                    Card card = new Card();
                    card.stringVal = stringValues[j];
                    card.val = integerValues[j];
                    card.suit = suits[i];
                    cards.Add(card);
                }
                ////Prints the values of each object for debug help
                foreach(var card in cards)
                {
                    Console.WriteLine("Str Value={0} - Value={1} - Suit={2}", card.stringVal, card.val, card.suit);
                }
            }
        }

        ////Give the Deck a deal method that selects the "top-most" card, removes it from the list of cards, and returns the Card.
        public Card Deal()
        {
            Card returnCard = cards[0];
            cards.RemoveAt(0);
            return returnCard;
        }
        ////Give the Deck a shuffle method that randomly reorders the deck's cards.
        public void Shuffle()
        {
            Random rand = new Random(cards.Count);
            foreach(var card in cards)
            {

            }
        }
    }
}
