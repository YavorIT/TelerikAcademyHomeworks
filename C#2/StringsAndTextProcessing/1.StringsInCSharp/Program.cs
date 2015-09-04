
/*
               Problem 1. Strings in C#.

    Describe the strings in C#.
    What is typical for the string data type?
    Describe the most important methods of the String class.
*/

using System;

class StringsInCSharp

{
    static string Description ()
    {
        return @"The string in C# is an object which can be represented as a char array. 
Every single char in the string is read only. 
In C3 there is not a null terminating character at the end of the string.
What is typical for the string is that they can store everything and represent it as a string.
That means you can't sum or do any arithmetical operations with strings but you can concatenate them.
The most important methods you can use over a string objects are:
String.Join() - joins the array elements with the selected join character;
String.Split() - slits the elements of the string with the selected character;
String.Length() - return the count of the characters in the string;
String.Replace() - replaces given charcter with another;
String.Substring() - return the substring with the given start index and length;
String.ToLower() - return the same string with lower letters;
String.toUpper() - return the same string with upper letters;
String.Trim() - Trims given character from the start and end of the string;";
    }

    static void Main()
    {
        Console.WriteLine(Description());
    }
}