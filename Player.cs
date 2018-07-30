using System;
using System.Collections.Generic;

namespace Deck_of_Cards
{
    class Player
    {
        ////Give the Player class a name property.
        public string name;
        ////Give the Player a hand property that is a List of type Card.
        public List<Card> hand = new List<Card>();

        public Player(string nme="John")
        {
            name = nme;
        }

        public Card Draw(ref Deck deck)
        {
            Card ourCard = deck.Deal();
            hand.Add(ourCard);
            return ourCard;
        }
    }
}