
/*
                                 Problem 9. Forbidden words

    We are given a string containing a list of forbidden words and a text containing some of these words.
    Write a program that replaces the forbidden words with asterisks.


    Example text:
    
    Microsoft announced its next generation PHP compiler today. 
    It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.

    Forbidden words: PHP, CLR, Microsoft

    The expected result: ********* announced its next generation *** compiler today.
    It is based on .NET Framework 4.0 and is implemented as a dynamic language in ***.
*/

using System;
using System.Collections.Generic;
using System.Text;

class ForbiddenWords
{
    static void input ()
    {
        Console.WriteLine("Enter the string: ");
        string text = Console.ReadLine();
        string[] words = text.Split(' ', ',', '(', ')', '@');
        char lastCharacter = text[text.Length - 1];

        var forbiddenWords = new List<string>
        {
            "PHP",
            "CLR",
            "Microsoft"
        };

        MaskForbiddenWords(forbiddenWords, words, lastCharacter);
    }

    static void MaskForbiddenWords (List<string> forbiddenWords, string[] words, char lastCharacter)
    {
        for (int i = 0; i < words.Length; i++)
        {
            if (forbiddenWords.Contains(words[i].Trim('.', '!', '?')))
            {
                int length;

                if (isEndOfSentenceSymbol(words[i][words[i].Length - 1]))
                {
                    length = words[i].Length - 1;
                }
                else
                {
                    length = words[i].Length;
                }

                words[i] = string.Empty;
                for (int j = 0; j < length; j++)
                {
                    words[i] += "*";
                }
            }
        }

        BuildResult(words, lastCharacter);
    }

    static void BuildResult (string[] words, char lastCharacter)
    {
        StringBuilder result = new StringBuilder();

        for (int i = 0; i < words.Length; i++)
        {
            result.Append(words[i]);
            if (i != words.Length - 1)
            {
                result.Append(" ");
            }
        }
        result.Append(lastCharacter);

        PrintResult(result.ToString());
    }

    static void PrintResult (string result)
    {
        Console.WriteLine("\n\n{0}", result);
    }

    static bool isEndOfSentenceSymbol (char symbol)
    {
        return symbol == '.' || symbol == '!' || symbol == '?';
    }

    static void Main()
    {
        input();
    }
}