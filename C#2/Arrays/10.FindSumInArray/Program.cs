
/*
                              Problem 10. Find sum in array

     Write a program that finds in given array of integers a sequence of given sum S (if present).
*/

using System;
using System.Text.RegularExpressions;

class FindSumInArray
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

        Console.Write("Enter the sum to find: ");
        int sum = int.Parse(Console.ReadLine());

        int currSum = 0;
        int startIndex = 0;
        int sequenceElements = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (currSum == sum)
            {
                break;
            }
            if (currSum < sum)
            {
                currSum += numbers[i];
                sequenceElements++;
            }

            if (currSum > sum)
            {
                currSum -= numbers[startIndex];
                startIndex++;
                sequenceElements--;
            }
        }

        if (currSum == sum)
        {
            Console.WriteLine("The sequnce in the aray with sum = {0} is:", sum);
            for (int i = startIndex; i < startIndex + sequenceElements; i++)
            {
                Console.Write("{0} ", numbers[i]);
            }
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("There is not a sequence equal to the sum of: {0}", sum);
        }
    }
}