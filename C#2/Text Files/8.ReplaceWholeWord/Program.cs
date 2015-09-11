
/*
                        Problem 8. Replace whole word

    Modify the solution of the previous problem to replace only whole words (not strings).
*/

using System.IO;

class ReplaceWholeWord
{
    static void Main(string[] args)
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
                    for (int i = 0; i < line.Length; i++)
                    {
                        if (line.StartsWith("start "))
                        {
                            line = line.Replace("start ", "finish ");
                        }
                        line = ReplaceAll(line);
                    }
                    writer.WriteLine(line);
                    line = reader.ReadLine();
                }
            }
        }
    }

    static string ReplaceAll(string line)
    {
        line = line.Replace(" start ", " finish ");
        line = line.Replace(" start,", " finish,");
        line = line.Replace(" start.", " finish.");
        line = line.Replace(" start!", " finish!");
        line = line.Replace(" start?", " finish?");

        return line;
    }
}

