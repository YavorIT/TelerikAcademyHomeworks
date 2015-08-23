
/*
                    Problem 4. Appearance count

        Write a method that counts how many times given number appears in given array.
        Write a test program to check if the method is workings correctly.
*/

using System;

class ReverseNumber
{
    static int TimesMet (double [] input, double searchedNumber)
    {
        int count = 0;

        for (int i = 0; i < input.Length; i++)
        {
            if(input[i] == searchedNumber)
            {
                count++;
            }
        }

        return count;
    }

    static void Main ()
    {
        Console.WriteLine("Enter the array numbers separated by a space: ");
        string[] input = Console.ReadLine().Split(' ');

        double[] numbers = new double[input.Length];

        for (int i = 0; i < input.Length; i++)
        {
            numbers[i] = double.Parse(input[i]);
        }

        Console.Write("Enter the number to search for: ");
        double numberToFind = double.Parse(Console.ReadLine());

        int count = TimesMet(numbers, numberToFind);

        Console.WriteLine("The number {0} have been met {1} times in the array!", numberToFind, count);
    }
}