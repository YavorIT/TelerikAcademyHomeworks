
/*
 							Problem 3. Circle Perimeter and Area

	Write a program that reads the radius r of a circle 
	and prints its perimeter and area formatted with 2 digits after the decimal point.
*/

using System;

class CirclePerimeterArea
	{
		public static void Main ()
		{
			Console.Write ("Enter the radius of the circle: ");
			double radius = double.Parse (Console.ReadLine ());

			Console.WriteLine ("Area of the circle is S = {0:0.00}", Math.PI*radius*radius);
			Console.WriteLine ("Perimeter of the circel is P = {0:F2}", 2*Math.PI*radius);
		}
}