/*
Write a abstract base class: ‘Shape’ and add properties like id, name and color and method ‘calculate area’ .

Inherit circle shape from base class and add properties like radius. override calculate area logic for circle.

Inherit square class from shape and change the calculate area logic. Add property like side of square.

Take the input from user to select circle or square and display the calculated area . no hard coded values!


*/

int menuChoice;

do
{
    Console.WriteLine("Select a shape to calculate area:");
    Console.WriteLine();
    Console.WriteLine("1. Circle");
    Console.WriteLine("2. Square");
    Console.WriteLine("3. Exit");
    menuChoice = int.Parse(Console.ReadLine());

    switch (menuChoice)
    {
        case 1:
           
            Console.WriteLine("Enter Circle Radius:");
            double radius = double.Parse(Console.ReadLine());

            Circle myCircle = new();
            myCircle.Radius = radius;
            double circleArea = myCircle.CalculateArea();
            Console.WriteLine($"Circle Area: {circleArea}");
            break;

        case 2:
           
            Console.WriteLine("Enter Square Side Length:");
            double sideLength = double.Parse(Console.ReadLine());

            Square mySquare = new();
            mySquare.Side = sideLength;
            double squareArea = mySquare.CalculateArea();
            Console.WriteLine($"Square Area: {squareArea}");
            break;

        case 3:
            Console.WriteLine("Exiting...");
            break;

        default:
            Console.WriteLine("Invalid choice. Please try again.");
            break;
    }
} while (menuChoice != 3);

public abstract class Shape
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Color { get; set; }

    public virtual double CalculateArea()
    {
        return 0;
    }
}

public class Circle : Shape
{
    public double Radius { get; set; }

    public override double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }
}

public class Square : Shape
{
    public double Side { get; set; }

    public override double CalculateArea()
    {
        return Side * Side;
    }
}