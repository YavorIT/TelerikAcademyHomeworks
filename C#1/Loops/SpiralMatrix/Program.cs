
/*
                                 Problem 19.** Spiral Matrix

    Write a program that reads from the console a positive integer number n (1 ≤ n ≤ 20) and prints a matrix 
    holding the numbers from 1 to n*n in the form of square spiral like in the examples below.
    
    Examples:

                               n = 2   matrix      n = 3   matrix      n = 4   matrix
                                        1 2                 1 2 3               1  2  3  4
                                        4 3                 8 9 4               12 13 14 5
                                                            7 6 5               11 16 15 6
                                                                                10 9  8  7
*/

using System;

class SpiralMatrix
{
    static void Main()
    {
        Console.Write ("Enter the integer n [1;20]: ");
        int n; 

        if(!(int.TryParse(Console.ReadLine(), out n)) || n > 20 || n < 1)
        {
            Console.WriteLine("Please enter a valid integer!");
            return;
        }
            
        int[,] matrix = new int[n,n];

        int row1 = 0;
        int row2 = n - 1;
        int col1 = 0;
        int col2 = n - 1;
        int number = 1;

        while (number <= n * n)
        {
            for (int i = col1; i <= col2; i++)
            {
                matrix[row1, i] = number;
                number++;
            }

            for (int j = row1 + 1; j <= row2; j++)
            {
                matrix[j, col2] = number;
                number ++;
            }

            for (int i = col2 - 1; i >= col1; i--)
            {
                matrix[row2, i] = number;
                number++;
            }

            for (int j = row2 - 1; j >= row1 + 1; j--)
            {
                matrix[j, col1] = number;
                number++;
            }

            col1++;
            col2--;
            row1++;
            row2--;
        }

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write("{0,-3} ", matrix[i, j]);
            }
            Console.WriteLine();
        }
    }
}