
/*
                 Problem 14. Quick sort

    Write a program that sorts an array of integers using the Quick sort algorithm.
*/

using System;
using System.Text.RegularExpressions;

class QuckSort
{
    public static void Sort(int[] input, int begin, int end)
    {

        //If there is only one element it means tha it's sorted.
        if (end - begin < 2)
        {
            return;
        }

        int pivot = input[end - 1];
        int pivotIndex = end - 1;

        // If the number is bigger than the pivot put it on last position and move the rest of the elements one position forwards.

        for (int i = begin; i < pivotIndex; i++)
        {
            if (input[i] > pivot)
            {
                int temp = input[i];
                for (int j = i; j < end - 1; j++)
                {
                    input[j] = input[j + 1];
                }
                input[end - 1] = temp;
                pivotIndex--;
                i--;
            }            
        }

        //If the number is smaller than the pivot put it on first position and move the rest of the elements one position backwards.

        for (int i = pivotIndex+ 1; i < end; i++)
        {
            if(input[i] < pivot)
            {
                int temp = input[i];
                for (int j = i; j > begin + 1; j--)
                {
                    input[j] = input[j - 1];
                }
                input[begin + 1] = temp;
                pivotIndex++;
                i++;
            }
        }

        Sort(input, begin, pivotIndex);
        Sort(input, pivotIndex, end);
    }

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

        Sort(numbers, 0, numbers.Length);

        Console.WriteLine("Sorted array is: ");
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