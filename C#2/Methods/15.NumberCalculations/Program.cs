
/*
                             Problem 15.* Number calculations

    Modify your last program and try to make it work for any number type, not just integer (e.g. decimal, float, byte, etc.)
    Use generic method (read in Internet about generic methods in C#).
*/


/* The first two methods (Minimum and Maximum) can be done like that:

    T min; where T: IComparable<T> and instead input[i] < min we will have input[i].CompareTo(min) < 0
    same as Maximum but input[i].CompareTo(min) > 0
*/

using System;

class IntegerCalculations
{
    static void Minimum<T>(params T[] input)
    {
        dynamic min = input[0];
        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] < min)
            {
                min = input[i];
            }
        }
        Console.WriteLine("The minimun element is: {0}", min);
    }

    static void Maximum<T>(params T[] input)
    {
        dynamic max = input[0];
        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] > max)
            {
                max = input[i];
            }
        }
        Console.WriteLine("The minimun element is: {0}", max);
    }

    static void Average<T>(params T[] input)
    {
        dynamic sum = 0;
        for (int i = 0; i < input.Length; i++)
        {
            sum += input[i];
        }
        Console.WriteLine("The average is: {0}", sum / input.Length);
    }

    static void Sum<T>(params T[] input)
    {
        dynamic sum = 0;

        for (int i = 0; i < input.Length; i++)
        {
            sum += input[i];
        }
        Console.WriteLine("The sum is: {0}", sum);
    }

    static void Product<T>(params T[] input)
    {
        dynamic product = 1;
        for (int i = 0; i < input.Length; i++)
        {
            product *= input[i];
        }
        Console.WriteLine("The poduct is: {0}", product);
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