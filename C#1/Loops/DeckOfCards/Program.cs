
/*
                                     Problem 4. Print a Deck of 52 Cards

    Write a program that generates and prints all possible cards from a standard deck of 52 cards (without the jokers).
    The cards should be printed using the classical notation (like 5 of spades, A of hearts, 9 of clubs; and K of diamonds).
    The card faces should start from 2 to A.
    Print each card face in its four possible suits: clubs, diamonds, hearts and spades. Use 2 nested for-loops and a switch-case statement.
*/

using System;

class ProgDeckOfCardsram
{
    static void Main()
    {

        int[] type = new int[4]
        {
            3, // Hearts
            4, // Diamonds
            5, // Clubs
            6  // Spades
        };

        int[] card = new int [13]
        {
          2,
          3,
          4,
          5,
          6,
          7,
          8,
          9,
          10,
          74, // J
          81, // Q
          75, // K
          65  // A
        };

        for (int i = 0; i < 13; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                switch (i)
                {
                    case 0:
                    case 1:
                    case 2:
                    case 3:
                    case 4:
                    case 5:
                    case 6:
                    case 7:
                    case 8:
                        Console.Write ("{0}{1}  ", card[i], (char)type[j]);
                        break;
                    default:
                        Console.Write ("{0}{1}  ", (char)card[i], (char)type[j]);
                        break;
                }
            }
            Console.WriteLine();
        }
    }
}