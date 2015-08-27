
/*
                Problem 7.* Largest area in matrix

    Write a program that finds the largest area of equal neighbour elements in a rectangular matrix and prints its size.

                 Example:

                matrix                     result
                1	3	2	2	2	4 |
                3	3	3	2	4	4 |
                4	3	1	2	3	3 |       13  
                4	3	1	3	3	1 |
                4   3	3	3	1	1 |

                The 3s are the biggest one!
*/

// HUGE HELP FROM THE INTERNET

using System;

class LargestAreaInMatrix
{
    static int[] dirX = { -1, 1, 0, 0 }; // possible directions of the rows
    static int[] dirY = { 0, 0, -1, 1 }; // possible directions of the columns

    public static int DFS (int[,] input, int curX, int curY, int currValue, bool[,] isVisited)
    {
        if(isVisited[curX, curY] == true)
        {
            return 0;
        }
        else
        {
            isVisited[curX, curY] = true;
            int bestSum = 0;
            int bestX = curX;
            int bestY = curY;

            for (int i = 0; i < 4; i++)
            {
                int directionX = dirX[i] + curX; // next row direction
                int directionY = dirY[i] + curY; // next column direction

                if(directionX == -1 || directionX >= input.GetLength(0) || directionY == -1 || directionY >= input.GetLength(1)) // Out of the bounds of the matrix
                {
                    continue;
                }

                if(input[directionX, directionY] == currValue) // the value is equal to the currValue which we are looking for
                {
                    int newValue = DFS(input, directionX, directionY, currValue, isVisited);
                    bestSum += newValue;
                }
            }

            return bestSum + 1;
        }
    }

    static void Main()
    {
        int[,] matrix = new int[5, 6]
        {
            {1, 3, 2, 2, 2, 4},
            {3, 3, 3, 2, 4, 4},
            {4, 3, 1, 2, 3, 3},
            {4, 3, 1, 3, 3, 1},
            {4, 3, 3, 3, 1, 1}
        };

        bool[,] visited = new bool [matrix.GetLength(0), matrix.GetLength(1)]; // an array with the same dimensions as the matrix. Holds a true or false value if the element is already visited
        int currentCount = 0; // current area elements count
        int max = 0; // biggest area elements count

        for (int row = 0; row < matrix.GetLength(0); row++) 
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
              if(visited[row,col] == false) // element is not visited already
                {
                    currentCount = DFS(matrix, row, col, matrix[row, col], visited);

                    if(currentCount > max)
                    {
                        max = currentCount;
                    }
                }
            }
        }

        Console.WriteLine("The biggest area have {0} elements!", max);
    }
}