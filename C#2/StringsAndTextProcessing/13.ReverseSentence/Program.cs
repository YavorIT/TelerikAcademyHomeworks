
/*
                Problem 13. Reverse sentence

    Write a program that reverses the words in given sentence.
*/

using System;
using System.Collections.Generic;
using System.Text;

class ReverseSentence
{
    static bool IsPunctuationSymbol (char symbol)
    {
        return symbol.Equals('.') || symbol.Equals(',') || symbol.Equals('!') || symbol.Equals('?') || symbol.Equals('(') || symbol.Equals(')');
    }

    static void FindPunctSignPlaces (string sentence, List<char> punctuationalSigns, List<int> wordsBeforeTheSign, int wordsBeforeThePunctSign)
    {
        for (int i = 0; i < sentence.Length; i++)
        {
            if (char.IsWhiteSpace(sentence[i]))
            {
                wordsBeforeThePunctSign++;
            }

            if (IsPunctuationSymbol(sentence[i]))
            {
                wordsBeforeTheSign.Add(wordsBeforeThePunctSign);
                punctuationalSigns.Add(sentence[i]);
            }
        }
    }

    static string buildResult (List<char> punctuationalSigns, List<int> wordsBeforeTheSign, string[] words)
    {
        StringBuilder result = new StringBuilder();

        for (int i = words.Length - 1; i >= 0; i--)
        {
            if (wordsBeforeTheSign.Count > 0)
            {
                if (i == wordsBeforeTheSign[wordsBeforeTheSign.Count - 1])
                {
                    result.Append(punctuationalSigns[punctuationalSigns.Count - 1]);
                    if (i < words.Length - 1)
                    {
                        result.Append(" ");
                    }
                    result.Append(words[i].TrimEnd('!', ','));
                    punctuationalSigns.RemoveAt(punctuationalSigns.Count - 1);
                    wordsBeforeTheSign.RemoveAt(wordsBeforeTheSign.Count - 1);
                    continue;
                }
            }

            result.Append(" ");
            result.Append(words[i].TrimEnd('!', ','));
        }

        return result.ToString();
    }

    static void Main()
    {
        Console.Write("Enter the sentence: ");
        string sentence = Console.ReadLine();
        string[] words = sentence.Split(' ');

        List<int> wordsBeforeTheSign = new List<int>();
        List<char> punctuationalSigns = new List<char>();

        FindPunctSignPlaces(sentence, punctuationalSigns, wordsBeforeTheSign, 0);

        Console.WriteLine(buildResult(punctuationalSigns, wordsBeforeTheSign, words));
    }
}
