
/*
					Problem 16.** Bit Exchange (Advanced)

	Write a program that exchanges bits {p, p+1, …, p+k-1} with bits {q, q+1, …, q+k-1}
	of a given 32-bit unsigned integer.
	The first and the second sequence of bits may not overlap.
*/

using System;

class BitsExchangeAdvanced
{
	public static void Main ()
	{
		Console.Write ("Enter the number: ");
		uint number = uint.Parse (Console.ReadLine ());

		Console.Write ("Enter the position of the bit for exchanging (p): ");
		int p = int.Parse (Console.ReadLine ());

		Console.Write ("Enter the position of the first exchanging bit (q): ");
		int q = int.Parse (Console.ReadLine ());

		Console.Write ("Enter the bit to stop (k): ");
		int k = int.Parse (Console.ReadLine ());

		string numberBits = Convert.ToString (number, 2).PadLeft (32, '0');
		char[] resultBits = new char [32];

		Console.WriteLine ("Your number: ");
		Console.WriteLine (numberBits);

		for (int i = 0; i < 32; i++) {
			resultBits [i] = numberBits [i];
		}

		if (p < q) {
			if ((k + q) > 32) {
				Console.WriteLine ("Out of range!");
			} else if ((p + k - 1) >= q) {
				Console.WriteLine ("Overlapping!");
			} else {
				for (int i = 0; i < k; i++) {
					resultBits [31 - (p + i)] = numberBits [31 - (q + i)];
					resultBits [31 - (q + i)] = numberBits [31 - (p + i)];
				}
				Array.Reverse (resultBits);
				uint result = 0;
				for (int i = 31; i >= 0; i--) {
					if (resultBits [i] == '1') {
						result += (uint)Math.Pow (2, i);
					}
				}
				Console.WriteLine ("Result: ");
				Console.Write ("{0} --> {1}",
				               Convert.ToString(result, 2).PadLeft(32, '0'), result);
			}
		} else {
			if ((k + p) > 32) {
				Console.WriteLine ("Out of range!");
			} else if ((q + k - 1) >= p) {
				Console.WriteLine ("Overlapping!");
			} else {
				for (int i = 0; i < k; i++) {
					resultBits [31 - (p + i)] = numberBits [31 - (q + i)];
					resultBits [31 - (q + i)] = numberBits [31 - (p + i)];
				}
				Array.Reverse (resultBits);
				uint result = 0;
				for (int i = 31; i >= 0; i--) {
					if (resultBits [i] == '1') {
						result += (uint)Math.Pow (2, i);
					}
				}
				Console.WriteLine ("Result: ");
				Console.Write ("{0} --> {1}",
				               Convert.ToString(result, 2).PadLeft(32, '0'), result);
			}
		}

	}
}