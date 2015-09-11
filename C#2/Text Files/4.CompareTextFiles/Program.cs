
/*
                                Problem 4. Compare text files

    Write a program that compares two text files line by line and prints the number of lines
    that are the same and the number of lines that are different.
   
    Assume the files have equal number of lines.
*/

using System;
using System.IO;

class CompareTextFiles
{
    static void Main()
    {
        var readFirstFile = new StreamReader(@"..\..\Files\firstFile.txt");
        var readSecondFile = new StreamReader(@"..\..\Files\secondFile.txt");

        int sameLines = 0;
        int diffLines = 0;
        string firstFileLine;
        string secondFileLine;

        using (readFirstFile)
        {
            firstFileLine = readFirstFile.ReadLine();
            using (readSecondFile)
            {
                while (firstFileLine != null)
                {
                    secondFileLine = readSecondFile.ReadLine();
                    if(secondFileLine == firstFileLine)
                    {
                        sameLines++;
                    }else
                    {
                        diffLines++;
                    }
                    firstFileLine = readFirstFile.ReadLine();
                }

            }
        }

        Console.WriteLine("Same lines - {0}", sameLines);
        Console.WriteLine("Different Lines - {0}", diffLines);
    }
}