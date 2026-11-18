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

CoordinatePoint point = new(x, y); 
// returns the quadrant in which the coordinate point lies
Console.WriteLine($"The coordinate point ({x},{y}) {point.DetermineQuadrant()}.");
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
            return "lies in the First quadrant";
        else if (X < 0 && Y > 0)
            return "lies in the Second quadrant";
        else if (X < 0 && Y < 0)
            return "lies in the Third quadrant";
        else if (X > 0 && Y < 0)
            return "lies in the Fourth quadrant";
        else if (X == 0 && Y != 0)
            return "lies on the Y-axis";
        else if (Y == 0 && X != 0)
            return "lies on the X-axis";
        else
            return "lies on the origin";
    }
}