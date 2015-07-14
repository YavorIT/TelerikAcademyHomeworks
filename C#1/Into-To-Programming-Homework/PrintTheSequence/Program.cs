
/*             Problem 9. Print a Sequence

	Write a program that prints the first 10 members of the sequence: 2, -3, 4, -5, 6, -7, ...
*/

using System;

class PrintTheSequence
{
	public static void Main ()
	{
		int Positive = 2;
		int Negative = -3;

		for (int i = 0; i< 5; i++) {

			Console.Write (" " + Positive + "," + " " + Negative + ",");
			Positive += 2;
			Negative -= 2;
		}
	}
}
