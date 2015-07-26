
/*
					Problem 1. Sum of 3 Numbers

	Write a program that reads 3 real numbers from the console and prints their sum.
*/

using System;

class SumOfNumbers
{
	public static void Main ()
	{
		Console.Write ("Enter the first number: ");
		double firstNumber = double.Parse (Console.ReadLine ());

		Console.Write ("Enter the second number: ");
		double secondNumber = double.Parse (Console.ReadLine ());

		Console.Write ("Enter the third number: ");
		double thirdNumber = double.Parse (Console.ReadLine ());

		Console.WriteLine ("The sum of the three numbers you entered is: {0}",
		                   			firstNumber + secondNumber+ + thirdNumber);
	}
}