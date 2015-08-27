
/*
                 Problem 1. Leap year

    Write a program that reads a year from the console and checks whether it is a leap one.
    Use System.DateTime.
*/

using System;

class LeapYear
{
    static void Main()
    {
        Console.Write("Enter year: ");
        int year;
        if (!(int.TryParse(Console.ReadLine(), out year)))
        {
            Console.WriteLine("Invalid year!");
            return;
        }

        if(DateTime.IsLeapYear(year))
        {
            Console.WriteLine("The year is leap!");
        }
        else
        {
            Console.WriteLine("The year is not a leap year!");
        }
    }
}