
/*
                         Problem 4. Triangle surface

    Write methods that calculate the surface of a triangle by given:

    1. Side and an altitude to it;
    2. Three sides;
    3. Two sides and an angle between them;

    Use System.Math.
*/

using System;

class TriangleSurface
{
    static void SurfaceBySideAndAltitude(double side, double altitude)
    {
        Console.WriteLine("The surface of the triangle is: {0}", (side * altitude) / 2);
    }

    static void SurfaceByThreeSides(double aSide, double bSide, double cSide)
    {
        double halfPerimeter = (aSide + bSide + cSide) / 2;
        double forSqrt = halfPerimeter * (halfPerimeter - aSide) * (halfPerimeter - bSide) * (halfPerimeter - cSide);
        double surface = Math.Sqrt(forSqrt);

        Console.WriteLine("The surface of the triangle is: {0}", surface);
    }

    static void SurfaceByTwoSidesAndAnAngle(double aSide, double bSide, double angle)
    {
        double surface = (aSide * bSide * (Math.Sin(angle))) / 2;

        Console.WriteLine("The surface of the triangle is: {0}", surface);
    }

    static void Main()
    {
        Console.WriteLine("1. Surface by side and an altitude");
        Console.WriteLine("2. Surface by three sides");
        Console.WriteLine("3. Surface by two sides and an angle between them");

        Console.Write("You choose: ");
        int userChoice;
        if (!(int.TryParse(Console.ReadLine(), out userChoice)))
        {
            Console.WriteLine("Invalid option!!!");
            return;
        }

        Console.WriteLine("Input the data: ");
        string input = Console.ReadLine();
        input += " ";                                // add a space to the end because the for cycle will mis the last number
        string number = string.Empty;
        int flag = 0;
        double[] sideOrAngle = new double[3];

        for (int i = 0, j = 0; i < input.Length; i++)
        {
            if ((int)input[i] >= 48 && (int)input[i] <= 57 || (flag == 1 && input[i] == '.'))
            {
                number += input[i];
                flag = 1;
            }
            else if (flag == 1 && input[i] != '.')
            {
                flag = 0;
                sideOrAngle[j] = double.Parse(number);
                j++;
                number = string.Empty;
            }
        }

        switch (userChoice)
        {
            case 1:
                SurfaceBySideAndAltitude(sideOrAngle[0], sideOrAngle[1]);
                break;
            case 2:
                SurfaceByThreeSides(sideOrAngle[0], sideOrAngle[1], sideOrAngle[2]);
                break;
            case 3:
                SurfaceByTwoSidesAndAnAngle(sideOrAngle[0], sideOrAngle[1], sideOrAngle[2] * (Math.PI / 180));  // the multyplying is to give the angle in radians
                break;
        }
    }

}