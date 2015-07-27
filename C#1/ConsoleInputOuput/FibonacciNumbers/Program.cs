
/*
						Problem 10. Fibonacci Numbers

	Write a program that reads a number n and prints on the 
	console the first n members of the Fibonacci sequence 
	(at a single line, separated by comma and space -,): 
	0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, ….

	Note: You may need to learn how to use loops.
*/

using System;

class FibonacciNumbers
{
	public static void Main ()
	{
		int twoNumbersBefore = 0;
		int lastNumber = 1;

		Console.Write ("Enter the member's number to stop: ");
		int stop = int.Parse (Console.ReadLine ());

		Console.Write ("{0}, {1}, ", twoNumbersBefore, lastNumber);

		int temp;
		for (int i = 2; i < stop; i++) {
			Console.Write ("{0}, ", twoNumbersBefore + lastNumber);
			temp = twoNumbersBefore;
			twoNumbersBefore = lastNumber;
			lastNumber = temp + twoNumbersBefore;
		}
        Console.WriteLine();
	}
}