
/*
                                 Problem 24. Order words

    Write a program that reads a list of words, separated by spaces 
    and prints the list in an alphabetical order.
*/

using System;
using System.Linq;

class OrderWords
{
    static void PrintArray(string[] array)
    {
        foreach (var item in array)
        {
            Console.WriteLine(item);
        }
    }

    static void Main()
    {
        Console.Write("Enter the words separated by spaces: ");
        string[] words = Console.ReadLine().Split(' ');

        var orderedWords = words.OrderBy(n => n).ToArray();
        
        PrintArray(orderedWords);
    }
}