
/*
                    Problem 13.* Merge sort

    Write a program that sorts an array of integers using the Merge sort algorithm.
*/

// I made this program with a HUGE help from the internet!

using System;
using System.Text.RegularExpressions;

class MergeSort
{
    public static void Split (int[] input, int begin, int end, int[] workingSpace)
    {
        if(end - begin < 2)
        {
            return;
        }

        int middle = (end + begin) / 2;
        Split(input, begin, middle, workingSpace);
        Split(input, middle, end, workingSpace);
        Merge(input, begin, middle, end, workingSpace);
        CopyArrays(workingSpace, begin, end, input);
    }

    public static void Merge (int[] input, int begin, int middle, int end, int[] workingSpace)
    {
        int firstHalf = begin;
        int secondHalf = middle;

        for (int i = begin; i < end; i++)
        {
            if (firstHalf < middle && (secondHalf >= end || input[firstHalf] <= input[secondHalf]))
            {
                workingSpace[i] = input[firstHalf];
                firstHalf++;
            }
            else
            {
                workingSpace[i] = input[secondHalf];
                secondHalf++;
            }
        }
    }

    public static void CopyArrays (int[] workingSpace, int begin, int end, int[] input)
    {
        for (int i = begin; i < end; i++)
        {
            input[i] = workingSpace[i];
        }
    }

    static void Main()
    {
        Console.WriteLine("Enter the array (1, 2, ..., n): ");
        string[] input = Regex.Split(Console.ReadLine(), ", ");
        int[] numbers = new int[input.Length];

        for (int i = 0; i < input.Length; i++)
        {
            if (!(int.TryParse(input[i], out numbers[i])))
            {
                Console.WriteLine("Please enter the array in the correct format!!!");
                return;
            }
        }

        int[] workingArray = new int[numbers.Length];
        Split(numbers, 0, numbers.Length, workingArray);

        Console.WriteLine("Sorted array is: ");
        for (int i = 0; i < numbers.Length; i++)
        {
            if (i == 0)
            {
                Console.Write("{0}", numbers[i]);
            }
            else
            {
                Console.Write(", {0}", numbers[i]);
            }
        }
        Console.WriteLine();
    }
}