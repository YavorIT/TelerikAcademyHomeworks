
/*	
			Problem 10. Point Inside a Circle & Outside of a Rectangle

	Write an expression that checks for given point (x, y)
	if it is within the circle K({1, 1}, 1.5) and out of the rectangle R(top=1, left=-1, width=6, height=2).
*/
using System;

class InCircleOutRectangle
{
	public static void Main ()
	{	
		Console.Write ("Enter the x axis: ");
		double x = double.Parse (Console.ReadLine ());

		Console.Write ("Enter the y axis: ");
		double y = double.Parse (Console.ReadLine ());

		bool rightPlace = ((y > 1 && y <= 2.5) && (x >= -0.5 && x <= 2.5)) 
									&& ((x - 1)*(x - 1) + (y - 1)*(y - 1) <= 1.5*1.5) ;

		Console.WriteLine ("The point is in the circle and outside the rectangle: {0}", rightPlace);
	}
}