
/*
                                         Problem 3. Min, Max, Sum and Average of N Numbers

    Write a program that reads from the console a sequence of n integer numbers and returns the minimal, the maximal number, the sum and the average
    of all numbers (displayed with 2 digits after the decimal point).

    The input starts by the number n (alone in a line) followed by n lines, each holding an integer number.
    The output is like in the examples below.
*/

using System;

class ArithmeticalOperationsWithNumbers
{
    static void Main()
    {
        Console.Write ("How many integers will you enter: ");
        int n = int.Parse(Console.ReadLine());
        int sum = 0;
        int minimalNumber = 0;
        int maximalNumber = 0;
        int count = 0;

        int[] numbers = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write ("{0} number: ", i + 1);
            numbers[i] = int.Parse(Console.ReadLine());
            if (i == 0)
            {
                minimalNumber = numbers[i];
                maximalNumber = numbers[i];
            }
            sum += numbers[i];

            if (numbers[i] > maximalNumber)
            {
                maximalNumber = numbers[i];
            }

            if (numbers[i] < minimalNumber)
            {
                minimalNumber = numbers[i];
            }

            count++;
        }

        Console.WriteLine("Min {0}", minimalNumber);
        Console.WriteLine("Max {0}", maximalNumber);
        Console.WriteLine("Sum {0}", sum);
        Console.WriteLine("Average {0:F2}", (double)sum/count);
    }
}