
/*
					Problem 11.* Numbers in Interval Dividable by Given Number

	Write a program that reads two positive integer numbers and prints how many numbers p exist
	between them such that the reminder of the division by 5 is 0.
*/

using System;

class NumbersInIntervalDividableByGivenNumber
{
	public static void Main ()
	{
		Console.Write ("Enter the first positive integer: ");
		int above = int.Parse (Console.ReadLine ());

		Console.Write ("Enter the second positive integer: ");
		int below = int.Parse (Console.ReadLine ());

		int sum = 0;
		for (int i = above; i <= below; i++) {
			if ((i % 5) == 0) {
				Console.Write ("{0}, ", i);
				sum += 1;
			}
		}
		Console.WriteLine ();
		Console.WriteLine ("{0} numbers dividable by 5 in the interval - [{1};{2}]", sum, above, below);
	}
}