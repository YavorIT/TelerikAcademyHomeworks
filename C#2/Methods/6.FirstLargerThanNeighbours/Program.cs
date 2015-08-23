
/*
                                     Problem 6. First larger than neighbours

    Write a method that returns the index of the first element in array that is larger than its neighbours, or -1, if there’s no such element.
    Use the method from the previous exercise.
*/

using System;

class FirstLargerThanNeighbours
{
    static int firstLargerindex(double[] input)
    {
        if (input.Length < 3)
        {
            return -1;
        }

        for (int i = 1; i < input.Length - 1; i++)
        {
           if(input[i] > input[i - 1] && input[i] > input[i + 1])
            {
                return i;
            }  
        }
        return -1;
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

        int index = firstLargerindex(numbers);

        if (index == -1)
        {
            Console.WriteLine("There is not such a number!");
            return;
        }
        else
        {
            Console.WriteLine("the index is: {0}", index);
        }
    }
}