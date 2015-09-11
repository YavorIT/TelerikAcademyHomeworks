
/*
                Problem 9. Delete odd lines

    Write a program that deletes from given text file all odd lines.
    The result should be in the same file.
*/

using System.IO;
using System.Collections.Generic;

class DeleteOddLines
{
    static void ReadTheFile(List<string> lines)
    {
        StreamReader reader = new StreamReader(@"..\..\Files\input.txt");
        int count = 1;
        using (reader)
        {
            string line = reader.ReadLine();
            while (line != null)
            {
                if (count % 2 != 0)
                {
                    line = reader.ReadLine();
                    count++;
                    continue;
                }

                lines.Add(line);
                count++;
                line = reader.ReadLine();
            }
        }
    }

    static void WriteTheFile(List<string> lines)
    {
        StreamWriter writer = new StreamWriter(@"..\..\Files\input.txt");
        using (writer)
        {
            foreach (string line in lines)
            {
                writer.WriteLine(line);
            }
        }
    }

    static void Main()
    {
        var lines = new List<string>();

        ReadTheFile(lines);

        WriteTheFile(lines);
    }
}