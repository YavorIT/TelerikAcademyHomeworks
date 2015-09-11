
/*
                       Problem 1. Odd lines

    Write a program that reads a text file and prints on the console its odd lines.
*/

using System;
using System.IO;

class OddLines
{
    static void Main()
    {
        var streamReader = new StreamReader(@"..\..\Files\Input.txt");
        string line = streamReader.ReadLine();

        using (streamReader)
        {
            int count = 1;
            while(line != null)
            {
                if(count % 2 != 0)
                {
                    Console.WriteLine(line);
                }
                count++;
                line = streamReader.ReadLine();
            }
        }
    }
}