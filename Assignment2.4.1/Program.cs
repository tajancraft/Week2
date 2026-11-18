/*
 Write a program in C# Sharp to find the sum of all array elements.

Test Data :

Input the number of elements to be stored in the array :3

Input 3 elements in the array :

element - 0 : 2

element - 1 : 5

element - 2 : 8

Expected Output :

Sum of all elements stored in the array is : 15
*/

Console.Write("Input the number of elements to be stored in the array: ");
int numberOfElement = int.Parse(Console.ReadLine());

/*
int[] array = new int[numberOfElement];
int sum = 0;

Console.WriteLine($"Input {numberOfElement} elements in the array:");
for (int i = 0; i < numberOfElement; i++)
{
    Console.Write($"element - {i} : ");
    array[i] = int.Parse(Console.ReadLine());
    sum += array[i];
}

Console.WriteLine($"Sum of all elements stored in the array is : {sum}");
*/

// using the ArrayCalculator class
ArrayCalculator calculator = new ArrayCalculator(numberOfElement);
calculator.InputElements();
calculator.DisplaySum();

public class ArrayCalculator
{
    public int[] Array { get; set; }
    public int SumElement { get; set; }

    public ArrayCalculator(int numberOfElement)
    {
        Array = new int[numberOfElement];
        SumElement = 0;
    }

    public void InputElements()
    {
        Console.WriteLine($"Input {Array.Length} elements in the array:");
        Console.WriteLine();
        for (int i = 0; i < Array.Length; i++)
        {
            Console.Write($"element - {i} : ");
            Console.WriteLine();
            Array[i] = int.Parse(Console.ReadLine());
            SumElement += Array[i];
        }
    }

    public void DisplaySum()
    {
        Console.WriteLine($"Sum of all elements stored in the array is : {SumElement}");
    }
}