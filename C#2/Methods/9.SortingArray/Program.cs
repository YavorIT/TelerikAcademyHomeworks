
/*
                                    Problem 9. Sorting array

    Write a method that return the maximal element in a portion of array of integers starting at given index.
    Using it write another method that sorts an array in ascending / descending order.
*/

using System;

class SortingArray
{
    static double biggestInGivenRange (double[] input, int index)
    {
        double biggestNumber = input[index];
        for (int i = index + 1; i < input.Length; i++)
        {
            if(biggestNumber < input[i])
            {
                biggestNumber = input[i];
            }
        }

        return biggestNumber;
    }

    static void SortDescending (double[] input)
    {
        double biggerNumber;
        for (int i = 0; i < input.Length - 1; i++)
        {
            biggerNumber = biggestInGivenRange(input, i);
            for (int j = i; j < input.Length; j++)
            {
                if(input[j] == biggerNumber)
                {
                    input[j] = input[i];
                    input[i] = biggerNumber;
                }
            }
        }
    }

    static void PrintArray (double[] input)
    {
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

    static void Main()
    {
        Console.WriteLine("Enter the array numbers separated by a space: ");
        string[] input = Console.ReadLine().Split(' ');

        double[] numbers = new double[input.Length];

        for (int i = 0; i < input.Length; i++)
        {
            numbers[i] = double.Parse(input[i]);
        }

        Console.WriteLine("The array is: ");
        PrintArray(numbers);

        SortDescending(numbers);

        Console.WriteLine("The array sorted descending is: ");
        PrintArray(numbers);

        Array.Reverse(numbers);

        Console.WriteLine("The array sorted ascending is: ");
        PrintArray(numbers);
    }
}