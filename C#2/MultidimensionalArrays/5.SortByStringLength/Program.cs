
/*
                  Problem 5. Sort by string length

    You are given an array of strings. 
    Write a method that sorts the array by the length of its elements (the number of characters composing them).
*/

// The sorting method uses the selection sort algorithm

using System;

class SortByStringLength
{
    static void Sort (string[] input)
    {
        int min;
        for (int i = 0; i < input.Length; i++)
        {
            min = input[i].Length;
            for (int j = i; j < input.Length; j++)
            {
                if (input[j].Length <= min)
                {
                    min = input[j].Length;
                    string temp = input[j];
                    input[j] = input[i];
                    input[i] = temp;
                }
            }
        }
    }

    static void Main()
    {
        Console.Write("Enter the array of integers separated by a space: ");
        string[] input = Console.ReadLine().Split(' ');

        Sort(input);
        Console.WriteLine("Sorted array is:");
        for (int i = 0; i < input.Length; i++)
        {
            Console.Write("{0}", input[i]);
            if(i != input.Length - 1)
            {
                Console.Write(", ");
            }
        }
        Console.WriteLine();
    }
}