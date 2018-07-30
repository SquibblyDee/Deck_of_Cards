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

        public Player(string playerName="John")
        {
            name = playerName;
        }

        //Give the Player a draw method of which draws a card from a deck, adds it to the player's hand and returns the Card.
        public Card Draw(ref Deck deck)
        {
            Card ourCard = deck.Deal();
            hand.Add(ourCard);
            return ourCard;
        }

        ////Give the Player a discard method which discards the Card at the specified index 
        ////from the player's hand and returns this Card or null if the index does not exist.
        // public Card Discard()
        // {
// 
        // }
    }
}