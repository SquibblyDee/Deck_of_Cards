using System;
using System.Collections.Generic;

namespace Deck_of_Cards
{
    class Program
    {
        static void Main(string[] args)
        {
            //Make Players
            Console.WriteLine("Please enter your name: ");
            string PlayerName = Console.ReadLine();
            // string PlayerName = "Matt";
            Player HumanPlayer = new Player(PlayerName);
            Player AIPlayer = new Player("Bender");

            //Make and shuffle deck
            Deck ourDeck = new Deck();
            ourDeck.Shuffle();

            //Deal Cards
            for(var i=0; i<7; i++)
            {
                HumanPlayer.Draw(ref ourDeck);
                AIPlayer.Draw(ref ourDeck);
            }

            //start playing
            while(HumanPlayer.hand.Count>0 && AIPlayer.hand.Count>0 && ourDeck.cards.Count>0){
                // Print the contents of our Human hand list
                Console.WriteLine("\nPlayer's Hand:");
                foreach(var attr in HumanPlayer.hand)
                {
                    Console.WriteLine("{0} of {1}", attr.stringVal, attr.suit);
                }

                // Print the contents of our AI hand list
                Console.WriteLine("\nAI's Hand:");
                foreach(var attr in AIPlayer.hand)
                {
                    Console.WriteLine("{0} of {1}", attr.stringVal, attr.suit);
                }

                //Human portion of our game logic
                //ask AI for card
                Console.WriteLine("Which card would you like to check?");
                string Ask = Console.ReadLine();
                bool ValidAsk = false;
                //make sure the card is in HumanPlayer's hand.
                for(int i=0; i<HumanPlayer.hand.Count; i++)
                {
                    if(HumanPlayer.hand[i].stringVal==Ask)
                    {
                        ValidAsk = true;
                    }
                }
                if(ValidAsk == false)
                {
                    Console.WriteLine("You fuckin' cheater. Pick a valid card!");
                    continue;
                }
                else
                {
                    //check AI's hand for ask card.
                    Console.WriteLine($"{AIPlayer.name}, do you have any {Ask}'s?");
                    bool MatchFound = false;
                    for(int i=0; i<AIPlayer.hand.Count; i++)
                    {
                        if(AIPlayer.hand[i].stringVal==Ask)
                        {
                            MatchFound = true;
                            Console.WriteLine($"Great guess {HumanPlayer.name}, here are my {Ask}'s");
                            HumanPlayer.hand.Add(AIPlayer.hand[i]);
                            AIPlayer.hand.RemoveAt(i);
                        }
                    }
                    //If no matches, go fish
                    if(MatchFound == false)
                    {
                        Console.WriteLine("Go Fish!");
                        HumanPlayer.Draw(ref ourDeck);
                    }
                }
                ////Check player's hand and see if it contains any sets
                for(int k=0; k<HumanPlayer.hand.Count; k++)
                {
                    int count = 1;
                    int index1 = k;
                    for(int l=k+1; l<HumanPlayer.hand.Count; l++)
                    {
                        if(HumanPlayer.hand[k].stringVal == HumanPlayer.hand[l].stringVal)
                        {
                            count++;
                            if(count == 4)
                            {
                                HumanPlayer.stack++;
                            }
                        }
                    }
                }
                //AI portion of our game logic.
                //Check the humans hand to see if it has our randomly selected card
                Random rand = new Random();
                bool AIMatchFound = false;
                int AISelectedIndex = rand.Next(AIPlayer.hand.Count);
                Card SelectedCard = AIPlayer.hand[AISelectedIndex];
                Console.WriteLine($"{HumanPlayer.name}, do you have any {SelectedCard.stringVal}'s?");
                for(int j=0; j<HumanPlayer.hand.Count; j++)
                {
                    if(HumanPlayer.hand[j].stringVal == SelectedCard.stringVal)
                    {
                        AIMatchFound = true;
                        Console.WriteLine($"Great guess {AIPlayer.name}, here are my {SelectedCard.stringVal}'s");
                        AIPlayer.hand.Add(HumanPlayer.hand[j]);
                        HumanPlayer.hand.RemoveAt(j);
                    }
                }
                //If no matches, go fish
                if(AIMatchFound == false)
                    {
                        Console.WriteLine("Go Fish!");
                        HumanPlayer.Draw(ref ourDeck);
                    }
                






            }

            // Console.WriteLine("\nDeck of Cards:");
            // ////Creating a new deck
            // Deck ourDeck = new Deck();
            
            // ////Dealing to ourselves from the Deck
            // Card drawnCard = ourDeck.Deal();

            // ////Resetting our deck back to it's default list
            // ourDeck.Reset();

            // ////Shuffling the deck
            // ourDeck.Shuffle();

            // ////Create a player object
            // Player player1 = new Player("Steve");

            // ////Draw a few cards and add it to our hand object list
            // player1.Draw(ref ourDeck);
            // player1.Draw(ref ourDeck);
            // player1.Draw(ref ourDeck);
            // Print the contents of our hand list
            // Console.WriteLine("\nPlayer's Hand:");
            // foreach(var attr in player1.hand)
            //     {
            //         Console.WriteLine("{0} of {1}", attr.stringVal, attr.suit);
            //     }
            
            // ////Discard a valid card from our hand
            // player1.Discard(1);
            // ////Print the contents of our hand list
            // Console.WriteLine("\nPlayer's Hand:");
            // foreach(var attr in player1.hand)
            //     {
            //         Console.WriteLine("{0} of {1}", attr.stringVal, attr.suit);
            //     }
            
            // ///Discard an invalid vard from our hand
            // player1.Discard(9);
            // ////Print the contents of our hand list
            // Console.WriteLine("\nPlayer's Hand:");
            // foreach(var attr in player1.hand)
            //     {
            //         Console.WriteLine("{0} of {1}", attr.stringVal, attr.suit);
            //     }

        }
    }
}