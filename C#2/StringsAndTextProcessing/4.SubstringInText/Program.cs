
/*
                     Problem 4. Sub-string in text

    Write a program that finds how many times a sub-string is contained in a given text (perform case insensitive search).


    Example:

    The target sub-string is:
    in

    The text is as follows: 
    We are living in an yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.

    The result is: 9
*/

using System;

class SubstringInText
{
    static void Main()
    {
        Console.Write("Enter your text: ");
        string text = Console.ReadLine();

        Console.Write("Enter the string you want to search for: ");
        string findAll = Console.ReadLine();

        int result = 0;

        for (int i = 0; i < text.Length - findAll.Length; i++)
        {
            if(string.Compare(text.Substring(i, findAll.Length), findAll, true) == 0)
            {
                result++;
            }
        }

        Console.WriteLine(result);
    }
}