/*
Write a C# Sharp program that takes a number and a width also a number, as input and then displays a triangle of that width, using that number.
Test Data
Enter a number: 6
Enter the desired width: 6
Expected Output:

666666

66666

6666

666

66

6
*/

int inputNumber = 0; 
int inputDesiredWidth = 0;

Console.Write("Enter a number: ");
inputNumber = int.Parse(Console.ReadLine());

Console.Write("Enter the desired width: ");
inputDesiredWidth = int.Parse(Console.ReadLine());

for (int i = inputDesiredWidth; i >= 1; i--)
{
    Console.WriteLine();
    for (int j = 1; j <= i; j++)
    {
        Console.Write(inputNumber);
    }
    Console.WriteLine();
}