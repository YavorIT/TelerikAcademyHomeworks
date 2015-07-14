
/*
				Problem 1. Odd or Even Integers

	Write an expression that checks if given integer is odd or even.
*/

using System;

class OddOrEven
{
	public static void Main ()
	{
		int number = 4;
		bool isEven = number % 2 == 0;
		Console.WriteLine (isEven);
	}
}