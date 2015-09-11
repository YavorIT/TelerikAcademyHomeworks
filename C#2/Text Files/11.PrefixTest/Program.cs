
/*
                       Problem 11. Prefix "test"

    Write a program that deletes from a text file all words that start with the prefix "test".
    Words contain only the symbols 0…9, a…z, A…Z, _.
*/

using System.IO;
using System.Text.RegularExpressions;

class PrefixTest
{
    static void Main()
    {
        StreamReader reader = new StreamReader(@"..\..\Files\input.txt");
        StreamWriter writer = new StreamWriter(@"..\..\Files\output.txt");
        Regex testWord = new Regex(@"test\w+");
        string line;
        using (reader)
        {
            using (writer)
            {
                while ((line = reader.ReadLine()) != null)
                {
                    for (int i = 0; i < line.Length - 1; i++)
                    {
                        int numberOfCharsToRead = line.IndexOf(' ', i + 1) - i;
                        if(numberOfCharsToRead < 0 && testWord.Match(line.Substring(i)).Success)
                        {
                            line = line.Replace(line.Substring(i), line.Substring(line.Length - 1));
                            break;
                        }

                        if (numberOfCharsToRead > 0 && testWord.Match(line.Substring(i, numberOfCharsToRead)).Success)
                        {
                            line = line.Replace(line.Substring(i, numberOfCharsToRead), string.Empty);
                        }
                    }
                    writer.WriteLine(line);
                }
            }
        }
    }
}