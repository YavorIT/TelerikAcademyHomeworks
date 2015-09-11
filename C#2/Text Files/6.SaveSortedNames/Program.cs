
/*
                                Problem 6. Save sorted names
    
    Write a program that reads a text file containing a list of strings,
    sorts them and saves them to another text file.
*/

using System.IO;
using System.Collections.Generic;

class SaveSortedNames
{
    static void ReadInputFile(List<string> lines)
    {
        StreamReader reader = new StreamReader(@"..\..\Files\input.txt");
        using (reader)
        {
            string line = reader.ReadLine();
            while (line != null)
            {
                lines.Add(line);
                line = reader.ReadLine();
            }
        }
    }

    static void WriteResultToOutputFile(List<string> lines)
    {
        StreamWriter writer = new StreamWriter(@"..\..\Files\output.txt");

        using (writer)
        {
            foreach (string word in lines)
            {
                writer.WriteLine(word);
            }
        }
    }

    static void Main()
    {
        var lines = new List<string>();
        ReadInputFile(lines);
        lines.Sort();
        WriteResultToOutputFile(lines);
    }
}