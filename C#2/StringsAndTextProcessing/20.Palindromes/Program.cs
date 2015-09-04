
/*
                          Problem 20. Palindromes

    Write a program that extracts from a given text all palindromes, e.g. ABBA, lamal, exe.
*/

// Finds also "race car" and similar palindromes, not only one word palindromes

using System;
using System.Text;
using System.Collections.Generic;

class Palindromes
{
    static void FindPalindromes (HashSet<string> palindromes, string sentence)
    {
        string TrimmedSentence = sentence.TrimStart(' ');
        int i = 0;
        while (i < TrimmedSentence.Length)
        {
            string currSentence = TrimmedSentence.Substring(i);

            FindPalindromesInSentence(palindromes, currSentence);

            i = NextSpaceIndexOrSentenceLength(TrimmedSentence, i);
        }
    }

    static void FindPalindromesInSentence (HashSet<string> palindromes, string currSentence)
    {
        int j = LastSpaceIndexOrLength(currSentence);
        while (j > 0)
        {
            j = LastSpaceIndexOrZero(currSentence);

            string mirroredSentence = ReverseSentence(currSentence);

            if (isPalindrome(mirroredSentence, currSentence))
            {
                palindromes.Add(currSentence);
            }

            currSentence = currSentence.Substring(0, j);
        }
    }

    static int LastSpaceIndexOrLength (string currSentence)
    {
        return currSentence.LastIndexOf(' ') > 0 ? currSentence.LastIndexOf(' ') : currSentence.Length;
    }

    static int LastSpaceIndexOrZero(string currSentence)
    {
        return currSentence.LastIndexOf(' ') > 0 ? currSentence.LastIndexOf(' ') : 0;
    }

    static int NextSpaceIndexOrSentenceLength(string TrimmedSentence, int i)
    {
        return TrimmedSentence.IndexOf(' ', i + 1) > 0 ? TrimmedSentence.IndexOf(' ', i + 1) + 1 : TrimmedSentence.Length;
    }

    static bool isPalindrome (string mirroredSentence, string currSentence)
    {
        return String.Compare(mirroredSentence, currSentence.Replace(" ", String.Empty)) == 0;
    }

    static string ReverseSentence (string currSentence)
    {
        StringBuilder mirroredSentence = new StringBuilder(currSentence.Length);
        for (int k = currSentence.Length - 1; k >= 0; k--)
        {
            if (currSentence[k] != ' ')
            {
                mirroredSentence.Append(currSentence[k]);
            }
        }

        return mirroredSentence.ToString();
    }

    static void PrintFoundPalindromes (HashSet<string> palindromes)
    {
        foreach (string palindrome in palindromes)
        {
            Console.WriteLine(palindrome);
        }
    }

    static string[] Input()
    {
        Console.WriteLine("Enter the text: ");
        string input = Console.ReadLine();

        return input.Split(',', '.', '!', '?');
    }

    static void Main()
    {
        string[] sentencesAndHalfSentences = Input();

        HashSet<string> palindromes = new HashSet<string>();

        foreach (string sentence in sentencesAndHalfSentences)
        {
            FindPalindromes(palindromes, sentence);
        }

        PrintFoundPalindromes(palindromes);
    }
}