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

        ////Give the Player a draw method of which draws a card from a deck, adds it to the player's hand and returns the Card.
        public Card Draw(ref Deck deck)
        {
            ////This grabs the return from the Deck.Deal() method and returns it's output as our card after adding it to our hand
            Card ourCard = deck.Deal();
            hand.Add(ourCard);
            return ourCard;
        }

        public Card Discard(int index)
        {
            if(index<hand.Count)
            {
                Card discardedCard = hand[index];
                hand.RemoveAt(index);
                return discardedCard;
            }
            else
            {
                return null;
            }
        }
    }
}