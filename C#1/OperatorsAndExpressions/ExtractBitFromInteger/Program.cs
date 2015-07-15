
/*
						Problem 12. Extract Bit from Integer

	Write an expression that extracts from given integer n the value of given bit at index p.
*/

using System;

class ExtractBitFromInteger
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

		Console.WriteLine ("The bit on position {0} is: {1}", position, bit);
	}
}