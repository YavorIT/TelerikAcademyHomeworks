
/*
                         Problem 5. Larger than neighbours

    Write a method that checks if the element at given position in given array of integers
    is larger than its two neighbours (when such exist).
*/

using System;

class LargerThanNeighbours
{
    static bool isLarger (double[] input, double number)
    {
        if(number == input[0] || number == input[input.Length - 1])
        {
            Console.WriteLine("The number hasn't got two neighbours!");
            return false;
        }

        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] == number)
            {
                if (number > input[i - 1] && number > input[i + 1])
                {
                    return true;
                }
            }
        }
        return false;
    }

    static void Main()
    {
        Console.WriteLine("Enter the array numbers separated by a space: ");
        string[] input = Console.ReadLine().Split(' ');

        double[] numbers = new double[input.Length];

        for (int i = 0; i < input.Length; i++)
        {
            numbers[i] = double.Parse(input[i]);
        }

        Console.Write("Enter the number to compare: ");
        double numberToCompare = double.Parse(Console.ReadLine());

        bool isBigger = isLarger(numbers, numberToCompare);

        Console.WriteLine("The number is bigger than it's neighbours in the array: {0}", isBigger);
    }
}