
/*
                         Problem 5. Maximal area sum

    Write a program that reads a text file containing a square matrix of numbers.
    Find an area of size 2 x 2 in the matrix, with a maximal sum of its elements.

    The first line in the input file contains the size of matrix N.

    Each of the next N lines contain N numbers separated by space.

    The output should be a single number in a separate text file.
*/

using System.IO;

class MaximalAreaSum
{
    static double[,] ReadTheMatrix (StreamReader reader)
    {
        int matrixSize = int.Parse(reader.ReadLine());
        double[,] matrix = new double[matrixSize, matrixSize];
        for (int row = 0; row < matrixSize; row++)
        {
            string[] numbersInLine = reader.ReadLine().Split(' ');
            for (int col = 0; col < matrixSize; col++)
            {
                matrix[row, col] = double.Parse(numbersInLine[col]);
            }          
        }
        return matrix;
    }

    static double TwoByTwoSquareSum(double[,] matrix, int i, int j)
    {
        return matrix[i, j] + matrix[i + 1, j] + matrix[i, j + 1] + matrix[i + 1, j + 1];
    }

    private static double FindMaxSum(double[,] matrix)
    {
        double currSum = 0;
        double max = 0;

        for (int row = 0; row < matrix.GetLength(0) - 1; row++)
        {
            for (int col = 0; col < matrix.GetLength(1) - 1; col++)
            {
                currSum = TwoByTwoSquareSum(matrix, row, col);
                if (max < currSum)
                {
                    max = currSum;
                }
            }
        }

        return max;
    }

    static void Main()
    {
        StreamReader reader = new StreamReader(@"..\..\Files\input.txt");
        StreamWriter writer = new StreamWriter(@"..\..\Files\output.txt");
        double maxSum = 0;

        using (reader)
        {
            double[,] matrix = ReadTheMatrix(reader);
            maxSum = FindMaxSum(matrix);           
        }

        using (writer)
        {
            writer.WriteLine(maxSum);
        }
    }
}