/*
Write a C# Sharp program to find the largest of three numbers.

Test Data :

Input the 1st number :25

Input the 2nd number :63

Input the 3rd number :10

Expected Output :

The 2nd Number is the greatest among three
*/


int[] myArray = new int[3];
string [] rankingPlace = {"1st", "2nd", "3rd"};

for (int i = 0; i < 3; i++)
{
    Console.Write($"input the {rankingPlace[i]} number: ");
    myArray[i] = int.Parse(Console.ReadLine());
    Console.WriteLine();
}

int maxIndex = 0;
for (int i = 0; i < 3; i++)
{
    if (myArray[i] > myArray[maxIndex])
    {
        maxIndex = i;
    }
}
Console.WriteLine($"The {rankingPlace[maxIndex]} Number is the greatest among three");