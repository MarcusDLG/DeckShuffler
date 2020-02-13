using System;
using System.Collections.Generic;

namespace DeckShuffler
{
  class Program
  {
    static void Main(string[] args)
    {
      var playerHand = new List<string>();

      {

        // Explorer mode: 
        // Once the program starts, you should create a new deck.

        Console.WriteLine("Welcome to the Deck Shuffler!");
        Console.WriteLine("Building your deck . . .");

        // build an array of each number and each card type or 4 separate arrays that you reference and interpolate to shuffle

        var deck = new List<string> {
          "Ace of Spades",
          "2 of Spades",
          "3 of Spades",
          "4 of Spades",
          "5 of Spades",
          "6 of Spades",
          "7 of Spades",
          "8 of Spades",
          "9 of Spades",
          "10 of Spades",
          "Jack of Spades",
          "Queen of Spades",
          "King of Spades",
          "Ace of Hearts",
          "2 of Hearts",
          "3 of Hearts",
          "4 of Hearts",
          "5 of Hearts",
          "6 of Hearts",
          "7 of Hearts",
          "8 of Hearts",
          "9 of Hearts",
          "10 of Hearts",
          "Jack of Hearts",
          "Queen of Hearts",
          "King of Hearts",
          "Ace of Diamonds",
          "2 of Diamonds",
          "3 of Diamonds",
          "4 of Diamonds",
          "5 of Diamonds",
          "6 of Diamonds",
          "7 of Diamonds",
          "8 of Diamonds",
          "9 of Diamonds",
          "10 of Diamonds",
          "Jack of Diamonds",
          "Queen of Diamonds",
          "King of Diamonds",
          "Ace of Clubs",
          "2 of Clubs",
          "3 of Clubs",
          "4 of Clubs",
          "5 of Clubs",
          "6 of Clubs",
          "7 of Clubs",
          "8 of Clubs",
          "9 of Clubs",
          "10 of Clubs",
          "Jack of Clubs",
          "Queen of Clubs",
          "King of Clubs",
        };

        // Console.WriteLine(deck[10]);
        // After deck creation, you should shuffle the deck using Fisher–Yates shuffle algorithm.

        Random rnd = new Random();
        // for i from 52 - 1 down to 1 do
        for (var i = 52 - 1; i >= 1; i--)
        {
          //   j = random integer (where 0 <= j <= i)

          int j = rnd.Next(i);


          //   swap items[i] with items[j]
          var cardChoice = deck[i];
          deck[i] = deck[j];
          deck[j] = cardChoice;
        };
        // After the deck is shuffled, display the top card.
        var cardPlayed = deck[0];
        Console.WriteLine(cardPlayed);
        deck.Remove(cardPlayed);
        playerHand.Add(cardPlayed);


        bool flag = true;
        while (flag)
        {
          // Small menu system
          // Give the user an option to see the next card or quit the program.
          Console.WriteLine("(NEXT) for  next card");
          Console.WriteLine("(Quit) the program");
          var input = Console.ReadLine().ToLower();
          // Verify user input
          if (input != "nexdt" && input != "quit")
          {
            Console.WriteLine("That is not a valid choice, chose again from next or quit.");
            input = Console.ReadLine().ToLower();
          }


          if (input == "next")
          {
            cardPlayed = deck[0];
            Console.WriteLine(cardPlayed);
            Console.WriteLine($"The next card on top is: {deck[0]}");
            deck.Remove(cardPlayed);
          }

          else if (input == "quit")
          {
            flag = false;
          }
        }
        Console.WriteLine("Goodbye");
      }
    }
  }
}



