
/*
				Problem 7. Sum of 5 Numbers

	Write a program that enters 5 numbers (given in a single line, separated by a space), 
	calculates and prints their sum.
*/

using System;

class SumOfFiveNumbers
{
	public static void Main ()
	{
		Console.Write ("Please enter the number to add and always end with a spacebar: ");
		string input = Console.ReadLine ();
		string temp = "";
		double sum = 0;

		for (int i = 0; i < input.Length; i++) {
			if (input [i] != ' ') {
				temp = temp + input [i];
				continue;
			} else {
				sum += double.Parse (temp);
				temp = "";
				continue;
			}
		}

		Console.WriteLine ("The sum is: {0}", sum);
	}
}