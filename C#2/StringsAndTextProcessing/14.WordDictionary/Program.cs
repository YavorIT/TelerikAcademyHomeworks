
/*
                         Problem 14. Word dictionary

    A dictionary is stored as a sequence of text lines containing words and their explanations.
    Write a program that enters a word and translates it by using the dictionary.

    Sample dictionary:

    .NET       -	platform for applications from Microsoft
    CLR	       -    managed execution environment for .NET
    namespace  -	hierarchical organization of classes
*/

using System;
using System.Collections.Generic;

class WordDictionary
{
    static void GenerateDictionary (Dictionary<string, string> dict)
    {
        dict.Add(".NET", "Platform for applications from Microsoft.");
        dict.Add("CLR", "Managed execution environment for .NET.");
        dict.Add("namespace", "Hierarchical organization of classes.");
    }

    static void PrintWordExplanation (string key, Dictionary<string, string> dict)
    {
        if(!dict.ContainsKey(key))
        {
            Console.WriteLine("There is not such a word in the dictionary!");
            return;
        }
        Console.WriteLine("{0} - {1}", key, dict[key]);
    }

    static void Main()
    {
        var dict = new Dictionary<string, string>();

        GenerateDictionary(dict);

        Console.Write("Write the word you want to see: ");
        string word = Console.ReadLine();

        PrintWordExplanation(word, dict);
    }
}