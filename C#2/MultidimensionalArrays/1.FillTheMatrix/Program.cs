
/*
                             Problem 1. Fill the matrix

   Write a program that fills and prints a matrix of size (n, n) as shown below:

                                  Example for n = 4:
   a)	                    b)	                     c)	                        d)*

   1    5	9	13          1	8	9	16           7	11	14	16            1	12	11	10     
   2	6	10	14          2	7	10	15           4	8	12	15            2	13	16	9
   3	7	11	15          3	6	11	14           2	5	9	13            3	14	15	8
   4	8	12	16          4   5   12  13           1	3	6	10            4	5	6	7
*/

using System;

class FillTheMatrix
{
    static void Main()
    {
        Console.Write("Enter n: ");
        int n;
        if (!(int.TryParse(Console.ReadLine(), out n)))
        {
            Console.WriteLine("Please enter a valid integer!");
            return;
        }

        int[,] matrix = new int[n, n];
        int currentNumber = 1;


        // a)

        for (int col = 0; col < n; col++)
        {
            for (int row = 0; row < n; row++)
            {
                matrix[row, col] = currentNumber;
                currentNumber++;
            }
        }

        //Print the matrix
        Console.WriteLine("a)");
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("{0, 4}", matrix[row, col]);
                if (col != matrix.GetLength(1) - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine();
        }


        // b)

        currentNumber = 1;
        for (int col = 0; col < n; col++)
        {
            if (col % 2 == 0)
            {
                for (int row = 0; row < n; row++)
                {
                    matrix[row, col] = currentNumber;
                    currentNumber++;
                }
            }
            else
            {

                for (int row = n - 1; row >= 0; row--)
                {
                    matrix[row, col] = currentNumber;
                    currentNumber++;
                }
            }
        }

        //Print the matrix
        Console.WriteLine("b)");
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("{0, 4}", matrix[row, col]);
                if (col != matrix.GetLength(1) - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine();
        }


        // c)

        currentNumber = 1;
        int cols = 0;

        // fill the triangle below the diagonal and the diagonal
        for (int i = 1; i <= n; i++)
        {
            cols = 0;
            for (int row = n - i; row < n; row++)
            {
                matrix[row, cols] = currentNumber;
                currentNumber++;
                cols++;
            }
        }

        // fill the triangle above the diagonal
        for (int i = 1; i < n; i++)
        {
            cols = i;
            for (int row = 0; row < n - i; row++)
            {
                matrix[row, cols] = currentNumber;
                currentNumber++;
                cols++;
            }

        }

        //Print the matrix
        Console.WriteLine("c)");
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("{0, 4}", matrix[row, col]);
                if (col != matrix.GetLength(1) - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine();
        }


        // d*)
        currentNumber = 1;
        int incRow = 0; // always increasing shows the starting row
        int incCol = 0; // always increasing shows the starting column
        int decRow = n; // always decreasing shows the ending row 
        int decCol = n; // always decreasing shows the ending column 

        while (currentNumber <= n * n)
        {
            for (int row = incRow; row < decRow; row++)
            {
                matrix[row, incCol] = currentNumber;
                currentNumber++;
            }

            for (int col = incCol + 1; col < decCol; col++)
            {
                matrix[decRow - 1, col] = currentNumber;
                currentNumber++;
            }

            for (int row = decRow - 2; row > incRow; row--)
            {
                matrix[row, decCol - 1] = currentNumber;
                currentNumber++;
            }

            for (int col = decCol - 1; col > incCol; col--)
            {
                matrix[incRow, col] = currentNumber;
                currentNumber++;
            }

            incRow++;
            incCol++;

            decCol--;
            decRow--;
        }


        //Print the matrix
        Console.WriteLine("d*)");
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("{0, 4}", matrix[row, col]);
                if (col != matrix.GetLength(1) - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine();
        }
    }
}