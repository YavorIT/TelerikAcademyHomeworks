
/*
                        Problem 9. Play with Int, Double and String

    Write a program that, depending on the user’s choice, inputs an int, double or string variable.
    If the variable is int or double, the program increases it by one.
    If the variable is a string, the program appends * at the end.
    Print the result at the console. Use switch statement.
*/

using System;

class PlayWithIntDoubleString
{
    static void Main()
    {
        Console.WriteLine("1 ---> Int");
        Console.WriteLine("2 ---> Double");
        Console.WriteLine("3 ---> String");
        Console.Write ("You choose: ");
        int userChoice = int.Parse (Console.ReadLine());

        if (userChoice == 1)
        {
            Console.Write ("Enter the integer: ");
            int integer = int.Parse(Console.ReadLine());
            integer++;
            Console.WriteLine(integer);
        }
        if (userChoice == 2)
        {
            Console.Write("Enter the double: ");
            double floatingPointNumber = Double.Parse(Console.ReadLine());
            floatingPointNumber++;
            Console.WriteLine(floatingPointNumber);
        }
        if (userChoice == 3)
        {
            Console.Write("Write the string:  ");
            string userString = Console.ReadLine();
            userString = userString + "*";
            Console.WriteLine(userString);
        }
    }
}