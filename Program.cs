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
            Console.WriteLine("DRAWNCARD: {0} {1} {2}", drawnCard.stringVal, drawnCard.val, drawnCard.suit);
        }
    }
}
