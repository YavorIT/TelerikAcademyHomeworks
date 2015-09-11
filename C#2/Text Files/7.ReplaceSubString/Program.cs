
/*
                            Problem 7. Replace sub-string

    Write a program that replaces all occurrences of the
    sub-string "start" with the sub-string "finish" in a text file.
   
    Ensure it will work with large files (e.g. 100 MB).
*/

using System.IO;

class ReplaceSubString
{
    static void Main()
    {
        StreamReader reader = new StreamReader(@"..\..\Files\input.txt");
        StreamWriter writer = new StreamWriter(@"..\..\Files\output.txt");
        using (reader)
        {
            string line = reader.ReadLine();
            using (writer)
            {
                while (line != null)
                {
                    line = line.Replace("start", "finish");
                    writer.WriteLine(line);
                    line = reader.ReadLine();
                }
            }
        }
    }
}