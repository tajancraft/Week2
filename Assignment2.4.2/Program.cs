/*
Write a C# Sharp program to find the largest of three numbers.

Test Data :

Input the 1st number :25

Input the 2nd number :63

Input the 3rd number :10

Expected Output :

The 2nd Number is the greatest among three
*/

Console.Write("Input the 1st number: ");
int inputNumber1 = int.Parse(Console.ReadLine());
Console.WriteLine();

Console.Write("Input the 2nd number: ");
int inputNumber2 = int.Parse(Console.ReadLine());
Console.WriteLine();

Console.Write("Input the 3rd number: ");
int inputNumber3 = int.Parse(Console.ReadLine());
Console.WriteLine();

CompareNumberList compareNumberList = new CompareNumberList(inputNumber1, inputNumber2, inputNumber3);
Console.WriteLine("The {0} Number is the greatest among three", compareNumberList.FindLargest());

public class CompareNumberList
{
    public int number1 { get; set; }
    public int number2 { get; set; }
    public int number3 { get; set; }

    public CompareNumberList(int inputNumber1, int inputNumber2, int inputNumber3)
    {
        number1 = inputNumber1;
        number2 = inputNumber2;
        number3 = inputNumber3;
    }
    public string FindLargest()
    {
        if (number1 > number2 && number1 > number3)
            return "1st";
        else if (number2 > number1 && number2 > number3)
            return "2nd";
        else
            return "3rd";
    }
    
}

