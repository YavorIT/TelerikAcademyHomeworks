
/*
                             Problem 17. Date in Bulgarian

    Write a program that reads a date and time given in the format: 
    day.month.year hour:minute:second 
    and prints the date and time after 6 hours and 30 minutes (in the same format)
    along with the day of week in Bulgarian.
*/

using System;
using System.Globalization;
using System.Threading;

class DateInBulgarian
{
    static void Main()
    {
        CultureInfo bulgarianCulture = new CultureInfo("bg-BG");
        Thread.CurrentThread.CurrentCulture = bulgarianCulture;
        Thread.CurrentThread.CurrentUICulture = bulgarianCulture;

        Console.WriteLine("The date must be in the format: day.month.year hour:minute:second");
        Console.Write("Enter date: ");
        DateTime date = DateTime.Parse(Console.ReadLine());

        date = date.AddHours(6);
        date = date.AddMinutes(30);

        Console.WriteLine("The date is: {0: HH:mm:ss ddd dd, MM, yyyy}", date);
    }
}