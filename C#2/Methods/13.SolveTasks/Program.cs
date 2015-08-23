
/*
             Problem 13. Solve tasks

    Write a program that can solve these tasks:

    1. Reverses the digits of a number
    2. Calculates the average of a sequence of integers
    3. Solves a linear equation a * x + b = 0
    
    Create appropriate methods.

    Provide a simple text-based menu for the user to choose which task to solve.

    Validate the input data:
        The decimal number should be non-negative
        The sequence should not be empty
        a should not be equal to 0
*/  

using System;

class SolveTasks
{
    static void Menu()
    {
        Console.WriteLine("\t\t MENU");
        Console.WriteLine("1. Reverse the digits of a number");
        Console.WriteLine("2. Calculate the average of a sequence of integers");
        Console.WriteLine("3. Solve a linear equation");

        Console.Write("\nYour Option is: ");
        int option = int.Parse(Console.ReadLine());

        switch (option)
        {
            case 1:
                digitReverse();
                break;
            case 2:
                AverageOfIntegers();
                break;
            case 3:
                SolveEquation();
                break;
            default:
                Console.WriteLine("Invalid option!!!");
                break;
        }
    }

    static void digitReverse()
    {
        Console.Write("Enter your number: ");
        string number = Console.ReadLine();
        double isPositive = double.Parse(number);

        if(isPositive < 0)
        {
            Console.WriteLine("The number should not be negative!!!");
            return;
        }

        string reversed = string.Empty;
        for (int i = number.Length - 1; i >= 0; i--)
        {
            reversed += number[i];
        }

        double numberReversed = double.Parse(reversed);

        Console.WriteLine("Reversed number is: {0}", numberReversed);
    }

    static void AverageOfIntegers()
    {
        Console.WriteLine("Enter the integers separated by a space: ");
        string[] input = Console.ReadLine().Split(' ');
        if(input.Length == 0)
        {
            Console.WriteLine("The sequence should not be empty!!!");
            return;
        }

        double[] numbers = new double[input.Length];

        double sum = 0;
        for (int i = 0; i < input.Length; i++)
        {
            numbers[i] = double.Parse(input[i]);
            sum += numbers[i];
        }

        Console.WriteLine("The average is: {0}", (sum / numbers.Length));
    }

    static void SolveEquation()
    {
        Console.Write("Enter the coefficient of X^1: ");
        double a = double.Parse(Console.ReadLine());

        if(a == 0)
        {
            Console.WriteLine("a has to be greater than or less than 0!!!");
            return;
        }

        Console.Write("Enter the coefficient of X^0: ");
        double b = double.Parse(Console.ReadLine());

        Console.WriteLine("X = {0}", -b / a);
    }

    static void Main()
    {
        Menu();
    }
}