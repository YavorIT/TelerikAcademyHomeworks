
/*
                                                 Problem 18.* Remove elements from array

    Write a program that reads an array of integers and removes from it a minimal number of elements in such a way
    that the remaining array is sorted in increasing order.

    Print the remaining sorted array.
*/

// I have found this implementation in the internet so it's NOT mine!!! ----> https://github.com/bankoff/TelerikAcademy/blob/master/HomeworkCSharp2/02Arrays/18RemoveElementsPrintSortedArray/RemoveMinNumberElements.cs

using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class RemoveElementsFromArray
{
     static void Main()
    {
        Console.WriteLine("Enter the array (1, 2, ..., n): ");
        string[] input = Regex.Split(Console.ReadLine(), ", ");
        int[] array = new int[input.Length];

        for (int i = 0; i < input.Length; i++)
        {
            if (!(int.TryParse(input[i], out array[i])))
            {
                Console.WriteLine("Please enter the array in the correct format!!!");
                return;
            }
        }

        int count = (int)Math.Pow(2, array.Length);

        int maxCounterOfTakenElements = 0;
        List<int> checker = new List<int>();
        List<int> result = new List<int>();

        for (int i = 1; i < count; i++)
        {
            bool isSorted = true;
            checker.Clear();
            for (int j = 0; j < array.Length; j++)
            {
                if ((i >> j & 1) == 1)
                {
                    checker.Add(array[j]);
                }
            }

            for (int k = 0; k < checker.Count; k++)
            {
                if (k != 0 && k == checker.Count - 1 && checker[k] < checker[k - 1])
                {
                    isSorted = false;
                    break;
                }
                if (k != checker.Count - 1 && checker[k] > checker[k + 1])
                {
                    isSorted = false;
                    break;
                }
            }

            if (isSorted == true && maxCounterOfTakenElements < checker.Count)
            {
                maxCounterOfTakenElements = checker.Count;
                result.Clear();
                result.AddRange(checker);
            }
        }

        Console.WriteLine("Remaining sorted array is: ");
        for (int i = 0; i < result.Count; i++)
        {
            Console.Write("{0}, ", result[i]);
        }
        Console.WriteLine();
    }
}