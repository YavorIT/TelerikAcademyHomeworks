
/*
				Problem 13.* Comparing Floats

		Write a program that safely compares floating-point 
		numbers (double) with precision eps = 0.000001.
*/

using System;

class ComparingFloats
{
	public static void Main ()
	{
		double firstNumber = 123.0000006;
		double secondNumber = 123.0000004;
		double eps = 0.000001;

		Console.WriteLine ("The numbers are equal with precision of 0,000001 --> " +
		                  								 ((firstNumber - secondNumber) < eps));
	}
}