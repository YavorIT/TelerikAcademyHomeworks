
/*
			Problem 4. Rectangles

	Write an expression that calculates rectangle’s perimeter and area by given width and height.
*/

using System;

class Rectangles
{
	public static void Main ()
	{
		Console.Write ("Enter the width of the rectangle: ");
		double width = double.Parse (Console.ReadLine ());
		Console.Write ("Enter the height of the rectangle: ");
		double height = double.Parse (Console.ReadLine ());

		Console.WriteLine ("The perimeter is P = {0}", 2 * width + 2 * height );
		Console.WriteLine ("The are is S = {0}", width * height);
	}
}