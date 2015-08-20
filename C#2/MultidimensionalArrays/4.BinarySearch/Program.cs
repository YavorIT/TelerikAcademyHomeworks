
/*
                    Problem 4. Binary search

    Write a program, that reads from the console an array of N integers and an integer K,
    sorts the array and using the method Array.BinSearch() 
    finds the largest number in the array which is ≤ K.
*/

using System;

class BinarySearch
{
    static void Main()
    {
        Console.Write("Enter the array of integers separated by a space: ");
        string[] input = Console.ReadLine().Split(' ');

        int[] numbers = new int[input.Length];

        for (int i = 0; i < input.Length; i++)
        {
            if (!(int.TryParse(input[i], out numbers[i])))
            {
                Console.WriteLine("Please enter only valid integers!!!");
                return;
            }
        }

        int k;
        Console.Write("Enter K: ");
        if (!(int.TryParse(Console.ReadLine(), out k)))
        {
            Console.WriteLine("Please enter a valid integer!!!");
            return;
        }

        Array.Sort(numbers);

        Console.WriteLine();
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write("{0}", numbers[i]);
            if(i != numbers.Length - 1)
            {
                Console.Write(", ");
            }
        }
        Console.WriteLine();

        int currentMax = numbers[0];
        for (int i = 0; i < numbers.Length; i++)
        {
            if(numbers[i] > k)
            {
                break;
            }else
            {
                if(numbers[i] >= currentMax)
                {
                    currentMax = numbers[i];
                }
            }
        }

        int index = Array.BinarySearch(numbers, currentMax);
        Console.WriteLine("The index of the biggest number less or equal than {0} is {1}", k, index);
    }
}