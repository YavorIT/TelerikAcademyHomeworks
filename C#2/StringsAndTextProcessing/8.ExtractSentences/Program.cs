
/*
                         Problem 8. Extract sentences

    Write a program that extracts from a given text all sentences containing given word.

    Example:

    The word is: in

    The text is: 
    We are living in a yellow submarine. We don't have anything else. 
    Inside the submarine is very tight. 
    So we are drinking all the day. We will move out of it in 5 days.

    The expected result is: We are living in a yellow submarine. We will move out of it in 5 days.

    Consider that the sentences are separated by . and the words – by non-letter symbols.
*/

using System;
using System.Collections.Generic;

class ExtractSentences
{
    static void Main()
    {
        Console.Write("Enter the string: ");
        string[] sentences = Console.ReadLine().Split('.');

        Console.Write("Enter the keyword: ");
        string keyWord = Console.ReadLine();

        var sentencesContainingKeyWord = new List<string>();

        foreach (string sentence in sentences)
        {
            for (int i = 1; i < sentence.Length - keyWord.Length; i++)
            {
                if (String.Compare(sentence.Substring(i, keyWord.Length), keyWord) == 0 && !char.IsLetter(sentence[i + keyWord.Length]) && !char.IsLetter(sentence[i - 1]))
                {
                    sentencesContainingKeyWord.Add(sentence);
                    break;
                }
            }
        }

        Console.WriteLine("\nSentences containing the word \"{0}\" are:\n", keyWord);
        foreach (string sentence in sentencesContainingKeyWord)
        {
            Console.WriteLine(sentence.TrimStart(' '));
        }
    }
}