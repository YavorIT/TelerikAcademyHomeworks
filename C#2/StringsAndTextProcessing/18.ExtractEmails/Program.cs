
/*
                       Problem 18. Extract e-mails

    Write a program for extracting all email addresses from given text.
    All sub-strings that match the format <identifier>@<host>…<domain> should be recognized as emails.
*/

using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class ExtractEmails
{
    static void ExtractEmailsFromText (List<string> emails, string[] words)
    {
        Regex format = new Regex (@"\w+[@]\w+[.]\w+");
        foreach (string word in words)
        {
            if (format.Match(word).Success)
            {
                emails.Add(word);
            }
        }
    }

    static void PrintEmails (List<string> emails)
    {
        foreach (string email in emails)
        {
            Console.WriteLine(email);
        }
    }

    static void Main()
    {
        Console.WriteLine("Enter the string: ");
        string[] words = Console.ReadLine().Split(' ');

        var emails = new List<string>();

        ExtractEmailsFromText(emails, words);

        PrintEmails(emails);
    }
}