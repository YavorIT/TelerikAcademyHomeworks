
/*
                         Problem 23. Series of letters

    Write a program that reads a string from the console and replaces 
    all series of consecutive identical letters with a single one.
*/

using System;
using System.Text;

class SeriesOfLetters
{
    static string RemoveUnnecessaryLetters(string input)
    {
        StringBuilder result = new StringBuilder();
        result.Append(input[0]);

        for (int i = 1; i < input.Length; i++)
        {
            if (input[i] == result[result.Length - 1])
            {
                continue;
            }
            else
            {
                result.Append(input[i]);
            }
        }

        return result.ToString();
    }
    static void Main()
    {
        Console.Write("Enter the string: ");
        string input = Console.ReadLine();

        Console.WriteLine(RemoveUnnecessaryLetters(input));
    }
}