
/*
                                  Problem 3. Read file contents

    Write a program that enters file name along with its full file path 
    (e.g. C:\WINDOWS\win.ini), reads its contents and prints it on the console.

    Find in MSDN how to use System.IO.File.ReadAllText(…).

    Be sure to catch all possible exceptions and print user-friendly error messages.
*/

using System;
using System.IO;

class ReadFileContents
{
    static string ReadFile(string filePath)
    {
        string fileContent;
        try
        {
            fileContent = File.ReadAllText(filePath);
            return fileContent;
        }
        catch (ArgumentNullException)
        {
            Console.WriteLine("File path can't be nothing!");
            return null;
        }
        catch (ArgumentException)
        {
            Console.WriteLine("Check the file path it's invalid!");
            return null;
        }
        catch (PathTooLongException)
        {
            Console.WriteLine("File path is too long!");
            return null;
        }
        catch (DirectoryNotFoundException)
        {
            Console.WriteLine("File is invalid! The directory can't be found!");
            return null;
        }
        catch (IOException)
        {
            Console.WriteLine("Error occured while opening file!");
            return null;
        }
        catch (UnauthorizedAccessException)
        {
            Console.WriteLine("You don't have permissions to use this file or you have pointed a directory!");
            return null;
        }
        catch (NotSupportedException)
        {
            Console.WriteLine("The path is in invalid format!");
            return null;
        }
    }
    static void Main()
    {
        Console.Write("Enter the file path of the file you want to read: ");
        string path = Console.ReadLine();
        string fileContent = ReadFile(path);

        Console.WriteLine(fileContent);   
    }
}