
/*
                                         Problem 3. Check for a Play Card

    Classical play cards use the following signs to designate the card face: `2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K and A. 
    Write a program that enters a string and prints “yes” if it is a valid card sign or “no” otherwise. Examples:
*/

using System;

class CheckForAPlayCard
{
    static void Main()
    {
        Console.Write ("Enter the card number: ");
        string card = Console.ReadLine();

        int cardNumber; 

        int.TryParse(card, out cardNumber);

        if (cardNumber != 0)
        {
            if (cardNumber >= 2 && cardNumber <= 10)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
        else
        {
            if (card == "J" || card == "Q" || card == "K" || card == "A")
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}