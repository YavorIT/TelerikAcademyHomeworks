
/*
                 Problem 14. Integer calculations

    Write methods to calculate minimum, maximum, average, sum and product of given set of integer numbers.
    Use variable number of arguments.
*/

using System;

class IntegerCalculations
{
    static void Minimum (params int[] input)
    {
        int min = input[0];
        for (int i = 0; i < input.Length; i++)
        {
            if(input[i] < min)
            {
                min = input[i];
            }
        }
        Console.WriteLine("The minimun element is: {0}", min);
    }

    static void Maximum(params int[] input)
    {
        int max = input[0];
        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] > max)
            {
                max = input[i];
            }
        }
        Console.WriteLine("The minimun element is: {0}", max);
    }

    static void Average (params double[] input)
    {
        double sum = 0;
        for (int i = 0; i < input.Length; i++)
        {
            sum += input[i];
        }
        Console.WriteLine("The average is: {0}", sum / input.Length);
    }

    static void Sum (params int[] input)
    {
        int sum = 0;

        for (int i = 0; i < input.Length; i++)
        {
            sum += input[i];
        }
        Console.WriteLine("The sum is: {0}", sum);
    }

    static void Product (params int[] input)
    {
        int product = 1;
        for (int i = 0; i < input.Length; i++)
        {
            product *= input[i];
        }
        Console.WriteLine("the poduct is: {0}", product);
    }

    static void Main()
    {
        Minimum(1, 2, 3, 4, 5);
        Maximum(1, 2, 3, 4, 5);
        Average(1, 2, 3, 4, 5);
        Sum(1, 2, 3, 4, 5);
        Product(1, 2, 3, 4, 5);
    }
}