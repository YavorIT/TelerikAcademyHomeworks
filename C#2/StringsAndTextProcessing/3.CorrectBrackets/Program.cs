
/*
                     Problem 3. Correct brackets

    Write a program to check if in a given expression the brackets are put correctly.


    Example of correct expression: ((a+b)/5-d). Example of incorrect expression: )(a+b)).
*/

using System;

class CorrectBrackets
{
    static void Main()
    {
        Console.Write("Write the expression: ");
        string expression = Console.ReadLine();

        int leftParenthesesCount = 0;
        int rightParenthesesCount = 0;

        foreach (char character in expression)
        {
            if(character == '(')
            {
                leftParenthesesCount++;
            }
            else if (character == ')')
            {
                rightParenthesesCount++;
            }

            if(leftParenthesesCount < rightParenthesesCount)
            {
                Console.WriteLine("The brackets are put incorrectly!");
                return;
            }
        }

        Console.WriteLine("Everythig is fine!");
        Console.WriteLine("{0} - Left Parentheses", leftParenthesesCount);
        Console.WriteLine("{0} - Right Parentheses", rightParenthesesCount);
    }
}