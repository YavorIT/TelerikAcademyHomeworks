
/*
                             Problem 12. Remove words

    Write a program that removes from a text file all words listed in given another text file.
    Handle all possible exceptions in your methods.
*/

using System.IO;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System;

class RemoveWords
{
    static void ReadWordsToDelete(HashSet<string> wordsToDelete)
    {
        try
        {
            StreamReader reader = new StreamReader(@"..\..\Files\wordlist.txt");
            using (reader)
            {
                string word = reader.ReadLine();
                while (word != null)
                {
                    wordsToDelete.Add(word);
                    word = reader.ReadLine();
                }
            }
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("Please check the file path!");
            return;
        }
        catch
        {
            Console.WriteLine("Fatal error occured!");
            return;
        }
    }

    static string DeleteTheWords(string line, HashSet<string> wordsToDelete)
    {

        for (int i = 0; i < line.Length - 1; i++)
        {
            int numberOfCharsToRead = line.IndexOf(' ', i + 1) - i;
            if (ThereAreNoMoreSpacesIn(line, i)
                && IsWord((line.Substring(i)))
                && HaveToBeDeleted(line.Substring(i), wordsToDelete))
            {
                line = line.Replace(line.Substring(i), string.Empty);
                break;
            }

            if (!ThereAreNoMoreSpacesIn(line, i) && IsWord(line.Substring(i, numberOfCharsToRead)) && HaveToBeDeleted(line.Substring(i, numberOfCharsToRead), wordsToDelete))
            {
                line = line.Replace(line.Substring(i, numberOfCharsToRead), string.Empty);
            }
        }

        return line;
    }

    private static bool ThereAreNoMoreSpacesIn(string line, int i)
    {
        if ((line.IndexOf(' ', i + 1) - i) < 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    static bool HaveToBeDeleted(string input, HashSet<string> wordsToDelete)
    {
        if (IsSign(input[input.Length - 1]))
        {
            return wordsToDelete.Contains(input.Substring(0, input.Length - 1));
        }
        else
        {
            return wordsToDelete.Contains(input);
        }
    }

    static bool IsSign(char symbol)
    {
        return symbol == ',' || symbol == '!' || symbol == '?' || symbol == '.';
    }

    static bool IsWord(string input)
    {
        Regex wordRecognize = new Regex(@"\w+");
        return wordRecognize.Match(input).Success;
    }

    static void DeleteThem(HashSet<string> wordsToDelete)
    {
        try
        {
            StreamReader reader = new StreamReader(@"..\..\Files\input.txt"); ;
            StreamWriter writer = new StreamWriter(@"..\..\Files\output.txt");
            using (reader)
            {
                string line;
                using (writer)
                {
                    while ((line = reader.ReadLine()) != null)
                    {
                        line = DeleteTheWords(line, wordsToDelete);
                        writer.WriteLine(line);
                    }
                }
            }
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("Please check the file path!");
            return;
        }
        catch
        {
            Console.WriteLine("Fatal error occured!");
            return;
        }
    }

    static void Main()
    {
        var wordsToDelete = new HashSet<string>();

        ReadWordsToDelete(wordsToDelete);

        DeleteThem(wordsToDelete);
    }
}