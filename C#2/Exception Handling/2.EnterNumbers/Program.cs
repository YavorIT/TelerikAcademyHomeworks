
/*
                          Problem 2. Enter numbers

    Write a method ReadNumber(int start, int end) that enters an integer number in a given range [start…end].
    If an invalid number or non-number text is entered, the method should throw an exception.
    Using this method write a program that enters 10 numbers: a1, a2, … a10, such that 1 < a1 < … < a10 < 100
*/

using System;

class EnterNumbers
{
    static int ReadNumber(int start, int end)
    {
        int number = 0;
        try
        {
            number = int.Parse(Console.ReadLine());
        }
        catch (FormatException)
        {
            Console.WriteLine("The number wasn't in the correct format!");
            Console.WriteLine("It must be integer!");
            Environment.Exit(0);
        }
        catch (OverflowException)
        {
            Console.WriteLine("The number is too big or too small!");
            Environment.Exit(1);
        }

        if (number < start || number > end)
        {
            Console.WriteLine("The numbers must be within the range!");
            Environment.Exit(2);
        }

        return number;
    }

    static void Main()
    {
        int[] numbers = new int[10];
        Console.Write("Enter the first number [2 ; {0}]: ", 100 - numbers.Length);
        numbers[0] = ReadNumber(2, 100 - numbers.Length);
        for (int i = 1; i < numbers.Length; i++)
        {
            Console.Write("Enter the {0} number [{1}, {2}]: ", i + 1, numbers[i - 1] + 1, 100 - numbers.Length + i);
            numbers[i] = ReadNumber(numbers[i - 1] + 1, 100 - numbers.Length + i);
        }

        Console.WriteLine("\n{0}", String.Join(", ", numbers));
    }
}