
/*  
                         Problem 19. Dates from text in Canada

    Write a program that extracts from a given text all dates that match the format DD.MM.YYYY.
    Display them in the standard date format for Canada.
*/

using System;
using System.Collections.Generic;
using System.Globalization;

class DatesFromTextInCanada
{
    static void ReadDates (List<DateTime> dates, string[] words)
    {
        var culture = new CultureInfo("en-CA");
        var styles = DateTimeStyles.None;
        string dateFormat = "dd.MM.yyyy";
        DateTime temp;
        foreach (string word in words)
        {
            if (!(DateTime.TryParseExact(word, dateFormat, culture, styles, out temp)))
            {
                continue;
            }
            else
            {
                dates.Add(temp);
            }
        }
    }

    static void PrintDatesCanadianFormat(List<DateTime> dates)
    {
        System.Threading.Thread.CurrentThread.CurrentCulture = new CultureInfo("en-Ca");

        foreach (DateTime date in dates)
        {
            Console.WriteLine("{0}", date);
        }
    }

    static string[] input()
    {
        Console.Write("Enter the string: ");
        string[] words = Console.ReadLine().Split(' ');

        return words;
    }

    static void Main()
    {
        string[] words = input();
        List<DateTime> dates = new List<DateTime>();

        ReadDates(dates, words);

        PrintDatesCanadianFormat(dates);
    }
}