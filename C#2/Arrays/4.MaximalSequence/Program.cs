
/*
                 Problem 4. Maximal sequence

    Write a program that finds the maximal sequence of equal elements in an array.
*/

using System;
using System.Text.RegularExpressions;

class MaximalSequence
{
    static void Main()
    {
        string input = Console.ReadLine();
        string[] sNumbers = Regex.Split(input, ", ");

        int[] numbers = new int[sNumbers.Length];

        for (int i = 0; i < sNumbers.Length; i++)
        {
            numbers[i] = int.Parse(sNumbers[i]);
        }

        int lastElement = numbers[0];
        int begin = 0;
        int currBegin = 0;
        int flag = 0;
        int end = 0;
        int max = 0;
        int lastMax = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] == lastElement && flag == 0)
            {
                max = 0;
                flag = 1;
                if(i == 0)
                { 
                    currBegin = i;
                }
                else
                {
                    currBegin = i - 1;
                }
            }
            if (numbers[i] != lastElement && flag == 1 && max >= lastMax)
            {
                lastMax = max;
                flag = 0;
                begin = currBegin;
                end = i;
            }
            lastElement = numbers[i];
            max++;
        }

        Console.WriteLine ("The longest sequence of equal elements is: ");
        for (int i = begin; i < end; i++)
        {
            if (i == begin)
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