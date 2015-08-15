
/*
                Problem 5. Maximal increasing sequence

    Write a program that finds the maximal increasing sequence in an array.
*/

using System;
using System.Text.RegularExpressions;

class MaximalIncreasingSequence
{
    static void Main()
    {
        Console.Write("Enter the array of integers separated by a comma and a space: ");
        string[] input = Regex.Split(Console.ReadLine(), ", ");
        int[] numbers = new int[input.Length + 1];

        for (int i = 0; i < input.Length; i++)
        {
            numbers[i] = int.Parse(input[i]);
        }

        int lastElement = numbers[0];
        int lastMax = 0;
        int max = 0;
        int currBegin = 0;
        int begin = 0;
        int end = 0;
        int flag = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] == lastElement + 1 && flag == 0)
            {
                max = 0;
                flag = 1;
                currBegin = i - 1;
            }
            if (numbers[i] != lastElement + 1 && flag == 1 && max >= lastMax)
            {
                lastMax = max;
                flag = 0;
                begin = currBegin;
                end = i;
            }
            lastElement = numbers[i];
            max++;
        }

        Console.WriteLine("Longest increasing sequence is: ");
        for (int i = begin; i < end; i++)
        {
            if(i == begin)
            {
                Console.Write("{0}", numbers [i]);
            }
            else
            {
                Console.Write(", {0}", numbers[i]);
            }
        }
        Console.WriteLine();
    }
}