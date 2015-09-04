
/*
                         Problem 6. String length

    Write a program that reads from the console a string of maximum 20 characters.
    If the length of the string is less than 20, the rest of the characters should be filled with *.
    Print the result string into the console.
*/

using System;
using System.Text;

class StringLength
{
    static void Main()
    {
        StringBuilder result = new StringBuilder(20);
        result.Append(Console.ReadLine());

        if(result.Length > 20)
        {
            Console.WriteLine("The length of the string is greater the 20!");
            return;
        }
        else
        {
            for (int i = result.Length; i < result.Capacity; i++)
            {
                result.Append('*');
            }
        }
        
        Console.WriteLine(result);
    }
}