
/*
                     Problem 7. Reverse number

    Write a method that reverses the digits of given decimal number.
*/

using System;

class ReverseNumber
{
    static double digitReverse(string number)
    {
        string reversed = string.Empty;
        for (int i = number.Length - 1; i >= 0; i--)
        {
            reversed += number[i];
        }

        double reversedDigitsNumber = double.Parse(reversed);

        return reversedDigitsNumber;
    }

    static void Main()
    {
        Console.Write("Enter your number: ");
        string userInput = Console.ReadLine();

        double numberReversed = digitReverse(userInput);
        Console.WriteLine("Your number is: {0}", userInput);
        Console.WriteLine("Reversed number is: {0}", numberReversed);
    }
}