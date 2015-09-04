
/*
                                     Problem 15. Replace tags

    Write a program that replaces in a HTML document given as string all the tags
    <a href="…">…</a> with corresponding tags [URL=…]…[/URL].
*/

using System;

class ReplaceTags
{
    static void Main()
    {
        Console.WriteLine("Enter the HTML string: ");
        string input = Console.ReadLine();

        input = input.Replace("<a href=\"", "[URL=");
        input = input.Replace("\">", "]");
        input = input.Replace("</a>", "[/URL]");

        Console.WriteLine("\n\n{0}", input);
    }
}

//<p>Please visit <a href="http://academy.telerik. com">our site</a> to choose a training course. Also visit <a href="www.devbg.org">our forum</a> to discuss the courses.</p>