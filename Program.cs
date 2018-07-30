﻿using System;
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

            ////Draw a few cards and add it to our hand object list
            player1.Draw(ref ourDeck);
            player1.Draw(ref ourDeck);
            player1.Draw(ref ourDeck);
            ////Print the contents of our hand list
            Console.WriteLine("\nPlayer's Hand:");
            foreach(var attr in player1.hand)
                {
                    Console.WriteLine("{0} of {1}", attr.stringVal, attr.suit);
                }
            
            ////Discard a valid card from our hand
            player1.Discard(1);
            ////Print the contents of our hand list
            Console.WriteLine("\nPlayer's Hand:");
            foreach(var attr in player1.hand)
                {
                    Console.WriteLine("{0} of {1}", attr.stringVal, attr.suit);
                }
            
            ///Discard an invalid vard from our hand
            player1.Discard(9);
            ////Print the contents of our hand list
            Console.WriteLine("\nPlayer's Hand:");
            foreach(var attr in player1.hand)
                {
                    Console.WriteLine("{0} of {1}", attr.stringVal, attr.suit);
                }

        }
    }
}
