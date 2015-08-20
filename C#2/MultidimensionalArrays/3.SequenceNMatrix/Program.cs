
/*
                Problem 3. Sequence n matrix

    We are given a matrix of strings of size N x M. 
    Sequences in the matrix we define as sets of several neighbour elements located on the same line, column or diagonal.

    Write a program that finds the longest sequence of equal strings in the matrix.

                                Examples:

         matrix             Result                    matrix             Result

    ha	fifi	ho	hi  |                             s	 qq	s    |
    fo	ha	hi	xx      |   ha, ha, ha                pp pp	s    |       s, s, s
    xxx	ho	ha	xx      |                             pp qq	s    |
*/

using System;


class SequenceNMatrix
{
    static void Main()
    {
        Console.Write("Enter N: ");
        int n;
        if (!(int.TryParse(Console.ReadLine(), out n)))
        {
            Console.WriteLine("Please enter a valid integer!!!");
            return;
        }

        Console.Write("Enter M: ");
        int m;
        if (!(int.TryParse(Console.ReadLine(), out m)))
        {
            Console.WriteLine("Please enter a valid integer!!!");
            return;
        }

        if (n <= 0 || m <= 0)
        {
            Console.WriteLine("Matrix dimension can't be less or equal to zero!");
            return;
        }

        string[,] matrix = new string[n, m];

        Console.WriteLine("Fill the matrix {0}x{1}: \n", n, m);
        for (int row = 0; row < n; row++)
        {
            string input = Console.ReadLine();
            string[] singleStrings = input.Split(' ');
            for (int col = 0; col < m; col++)
            {
                matrix[row, col] = singleStrings[col];
            }
        }

        string currElement;
        int currCount = 1;
        int maxCount = 0;
        string currSequence = string.Empty;
        string result = string.Empty;

        // the main two cycles go through all of the elements
        // The bodies of the rest cycles are absolutely the same only the conditions are different
        // the if-else statements check where is the element and decide which way to compare with the element
        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < m; col++)
            {
                currElement = matrix[row, col]; // current element
                currSequence = currElement + ", "; // current result is the current element
                currCount = 1; // current number of equal elements in the sequnce
                if(row == 0 && row != n - 1 && col != m - 1)
                {
                    // checks the line left to right
                    for (int cols = col + 1; cols < m; cols++)
                    {
                        if (currElement != matrix[row, cols]) // if the elements are different break the loop
                        {
                            break; 
                        }
                        else
                        {
                            currCount++; // current elements increment with one
                            currSequence += currElement + ", "; // add the element to the sequence
                            if(currCount > maxCount) // if current elements are more than the longest sequence ones
                            {
                                maxCount = currCount; // longest sequence elements
                                result = string.Empty; // result = ""
                                result += currSequence; // result becomes the current sequence
                            }
                        }
                    }
                    currSequence = currElement + ", ";  // start over with another direction
                    currCount = 1;

                    // checks top to bottom 
                    for (int rows = row + 1; rows < n; rows++)
                    {
                        if (currElement != matrix[rows, col])
                        {
                            break;
                        }
                        else
                        {
                            currCount++;
                            currSequence += currElement + ", ";
                            if (currCount > maxCount)
                            {
                                maxCount = currCount;
                                result = string.Empty;
                                result += currSequence;
                            }
                        }
                    }
                    currSequence = currElement + ", ";
                    currCount = 1;

                    // checks the bottom right diagonal
                    for (int cols = col + 1, rows = row + 1; cols < m && rows < n; cols++, rows++)
                    {
                        if (currElement != matrix[rows, cols])
                        {
                            break;
                        }
                        else
                        {
                            currCount++;
                            currSequence += currElement + ", ";
                            if (currCount > maxCount)
                            {
                                maxCount = currCount;
                                result = string.Empty;
                                result += currSequence;
                            }
                        }
                    }
                    currSequence = currElement + ", ";
                    currCount = 1;

                }
                else if (row == 0 && row == n - 1 && col != m - 1)
                {
                    // checks the line left to right 
                    for (int cols = col + 1; cols < m; cols++)
                    {
                        if (currElement != matrix[row, cols])
                        {
                            break;
                        }
                        else
                        {
                            currCount++;
                            currSequence += currElement + ", ";
                            if (currCount > maxCount)
                            {
                                maxCount = currCount;
                                result = string.Empty;
                                result += currSequence;
                            }
                        }
                    }
                    currSequence = currElement + ", ";
                    currCount = 1;

                }
                else if (row != 0 && row == n - 1 && col != m - 1)
                {
                    // checks the line left to right
                    for (int cols = col + 1; cols < m; cols++)
                    {
                        if (currElement != matrix[row, cols])
                        {
                            break;
                        }
                        else
                        {
                            currCount++;
                            currSequence += currElement + ", ";
                            if (currCount > maxCount)
                            {
                                maxCount = currCount;
                                result = string.Empty;
                                result += currSequence;
                            }
                        }
                    }
                    currSequence = currElement + ", ";
                    currCount = 1;

                    // checks the top right diagonal
                    for (int rows = row - 1, cols = col + 1; rows >= 0 && cols < m; rows--, cols++)
                    {
                        if (currElement != matrix[rows, cols])
                        {
                            break;
                        }
                        else
                        {
                            currCount++;
                            currSequence += currElement + ", ";
                            if (currCount > maxCount)
                            {
                                maxCount = currCount;
                                result = string.Empty;
                                result += currSequence;
                            }
                        }
                    }
                    currSequence = currElement + ", ";
                    currCount = 1;

                }
                else if (row != n - 1 && col == m - 1)
                {

                    // checks top to bottom
                    for (int rows = row + 1; rows < n; rows++)
                    {
                        if (currElement != matrix[rows, col])
                        {
                            break;
                        }
                        else
                        {
                            currCount++;
                            currSequence += currElement + ", ";
                            if (currCount > maxCount)
                            {
                                maxCount = currCount;
                                result = string.Empty;
                                result += currSequence;
                            }
                        }
                    }
                    currSequence = currElement + ", ";
                    currCount = 1;

                }
                else if (row != 0 && row != n - 1 && col != m - 1)
                {
                    // checks the line left to right
                    for (int cols = col + 1; cols < m; cols++)
                    {
                        if (currElement != matrix[row, cols])
                        {
                            break;
                        }
                        else
                        {
                            currCount++;
                            currSequence += currElement + ", ";
                            if (currCount > maxCount)
                            {
                                maxCount = currCount;
                                result = string.Empty;
                                result += currSequence;
                            }
                        }
                    }
                    currSequence = currElement + ", ";
                    currCount = 1;

                    // checks top to bottom
                    for (int rows = row + 1; rows < n; rows++)
                    {
                        if (currElement != matrix[rows, col])
                        {
                            break;
                        }
                        else
                        {
                            currCount++;
                            currSequence += currElement + ", ";
                            if (currCount > maxCount)
                            {
                                maxCount = currCount;
                                result = string.Empty;
                                result += currSequence;
                            }
                        }
                    }
                    currSequence = currElement + ", ";
                    currCount = 1;

                    // checks the bottom right diagonal
                    for (int cols = col + 1, rows = row + 1; cols < m && rows < n; cols++, rows++)
                    {
                        if (currElement != matrix[rows, cols])
                        {
                            break;
                        }
                        else
                        {
                            currCount++;
                            currSequence += currElement + ", ";
                            if (currCount > maxCount)
                            {
                                maxCount = currCount;
                                result = string.Empty;
                                result += currSequence;
                            }
                        }
                    }
                    currSequence = currElement + ", ";
                    currCount = 1;

                    // checks the top right diagonal
                    for (int rows = row - 1, cols = col + 1; rows >= 0 && cols < m; rows--, cols++)
                    {
                        if (currElement != matrix[rows, cols])
                        {
                            break;
                        }
                        else
                        {
                            currCount++;
                            currSequence += currElement + ", ";
                            if (currCount > maxCount)
                            {
                                maxCount = currCount;
                                result = string.Empty;
                                result += currSequence;
                            }
                        }
                    }
                    currSequence = currElement + ", ";
                    currCount = 1;

                }
                else
                {
                    continue;
                }
            }
        }

        result = result.Remove(result.Length - 2, 2); // removes the last ", " from the string
        Console.WriteLine("\nThe longest sequence is: {0}", result);
    }
}