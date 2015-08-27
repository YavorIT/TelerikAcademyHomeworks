
/*
                         Problem 8. Maximal sum

    Write a program that finds the sequence of maximal sum in given array.


    Can you do it with only one loop (with single scan through the elements of the array)?
*/

using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class MaximalSum
{
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

        int maxSum = numbers[0];
        int sum = numbers[0];
        int finalSequenceLength = 1;
        int currentSequenceLength = 1;
        int startIndex = 0;
        int startIndexTemp = 0;

        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] + sum > numbers[i])
            {
                sum += numbers[i];
                currentSequenceLength++;
            }
            else
            {
                sum = numbers[i];
                startIndexTemp = i;
                currentSequenceLength = 1;
            }

            if (sum > maxSum)
            {
                maxSum = sum;
                finalSequenceLength = currentSequenceLength;
                startIndex = startIndexTemp;
            }
        }

        for (int i = startIndex; i < startIndex + finalSequenceLength; i++)
        {
            if(i == startIndex)
            {
                Console.Write("{0}", numbers[i]);
            }
            else
            {
                Console.Write(", {0}", numbers[i]);
            }
        }
        Console.WriteLine("\nMaximal sum is: {0}", maxSum);
    }
}