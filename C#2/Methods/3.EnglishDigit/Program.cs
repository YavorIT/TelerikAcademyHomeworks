
/*      
                     Problem 3. English digit

    Write a method that returns the last digit of given integer as an English word.
*/

using System;

class EnglishDigit
{
    static string LastDigitAsWord(int number)
    {
        string lastDigit;

        switch(number % 10)
        {
            case 1:
                lastDigit = "One";
                break;
            case 2:
                lastDigit = "Two";
                break;
            case 3:
                lastDigit = "Three";
                break;
            case 4:
                lastDigit = "Four";
                break;
            case 5:
                lastDigit = "Five";
                break;
            case 6:
                lastDigit = "Six";
                break;
            case 7:
                lastDigit = "Seven";
                break;
            case 8:
                lastDigit = "Eight";
                break;
            case 9:
                lastDigit = "Nine";
                break;
            default:
                lastDigit = "Zero";
                break;
        }

        return lastDigit;
    }

    static void Main()
    {
        Console.Write("Enter the integer: ");
        int userNumber = int.Parse(Console.ReadLine());

        Console.WriteLine(LastDigitAsWord(userNumber));
    }
}