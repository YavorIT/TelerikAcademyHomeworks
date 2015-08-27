
/*
              Problem 5. Workdays

    Write a method that calculates the number of workdays between today and given date, passed as parameter.
    Consider that workdays are all days from Monday to Friday except a fixed list of public holidays specified preliminary as array.
*/

using System;
using System.Collections.Generic;

class WorkDays
{
    static int WorkDaysCount(List<DateTime> holidays, DateTime finalDate)
    {
        int workDaysCount = 0;
        DateTime currentDate = DateTime.Today;

        while (currentDate <= finalDate)
        {
            if (currentDate.DayOfWeek != DayOfWeek.Saturday && currentDate.DayOfWeek != DayOfWeek.Sunday && !holidays.Contains(currentDate))
            {
                workDaysCount++;
            }

            currentDate = currentDate.AddDays(1);
        }

        return workDaysCount;
    }

    static void GenerateHolidays(List<DateTime> holidays)
    {
        
        holidays.Add(Convert.ToDateTime("24 12"));      // 
        holidays.Add(Convert.ToDateTime("25 12"));      // CHRISTMAS  Current Year
        holidays.Add(Convert.ToDateTime("26 12"));      //

        holidays.Add(Convert.ToDateTime("31 12")); //  NEW YEAR  Current Year
        holidays.Add(Convert.ToDateTime("1 1"));   //
    }

    static void Main()
    {
        Console.Write("Enter the final date: ");
        DateTime userDate;
        if (!(DateTime.TryParse(Console.ReadLine(), out userDate)))
        {
            Console.WriteLine("Ivalid Date!!!");
            return;
        }

        if (userDate < DateTime.Now)
        {
            Console.WriteLine("The date must not be in the past!");
            return;
        }

        List<DateTime> holidays = new List<DateTime>();

        GenerateHolidays(holidays); // fills the list of holidays

        int workDays = WorkDaysCount(holidays, userDate);

        Console.WriteLine("The work days are: {0}", workDays);
    }
}