
/*
                             Problem 11. Random Numbers in Given Range

    Write a program that enters 3 integers n, min and max (min != max)
    and prints n random numbers in the range [min...max].
*/

using System;

class Program
{
    static void Main()
    {
        Console.Write ("Enter the integer n: ");
        int n; 
        if (!(int.TryParse(Console.ReadLine(), out n)))
        {
            Console.WriteLine("Please enter a valid integer!");
            return;
        }

        Console.Write("Enter the minimal integer min: ");
        int min;
        if (!(int.TryParse(Console.ReadLine(), out min)))
        {
            Console.WriteLine("Please enter a valid integer!");
            return;
        }

        Console.Write("Enter the maximal integer max: ");
        int max;
        if (!(int.TryParse(Console.ReadLine(), out max)))
        {
            Console.WriteLine("Please enter a valid integer!");
            return;
        }

        if (min >= max)
        {
            Console.WriteLine("The interval minimum has to be less than the maximum!");
            return;
        }

        Random randomNumbersGenerator = new Random();

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("{0} Random Number: {1}", i + 1, randomNumbersGenerator.Next (min, max + 1));
        }
    }
}