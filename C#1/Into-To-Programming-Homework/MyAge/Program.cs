
/*         Problem 15.* Age after 10 Years

	Write a program to read your birthday from the console 
	and print how old you are now and how old you will be after 10 years.
*/

using System;

class MyAge
{
	public static void Main ()
	{
		Console.Write ("Please enter the current year: ");
		int currentYear = int.Parse (Console.ReadLine ());
		Console.Write ("Please enter the year when you were born: ");
		int YearBorn = int.Parse(Console.ReadLine());

		int Age = currentYear - YearBorn;
		Console.WriteLine ("\nYou are " + Age + " years old and after 10 years you will be " + (Age + 10) + " years old!");
	}
}