
/*
                 Problem 7. Selection sort

    Sorting an array means to arrange its elements in increasing order. Write a program to sort an array.
    
    Use the Selection sort algorithm: 
    Find the smallest element, move it at the first position, 
    find the smallest from the rest, move it at the second position, etc.
*/

using System;
using System.Text.RegularExpressions;

class SelectionSort
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

        int min = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            min = numbers[i];
            for (int j = i; j < numbers.Length; j++)
            {
                if(numbers[j] <= min)
                {
                    min = numbers[j];
                    int temp = numbers[j];
                    numbers[j] = numbers[i];
                    numbers[i] = temp;
                }
            }
        }

        Console.WriteLine("Sorted list: ");
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