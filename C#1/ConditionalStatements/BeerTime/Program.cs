
/*
                                                             Problem 10.* Beer Time

    A beer time is after 1:00 PM and before 3:00 AM.
    Write a program that enters a time in format “hh:mm tt” (an hour in range [01...12],
    a minute in range [00…59] and AM / PM designator) and prints beer time or non-beer time 
    according to the definition above or invalid time if the time cannot be parsed.
    
    Note: You may need to learn how to parse dates and times.
*/

using System;

class BeerTime
{
    static void Main()
    {
        DateTime late = DateTime.Parse("1:00 PM");
        DateTime early = DateTime.Parse("3:00 AM");
        var earlyTime = early.TimeOfDay;
        var lateTime = late.TimeOfDay;
        Console.WriteLine ("Enter the time in the format hh:mm:  AM/PM");
        Console.Write ("Time: ");
        DateTime userInput;

       if(!(DateTime.TryParse (Console.ReadLine(), out userInput)))
        {
            Console.WriteLine("Time doesn't exist or it's not in the correct format!");
            return;
        }

        var userTime = userInput.TimeOfDay;

        if ( !((userTime.CompareTo(earlyTime)) > 0 && (userTime.CompareTo (lateTime)) < 0)) 
        {
            Console.WriteLine("BEER TIME!");
        }
        else
        {
            Console.WriteLine("non - beer time");
        }
    }
}