
/*
                     Problem 2. Reverse string

    Write a program that reads a string, reverses it and prints the result at the console.
*/

using System;
using System.Text;
class ReverseString
{
    static string StringReverse (string input)
    {
        StringBuilder result = new StringBuilder(input.Length);

        for (int i = input.Length - 1; i >= 0; i--)
        {
            result.Append(input[i]);
        }

        return result.ToString();
    }
    static void Main()
    {
        Console.Write("Write the string you want to be reversed: ");
        string input = Console.ReadLine();

        Console.WriteLine(StringReverse(input));
    }
}