
/*
                            Problem 25. Extract text from HTML

    Write a program that extracts from given HTML file its title (if available),
    and its body text without the HTML tags.

        Example input:

    <html> <head><title>News</title></head><body><p><a href="http://academy.telerik.com">Telerik Academy</a>aims to provide free real-world practical training for young people who want to turn intoskilful .NET software engineers.</p></body></html>

    Output:

    Title: News

    Text: Telerik Academy aims to provide free real-world practical
    training for young people who want to turn into skilful .NET software engineers.
*/

using System;
using System.Text.RegularExpressions;
using System.Text;

class ExtractTextFromHTML
{
    static string GetTitle (string input, string headClosingTag)
    {
        
        StringBuilder getTitle = new StringBuilder();
        for (int i = 0; i < input.IndexOf(headClosingTag); i++)
        {
            getTitle.Append(input[i]);
        }

        return getTitle.ToString();
    }

    static string GetText (string input, string headClosingTag)
    {

        StringBuilder getText = new StringBuilder();
        for (int i = input.IndexOf(headClosingTag) + headClosingTag.Length; i < input.Length; i++)
        {
            getText.Append(input[i]);
        }

        return getText.ToString();
    }

    static string RemoveTagsFromHead (string input, Regex format, string headClosingTag)
    {
        return format.Replace(GetTitle(input, headClosingTag), "");
    }

    static string RemoveTagsFromBody(string input, Regex format, string headClosingTag)
    {
        return format.Replace(GetText(input, headClosingTag), " ").Trim(' ');
    }

    static void Main()
    {
        Console.WriteLine("Enter the html text: ");
        string HTMLinput = Console.ReadLine();

        string headClosingTag = "</head>";
        Regex format = new Regex("<[^>]+>", RegexOptions.IgnoreCase);


        string title = RemoveTagsFromHead(HTMLinput, format, headClosingTag);
        string text = RemoveTagsFromBody(HTMLinput, format, headClosingTag);


        Console.WriteLine("\n\nTitle: {0}", title);
        Console.WriteLine("\n\nText: {0}", text);
    }
}