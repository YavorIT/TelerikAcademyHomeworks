
/*
                                             Problem 5. Parse tags

    You are given a text. 
    Write a program that changes the text in all regions surrounded by the tags <upcase> and </upcase> to upper-case.
    The tags cannot be nested.

    Example: We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.

    The expected result: We are living in a YELLOW SUBMARINE. We don't have ANYTHING else.
*/

using System;
using System.Text;

class ParseTags
{
    static string StringChanger (string input)
    {
        string openingTag = "<upcase>";
        string closingTag = "</upcase>";

        bool weAreBetweenTags = false;
        StringBuilder result = new StringBuilder();

        for (int i = 0; i < input.Length; i++)
        {
            if (i < input.Length - openingTag.Length)
            {
                if (isOpeningTag(input, openingTag, i))
                {
                    i += openingTag.Length - 1;
                    weAreBetweenTags = true;
                }
                else if (isClosingTag(input, closingTag, i))
                {
                    i += closingTag.Length - 1;
                    weAreBetweenTags = false;
                }
                else if (weAreBetweenTags)
                {
                    result.Append(input[i].ToString().ToUpper());
                }
                else
                {
                    result.Append(input[i]);
                }
                continue;
            }

            result.Append(input[i]);
        }

        return result.ToString();
    }

    static bool isOpeningTag(string input, string openingTag, int i)
    {
        return String.Compare(input.Substring(i, openingTag.Length), openingTag) == 0;
    }

    static bool isClosingTag (string input, string closingTag, int i)
    {
        return String.Compare(input.Substring(i, closingTag.Length), closingTag) == 0;
    }

    static void Main()
    {

        Console.Write("Enter the string: ");
        string input = Console.ReadLine();
        
        Console.WriteLine(StringChanger(input));
    }
}