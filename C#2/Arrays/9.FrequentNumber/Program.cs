
/*
                    Problem 9. Frequent number

    Write a program that finds the most frequent number in an array.
*/

using System;
using System.Text.RegularExpressions;

class FrequentNumber
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

        int mostFrequent = numbers[0];
        int currNumber = numbers[0];
        int countFrequent = 1;
        int currCount = 1;

        for (int i = 0; i < numbers.Length; i++)
        {
            currNumber = numbers[i];
            currCount = 0;
            for (int j = i; j < numbers.Length; j++)
            {
                if(currNumber == numbers[j])
                {
                    currCount++;
                }
                if(currCount >= countFrequent)
                {
                    countFrequent = currCount;
                    mostFrequent = currNumber;
                }
            }  
        }

        Console.WriteLine("Most Frequent number: {0} ({1} times).", mostFrequent, countFrequent);
    }
}