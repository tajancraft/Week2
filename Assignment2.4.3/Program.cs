/*
Write a C# Sharp program to accept a coordinate point in an XY coordinate system and determine
in which quadrant the coordinate point lies.

Test Data :

Input the value for X coordinate :7

Input the value for Y coordinate :9

Expected Output :

The coordinate point (7,9) lies in the First quadrant.
*/

Console.Write("Input the value for X coordinate: ");
int x = int.Parse(Console.ReadLine());
Console.WriteLine();

Console.Write("Input the value for Y coordinate: ");
int y = int.Parse(Console.ReadLine());
Console.WriteLine();

CoordinatePoint point = new CoordinatePoint(x, y);  // instantiate the CoordinatePoint class with the input values
string quadrant = point.DetermineQuadrant();        // returns the quadrant in which the coordinate point lies
Console.WriteLine($"The coordinate point ({x},{y}) lies in the {quadrant}.");
Console.WriteLine();

public class CoordinatePoint
{
    public int X { get; set; }
    public int Y { get; set; }

    public CoordinatePoint(int x, int y)
    {
        X = x;
        Y = y;
    }

    public string DetermineQuadrant()
    {
        if (X > 0 && Y > 0)
            return "First quadrant";
        else if (X < 0 && Y > 0)
            return "Second quadrant";
        else if (X < 0 && Y < 0)
            return "Third quadrant";
        else if (X > 0 && Y < 0)
            return "Fourth quadrant";
        else if (X == 0 && Y != 0)
            return "On the Y-axis";
        else if (Y == 0 && X != 0)
            return "On the X-axis";
        else
            return "At the origin";
    }
}