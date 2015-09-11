
/*
                               Problem 3. Line numbers

    Write a program that reads a text file and inserts line numbers in front of each of its lines.
    The result should be written to another text file.
*/

using System;
using System.IO;

class LineNumbers
{
    static void Main()
    {
        var reader = new StreamReader(@"..\..\Files\input.txt");
        var writer = new StreamWriter(@"..\..\Files\output.txt");

        using (reader)
        {
            string line = reader.ReadLine();
            int count = 1;
            using (writer)
            {
                while (line != null)
                {
                    writer.WriteLine("{0}. {1}", count, line);
                    count++;
                    line = reader.ReadLine();
                }
            }
        }
    }
}