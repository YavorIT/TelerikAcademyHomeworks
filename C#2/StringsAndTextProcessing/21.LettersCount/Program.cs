
/*
                    Problem 21. Letters count

    Write a program that reads a string from the console and prints all 
    different letters in the string along
    with information how many times each letter is found.
*/

using System;
using System.Collections.Generic;

class LettersCount
{
    static void LetterCounter (Dictionary<char, int> letters, string input)
    {
        for (int i = 0; i < input.Length; i++)
        {
            if (char.IsLetter(input[i]))
            {
                if (letters.ContainsKey(input[i]))
                {
                    letters[input[i]]++;
                }
                else
                {
                    letters.Add(input[i], 1);
                }
            }
        }
    }

    static void PrintResult (Dictionary<char, int> letters)
    {
        foreach (var item in letters)
        {
            Console.WriteLine("{0} - {1}", item.Key, item.Value);
        }
    }

    static void Main()
    {
        Console.Write("Enter the string: ");
        string input = Console.ReadLine();

        var letters = new Dictionary<char, int>();

        LetterCounter(letters, input);

        PrintResult(letters);
    }
}