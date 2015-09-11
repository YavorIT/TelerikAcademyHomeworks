
/*
                                            Problem 13. Count words

    Write a program that reads a list of words from the file words.txt
    and finds how many times each of the words is contained in another file test.txt.

    The result should be written in the file result.txt and the words should
    be sorted by the number of their occurrences in descending order.
    
    Handle all possible exceptions in your methods.
*/

using System.IO;
using System.Collections.Generic;
using System;
using System.Linq;

class CountWords
{
    static void ReadListOfWords(HashSet<string> words)
    {
        try
        {
            StreamReader reader = new StreamReader(@"..\..\Files\words.txt");
            using (reader)
            {
                string word = reader.ReadLine();
                while (word != null)
                {
                    words.Add(word);
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

    static void CountTimesMet(HashSet<string> words, Dictionary<string, int> wordCount)
    {
        try
        {
            StreamReader reader = new StreamReader(@"..\..\Files\test.txt");
            using (reader)
            {
                string line = reader.ReadLine();
                while (line != null)
                {
                    foreach (string word in words)
                    {
                        for (int i = 0; i < line.Length - word.Length; i++)
                        {
                            if (line.Substring(i, word.Length) == word && IsSingleWord(line, i, word))
                            {
                                if (wordCount.ContainsKey(word))
                                    wordCount[word]++;
                                else
                                    wordCount.Add(word, 1);
                            }
                        }
                    }
                    line = reader.ReadLine();
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
            Console.WriteLine("Fatal error occured during the reading!");
            return;
        }
    }

    static void WriteResult(Dictionary<string, int> wordCount)
    {
        try
        {
            StreamWriter writer = new StreamWriter(@"..\..\Files\result.txt");
            var SortedWordCount = wordCount.OrderByDescending(x => x.Value);
            using (writer)
            {
                foreach (var element in SortedWordCount)
                {
                    writer.WriteLine("{0}: {1}", element.Key, element.Value);
                }
            }
        }
        catch
        {
            Console.WriteLine("Fatal error occured during the writing!");
            return;
        }
    }

    private static bool IsSingleWord(string line, int i, string currWord)
    {
        if (i > 0)
            return line[i - 1] == ' ' && line[i + currWord.Length] == ' ' || line[i + currWord.Length] == '.' || line[i + currWord.Length] == ',' || line[i + currWord.Length] == '!' || line[i + currWord.Length] == '?';
        else
            return line[i + currWord.Length] == ' ' || line[i + currWord.Length] == '.' || line[i + currWord.Length] == ',' || line[i + currWord.Length] == '!' || line[i + currWord.Length] == '?';
    }

    static void Main()
    {
        var words = new HashSet<string>();
        ReadListOfWords(words);

        var wordCount = new Dictionary<string, int>();
        CountTimesMet(words, wordCount);

        WriteResult(wordCount);
    }
}