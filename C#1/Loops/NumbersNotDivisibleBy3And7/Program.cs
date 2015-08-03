
/*
                                         Problem 2. Numbers Not Divisible by 3 and 7

      Write a program that enters from the console a positive integer n and prints all the numbers
      from 1 to n not divisible by 3 or 7, on a single line, separated by a space.
*/

using System;

class NumbersNotDivisibleBy3And7
{
    static void Main()
    {
        Console.Write ("Enter a positive integer: ");
        int number = int.Parse(Console.ReadLine());

        for (int i = 1; i <= number; i++)
        {
          if (i % 3 == 0 || i % 7 == 0)
            {
                continue;
            }
            Console.Write ("{0} ", i);
        }
        Console.WriteLine();
    }
}
