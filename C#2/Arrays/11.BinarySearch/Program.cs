
/*
    Problem 11. Binary search

Write a program that finds the index of given element in a sorted array of integers by using the Binary search algorithm.
*/

using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class BinarySearch
{
    static void Main()
    {
        //Input the Array
        Console.WriteLine("Enter the array (1, 2, ..., n): ");
        string[] input = Regex.Split(Console.ReadLine(), ", ");
        List<double> numbers = new List<double>();
        double tempInput = 0;

        for (int i = 0; i < input.Length; i++)
        {
            if (!(double.TryParse(input[i], out tempInput)))
            {
                Console.WriteLine("Please enter the array in the correct format!!!");
                return;
            }
            numbers.Add(tempInput);
        }

        //Sorting
        double min = 0;
        for (int i = 0; i < numbers.Count; i++)
        {
            min = numbers[i];
            for (int j = i; j < numbers.Count; j++)
            {
                if (numbers[j] <= min)
                {
                    min = numbers[j];
                    double temp = numbers[j];
                    numbers[j] = numbers[i];
                    numbers[i] = temp;
                }
            }
        }


        Console.WriteLine("Sorted list: ");
        for (int i = 0; i < numbers.Count; i++)
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

        //BinarySearch

        Console.Write("Enter the element which index you want to know: ");
        double element = double.Parse(Console.ReadLine());

        int index = numbers.Count / 2;
        int middle = numbers.Count / 2;
        int maxNumbers = numbers.Count;
        bool havaMatch = false;
        for (int j = 0; j < maxNumbers; j++)
        {
            middle = numbers.Count / 2;
            if (element == numbers[middle])
            {
                havaMatch = true;
                break;
            }
            else if (element > numbers[middle])
            {
                for (int i = 0; i < middle; i++)
                {
                    numbers.RemoveAt(i);
                }
                middle = numbers.Count / 2;
                index += middle;
            }
            else if (element < numbers[middle])
            {
                
                for (int i = numbers.Count - 1; i >= middle; i--)
                {
                    numbers.RemoveAt(i);
                }
                middle = numbers.Count / 2;
                index -= middle + 1;
            }
        }
        if (havaMatch)
        {
            Console.WriteLine("The element index is: {0}", index);
        }
        else
        {
            Console.WriteLine("There is not such an element in the array!");
        }
    }
}