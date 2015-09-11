
/*
                    Problem 2. Concatenate text files

    Write a program that concatenates two text files into another text file.
*/

using System;
using System.IO;

class ConcatenateTextFiles
{
    static void Main()
    {
        var reader = new StreamReader(@"..\..\Files\input.txt");
        string firstFileContent;
        using (reader)
        {
            firstFileContent = reader.ReadToEnd();
        }

        reader = new StreamReader(@"..\..\Files\append.txt");
        string secondFileContent;
        using (reader)
        {
            secondFileContent = reader.ReadToEnd();
        }


        var writer = new StreamWriter(@"..\..\Files\Result.txt");
        using (writer)
        {
            writer.WriteLine(firstFileContent + secondFileContent);
        }

        Console.WriteLine("Operation completed successfuly!");
    }
}