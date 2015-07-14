
/*
			Problem 7. Point in a Circle

	Write an expression that checks if given point (x, y) is inside a circle K({0, 0}, 2).
*/

using System;

class PointInTheCircle
{
	public static void Main ()
	{
		Console.Write ("Enter the x axis: ");
		float x = float.Parse (Console.ReadLine ());
		Console.Write ("Enter the y axis: ");
		float y = float.Parse (Console.ReadLine ());

		bool isInside = x*x + y*y <= 4;

		Console.WriteLine (isInside);
	}
}