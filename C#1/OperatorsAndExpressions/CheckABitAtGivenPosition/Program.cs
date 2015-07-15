
/*
			Problem 13. Check a Bit at Given Position

	Write a Boolean expression that returns if the bit at position p
	(counting from 0, starting from the right) in given integer number n, has value of 1.
*/

using System;

class CheckABitAtGivenPosition
{
	public static void Main ()
	{
		Console.Write ("Enter a positive integer: ");
		int number = int.Parse (Console.ReadLine ());

		Console.Write ("Enter the index of the bit: ");
		int position = int.Parse (Console.ReadLine ());

		int mask = 1;
		mask <<= position;

		int bit = (mask & number) >> position;

		bool isTrue = bit == 1 ? true : false;

		Console.WriteLine ("The bit at position {0} is 1: {1}", position, isTrue);
	}
}