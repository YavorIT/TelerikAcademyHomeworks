
/*
                                                 Problem 2. Maximal sum

    Write a program that reads a rectangular matrix of size N x M and finds in it the square 3 x 3 that has maximal sum of its elements.
*/

using System;

class MaximalSum
{
    static void Main()
    {
        Console.Write("Enter N: ");
        int n;
        if(!(int.TryParse(Console.ReadLine(), out n)))
        {
            Console.WriteLine("Please enter a valid integer!");
            return;
        }

        Console.Write("Enter M: ");
        int m;
        if (!(int.TryParse(Console.ReadLine(), out m)))
        {
            Console.WriteLine("Please enter a valid integer!");
            return;
        }

        if(n < 3 || m < 3)
        {
            Console.WriteLine("There is not a 3x3 square!");
            return;
        }

        int[,] triangularMatrix = new int[n, m];
        string[] numbers = new string[m];


        Console.WriteLine("Enter the matrix below:");
        for (int i = 0; i < n; i++)
        {
            string input = Console.ReadLine();
            numbers = input.Split(' ');

            for (int j = 0; j < m; j++)
            {
                triangularMatrix[i, j] = int.Parse(numbers[j]);
            }
        }

        // initializing bestSum with the sum of the first 3x3 square elements
        int bestSum = 0;
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                bestSum += triangularMatrix[i, j];
            }
        }

        int bestRow = 0;
        int bestCol = 0;
        int currentSum = 0;

        for (int row = 0; row < n - 2; row++)
        {
            for (int col = 0; col < m - 2; col++)
            {
                currentSum = triangularMatrix[row, col] + triangularMatrix[row, col + 1] + triangularMatrix[row, col + 2] + triangularMatrix[row + 1, col] + triangularMatrix[row + 1, col + 1] + triangularMatrix[row + 1, col + 2] + triangularMatrix[row + 2, col] + triangularMatrix[row + 2, col + 1] + triangularMatrix[row + 2, col + 2];
                if(currentSum > bestSum)
                {
                    bestSum = currentSum;
                    bestRow = row;
                    bestCol = col;
                }
            }
        }

        // printing the matrix
        Console.WriteLine("\nThe red numbers are the best 3x3 square!");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                if(i >= bestRow && i <= bestRow + 2 && j >= bestCol && j <= bestCol + 2)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }else
                {
                    Console.ForegroundColor = ConsoleColor.White;
                }
                Console.Write("{0}", triangularMatrix[i, j]);
                if(j != m - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine();
        }

        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("\nBest sum is: {0}", bestSum);


    }
}