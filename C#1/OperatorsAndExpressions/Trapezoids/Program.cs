
/*
					Problem 9. Trapezoids

	Write an expression that calculates trapezoid's area by given sides a and b and height h.
*/

using System;

class Trapezoids
{
	public static void Main ()
	{
		Console.Write ("Enter the first side: ");
		double a = double.Parse (Console.ReadLine ());
		Console.Write ("Enter the second side: ");
		double b = double.Parse (Console.ReadLine ());
		Console.Write ("Enter the height: ");
		double height = double.Parse (Console.ReadLine ());

		Console.WriteLine ("The area of the trapezoid is S = {0}", ( (a + b) / 2 ) * height);
	}
}