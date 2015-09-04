
/*
                                  Problem 4. Download file

    Write a program that downloads a file from Internet (e.g. Ninja image) and stores it the current directory.
   
    Find in Google how to download files in C#.
    
    Be sure to catch all exceptions and to free any used resources in the finally block.
*/

using System;
using System.Net;

class DownloadFile
{
    static void Main()
    {
        WebClient myWebClient = new WebClient();
        Console.Write("Enter the web address of the file: ");
        string downloadFrom = Console.ReadLine();
        Console.Write("Enter the path where you want you file: ");
        string downloadHere = Console.ReadLine();

        try
        {
            myWebClient.DownloadFile(downloadFrom, downloadHere);
        }
        catch (ArgumentNullException)
        {
            Console.WriteLine("The address you have entered can't be nothing!");
        }
        catch (WebException)
        {
            Console.WriteLine("Error while downloading data!");
        }
        catch(NotSupportedException)
        {
            Console.WriteLine("Can't call this on multiple threads!");
        }   
    }
}