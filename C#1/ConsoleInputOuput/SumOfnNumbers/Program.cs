
/*
					Problem 9. Sum of n Numbers

	Write a program that enters a number n and after that enters more n numbers 
	and calculates and prints their sum. 

	Note: You may need to use a for-loop.
*/

using System;

class SumOfnNumbers
{
	public static void Main ()
	{
		Console.Write ("How many numbers will you add: ");
		int n = int.Parse (Console.ReadLine ());
		double sum = 0;

		for (int i = 0; i < n; i++) {
			Console.Write ("Enter the {0} number: ", i + 1);
			sum += double.Parse (Console.ReadLine ());
		}

		Console.WriteLine ("The sum is: {0}", sum);
	}
}