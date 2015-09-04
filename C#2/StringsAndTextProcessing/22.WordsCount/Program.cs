
/*
                        Problem 22. Words count

    Write a program that reads a string from the console and lists 
    all different words in the string along with information
    how many times each word is found.
*/

using System;
using System.Collections.Generic;

class WordsCount
{
    static void HowManyTimesWordMet(Dictionary<string, int> wordCountDictionary, string input)
    {
        string[] words = input.Split(' ', ',', '.', '!', '?');

        foreach (string word in words)
        {
            if (word.Length > 1)
            {
                if (wordCountDictionary.ContainsKey(word))
                {
                    wordCountDictionary[word]++;
                }
                else
                {
                    wordCountDictionary.Add(word, 1);
                }
            }
        }
    }

    static void PrintResult(Dictionary<string, int> wordCountDictionary)
    {
        foreach (var word in wordCountDictionary)
        {
            Console.WriteLine("{0} - {1}", word.Key, word.Value);
        }
    }

    static void Main()
    {
        Console.Write("Enter the string: ");
        string input = Console.ReadLine();

        var wordCountDictionary = new Dictionary<string, int>();

        HowManyTimesWordMet(wordCountDictionary, input);

        PrintResult(wordCountDictionary);
    }
}