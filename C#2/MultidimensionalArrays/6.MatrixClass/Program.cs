
/*
                     Problem 6.* Matrix class

    Write a class Matrix, to hold a matrix of integers.
    Overload the operators for adding, subtracting and multiplying of matrices, 
    indexer for accessing the matrix content and ToString().
*/

// I have added a printing method in the Matrix class.

using System;

class Matrix
{
    public int row { get; set; }
    public int col { get; set; }
    public int[,] matrix;

    public Matrix(int rows, int cols)
    {
        this.row = rows;
        this.col = cols;
        matrix = new int[row, col];
    }

    public int Length
    {
        get
        {
            return matrix.Length;
        }
    }

    public int this[int row, int col]
    {
        get
        {
            return matrix[row, col];
        }

        set
        {
            matrix[row, col] = value;
        }
    }

    public static Matrix operator + (Matrix matrixA, Matrix matrixB)
    {
        Matrix result = new Matrix(matrixA.row, matrixA.col);
        if(matrixA.row != matrixB.row || matrixA.col != matrixB.col)
        {
            Console.WriteLine("Can't do the operation with this two matrices!");
            return result;
        }

        for (int row = 0; row < matrixA.row; row++)
        {
            for (int col = 0; col < matrixA.col; col++)
            {
                result.matrix[row, col] = matrixA.matrix[row, col] + matrixB.matrix[row, col];
            }
        }
        return result;
    }

    public static Matrix operator - (Matrix matrixA, Matrix matrixB)
    {
        Matrix result = new Matrix(matrixA.row, matrixA.col);
        if (matrixA.row != matrixB.row || matrixA.col != matrixB.col)
        {
            Console.WriteLine("Can't do the operation with this two matrices!");
            return result;
        }

        for (int row = 0; row < matrixA.row; row++)
        {
            for (int col = 0; col < matrixA.col; col++)
            {
                result.matrix[row, col] = matrixA.matrix[row, col] - matrixB.matrix[row, col];
            }
        }
        return result;
    }

    public static Matrix operator * (Matrix matrixA, Matrix matrixB)
    {
        Matrix resultMatrix = new Matrix(matrixA.row, matrixB.col);
        if (matrixA.col != matrixB.row)
        {
            Console.WriteLine("You can't multiply this two matrices!");
            return resultMatrix;
        }
        else
        {

            for (int row = 0; row < resultMatrix.row; row++)
            {
                for (int col = 0; col < resultMatrix.col; col++)
                {
                    int value = 0;
                    for (int i = 0; i < matrixA.col; i++)
                    {
                        value = value + matrixA.matrix[row, i] * matrixB.matrix[i, col];
                    }
                    resultMatrix[row, col] = value;
                }
            }

            return resultMatrix;
        }
    }

    public override string ToString()
    {
        string matrixString = string.Empty;

        for (int row = 0; row < this.row; row++)
        {
            for (int col = 0; col < this.col; col++)
            {
                matrixString += matrix[row, col];
                if (col != this.col)
                {
                    matrixString += ", ";
                }
            }
        }
        return matrixString;
    }

    public static void Print (Matrix matrixToPrint)
    {
        for (int row = 0; row < matrixToPrint.row; row++)
        {
            for (int col = 0; col < matrixToPrint.col; col++)
            {
                Console.Write("{0,3}", matrixToPrint.matrix[row, col]);
                if(col != matrixToPrint.col - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine();
        }
    }
}


class MatrixClass
{
    static void Main()
    {
        Matrix firstMatrix = new Matrix(5, 5);
        Matrix secondMatrix = new Matrix(5, 5);

        for (int row = 0; row < firstMatrix.row; row++)
        {
            for (int col = 0; col < firstMatrix.col; col++)
            {
                firstMatrix[row, col] = row + col;
            }
        }

        for (int row = 0; row < secondMatrix.row; row++)
        {
            for (int col = 0; col < secondMatrix.col; col++)
            {
                secondMatrix[row, col] = row * col;
            }
        }

        Console.WriteLine("The First Matrix is:\n");
        Matrix.Print(firstMatrix);
        Console.WriteLine("\nThe Second Matrix is:\n");
        Matrix.Print(secondMatrix);

        Console.WriteLine("\nFirst matrix to string:\n{0}", firstMatrix);
        Console.WriteLine("\nSecond matrix to string:\n{0}", secondMatrix.ToString());

        Console.WriteLine("\nThe sum matrix is:\n");
        Matrix.Print(firstMatrix + secondMatrix);

        Console.WriteLine("\nThe result of substracting the matrices is:\n");
        Matrix.Print(firstMatrix - secondMatrix);

        Console.WriteLine("\nThe result of multiplying the matrices is:\n");
        Matrix.Print(firstMatrix * secondMatrix);
    }
}