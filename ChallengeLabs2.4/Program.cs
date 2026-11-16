/*
Write a C# Sharp program to read roll no, name and marks of three subjects and calculate the total, percentage and division. 
(May use a struct / class to represent the student)
Test Data :
Input the Roll Number of the student :784
Input the Name of the Student :James
Input the marks of Physics, Chemistry and Computer Application : 70 80 90
Expected Output :
Roll No : 784
Name of Student : James
Marks in Physics : 70
Marks in Chemistry : 80
Marks in Computer Application : 90
Total Marks = 240
Percentage = 80.00
Division = First
*/

Student student = new Student(0, "", 0, 0, 0);

Console.Write("Input the Roll Number of the student: ");
student.RollNumber = int.Parse(Console.ReadLine());

Console.Write("Input the Name of the Student: ");
student.Name = Console.ReadLine();

Console.Write("Input the marks of Physics, Chemistry and Computer Application : ");
string[] marks = Console.ReadLine().Split(' ');
student.PhysicsMarks = int.Parse(marks[0]);
student.ChemistryMarks = int.Parse(marks[1]);
student.ComputerApplicationMarks = int.Parse(marks[2]);




Console.WriteLine($"\nRoll No : {student.RollNumber}");
Console.WriteLine($"Name of Student : {student.Name}"); 
Console.WriteLine($"Marks in Physics : {student.PhysicsMarks}");
Console.WriteLine($"Marks in Chemistry : {student.ChemistryMarks}");
Console.WriteLine($"Marks in Computer Application : {student.ComputerApplicationMarks}");
Console.WriteLine($"Total Marks = {student.TotalMarks()}");
Console.WriteLine($"Percentage = {student.Percentage():F2}");
Console.WriteLine($"Division = {student.Division()}");

public class Student
{
    public int RollNumber { get; set; }
    public string Name { get; set; }
    public int PhysicsMarks { get; set; }
    public int ChemistryMarks { get; set; }
    public int ComputerApplicationMarks { get; set; }

    public Student(int rollNumber, string name, int physicsMarks, int chemistryMarks, int computerApplicationMarks)
    {
        RollNumber = rollNumber;
        Name = name;
        PhysicsMarks = physicsMarks;
        ChemistryMarks = chemistryMarks;
        ComputerApplicationMarks = computerApplicationMarks;
    }

    public int TotalMarks()
    {
        return PhysicsMarks + ChemistryMarks + ComputerApplicationMarks;
    }

    public double Percentage()
    {
        return (TotalMarks() / 300.0) * 100;
    }

    public string Division()
    {
        double percentage = Percentage();
        if (percentage >= 60)
            return "First";
        else if (percentage >= 50)
            return "Second";
        else if (percentage >= 40)
            return "Third";
        else
            return "Fail";
    }
}

