
/*
                          Problem 9. Matrix of Numbers

    Write a program that reads from the console a positive integer number n (1 ≤ n ≤ 20) 
    and prints a matrix like in the examples below. Use two nested loops.

    n = 2   matrix      n = 3   matrix      n = 4   matrix
        1 2                 1 2 3               1 2 3 4
        2 3                 2 3 4               2 3 4 5
                            3 4 5               3 4 5 6
                                                4 5 6 7
*/

using System;

class MatrixOfNumbers
{
    static void Main()
    {
        Console.Write("Enter a number n [1;20]: ");
        int n;

        if (!(int.TryParse(Console.ReadLine(), out n)) || n < 1 || n > 20)
        {
            Console.WriteLine("Please enter a valid number!");
            return;
        }

        for (int row = 1; row <= n; row++)
        {
            for (int j = row; j < row + n; j++)
            {
                Console.Write ("{0} ", j);
            }
            Console.WriteLine();
        }
    }
}