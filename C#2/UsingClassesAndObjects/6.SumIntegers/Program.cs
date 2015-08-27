
/*
                         Problem 6. Sum integers

    You are given a sequence of positive integer values written into a string, separated by spaces.
    Write a function that reads these values from given string and calculates their sum.
*/

using System;

class SumIntegers
{
    static void IntegersSum(string userNumbers)
    {
        string[] inputNumbers = userNumbers.Split(' ');
        int[] numbers = new int[inputNumbers.Length];
        int sum = 0;

        for (int i = 0; i < inputNumbers.Length; i++)
        {
            numbers[i] = int.Parse(inputNumbers[i]);
            sum += numbers[i];
        }

        Console.WriteLine("The sum of the integers is: {0}", sum);
    }

    static string FormatTheString (string input) // Formats the string so that the numbers are separetad by only one space and no other symbols
    {
        for (int i = 0; i < input.Length; i++)
        {
            if(((int)input[i] < 48 && input[i] != ' ' )|| (int)input[i] > 57)
            {
                input = input.Remove(i, 1);
                i--;
            }
            if (i > 0 && i < input.Length - 1)
            {
                if (input[i] == ' ' && input[i + 1] == ' ' || input[i] == ' ' && input[i - 1] == ' ')
                {
                    input = input.Remove(i, 1);
                    i--;
                }
            }
        }

        return input;
    }

    static void Main()
    {
        Console.WriteLine("Enter the numbers separated by a space: ");
        string input = Console.ReadLine();
        input = FormatTheString(input);
        IntegersSum(input);
    }
}