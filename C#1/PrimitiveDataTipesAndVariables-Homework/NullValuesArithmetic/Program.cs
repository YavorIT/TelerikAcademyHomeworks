
/*
						Problem 12. Null Values Arithmetic

		Create a program that assigns null values to an integer and to a double variable.
		Try to print these variables at the console.
		Try to add some number or the null literal to these variables and print the result.
*/

using System;

class NullValuesArithmetic
{
	public static void Main ()
	{
		int? nullIntVariable = null;
		double? nullDoubleVariable = null;

		Console.WriteLine (nullIntVariable);
		Console.WriteLine (nullDoubleVariable);

		int? result = nullIntVariable + 4;
		Console.WriteLine (result);
		Console.WriteLine (nullDoubleVariable + 3.0);
	}
}