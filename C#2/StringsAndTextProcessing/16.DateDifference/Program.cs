
/*
                                            Problem 16. Date difference

    Write a program that reads two dates in the format: day.month.year
    and calculates the number of days between them.

    Example:

    Enter the first date: 27.02.2006
    Enter the second date: 3.03.2006
    Distance: 4 days
*/

using System;

class DateDifference
{
    static double DaysDistance(DateTime firstDate, DateTime secondDate)
    {
        return (firstDate.Date - secondDate.Date).Days > 0 ? (firstDate.Date - secondDate.Date).Days : (-1) * (firstDate.Date - secondDate.Date).Days;
    }

    static DateTime DateInput ()
    {
        Console.Write("Enter date: ");
        return DateTime.Parse(Console.ReadLine());
    }

    static void Main()
    {
        Console.WriteLine("\t\tEnter the dates in the day.month.year format!\n\n");

        DateTime firstDate = DateInput();
        DateTime secondDate = DateInput();

        Console.WriteLine("Distance: {0} days", DaysDistance(firstDate, secondDate));
    }
}