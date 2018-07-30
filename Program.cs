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
            
        }
    }
}
