using System;
using System.Collections.Generic;

namespace Deck_of_Cards
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nDeck of Cards:");
            ////Creating a new deck
            Deck ourDeck = new Deck();
            ////Dealing to ourselves from the Deck
            Card drawnCard = ourDeck.Deal();
            ////Resetting our deck back to it's default list
            ourDeck.Reset();
            ////Shuffling the deck
            ourDeck.Shuffle();
            ////Create a player object
            Player player1 = new Player("Steve");
            Console.WriteLine("PLAYEROBJ: "+player1);
            ////Draw a few cards and add it to our hand object list
            player1.Draw(ref ourDeck);
            player1.Draw(ref ourDeck);
            player1.Draw(ref ourDeck);
            foreach(var attr in player1.hand)
                {
                    Console.WriteLine("Str Value={0} - Value={1} - Suit={2}", attr.stringVal, attr.val, attr.suit);
                }

        }
    }
}
