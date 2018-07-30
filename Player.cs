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
            Console.WriteLine("Player object {0} created.", nme);
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
            ////Verifies the supplied index exists before removing it from our hand and returning the discard card object
            if(index<hand.Count)
            {
                Card discardedCard = hand[index];
                hand.RemoveAt(index);
                Console.WriteLine("Card {0} has been discarded.", index);
                return discardedCard;
            }
            else
            {
                Console.WriteLine("Card {0} doesn't exist!", index);
                return null;
            }
        }
    }
}