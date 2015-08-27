
/*
                     Problem 6. Maximal K sum

    Write a program that reads two integer numbers N and K and an array of N elements from the console.
    Find in the array those K elements that have maximal sum.
*/

using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class MaximalKSum
{
    static void Main()
    {
        Console.Write ("Enter number N: ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Enter number K: ");
        int k = int.Parse(Console.ReadLine());

        int[] numbers = new int[n];
        List<int> maxSumNumbers = new List<int>();

        Console.WriteLine("Enter the array elements separated by a comma and a space: ");
        string[] inputArray = Regex.Split(Console.ReadLine(), ", "); 

        for (int i = 0; i < n; i++)
        {
            if (!(int.TryParse((inputArray[i]), out numbers[i])))
            {
                Console.WriteLine("Please enter the array in the correct format (1, 2, ..., N)");
                return;
            }
            
        }

        int largestNumber = numbers[0];

        for (int i = 0; i < k; i++)
        {
            largestNumber = numbers[0];
            for (int j = 0; j < n; j++)
            {
                if (numbers[j] >= largestNumber && !maxSumNumbers.Contains(numbers[j]))
                {
                    largestNumber = numbers[j];
                }
            }
            maxSumNumbers.Add(largestNumber);
        }

        Console.WriteLine("The numbers which sum is the largest are: ");
        for (int i = 0; i < k; i++)
        {
            if (i == 0)
            {
                Console.Write ("{0}", maxSumNumbers[i]);
            }
            else
            {
                Console.Write (", {0}", maxSumNumbers[i]);
            }
        }
        Console.WriteLine(); 
    }
}