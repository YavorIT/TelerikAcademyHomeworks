
/*
                           Problem 10. Unicode characters

    Write a program that converts a string to a sequence of C# Unicode character literals.
    Use format strings.

    Example:

    Hi!	  ->     \u0048\u0069\u0021
*/

using System;
using System.Text;

class UnicodeCharacters
{
    static string ToUnicodeCharacters(string input)
    {
        StringBuilder output = new StringBuilder();

        foreach (char letter in input)
        {
            output.AppendFormat("\\u{0:x4}", (int)letter);
        }

        return output.ToString();
    }

    static void Main()
    {
        Console.Write("Enter the string: ");
        string input = Console.ReadLine();

        Console.WriteLine(ToUnicodeCharacters(input));
    }
}