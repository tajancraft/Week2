/*
 Write a console application to create a text file and save your basic details 
 like name, age, address ( use dummy data). Read the details from same file and print on console.
 */

using System;
using System.IO;

string filePath = "C:\\Users\\YK\\source\\repos\\MSSA Assignments\\Week2\\Assignment2.3.1\\details.txt";

string name = "Captain Kirk";
// string age = "40";
int age = 40;
string address = "1234 Main St, Evergreen, USA";

using (StreamWriter writer = new(filePath))
{
    writer.WriteLine($"Name: {name}");
    writer.WriteLine($"Age: {age}");
    writer.WriteLine($"Address: {address}");
}

Console.WriteLine($"Details saved to file {filePath} successfully.");
Console.WriteLine();

try
{
    using (StreamReader reader = new(filePath))
    {
        Console.WriteLine("Reading details from file:");
        string line;
        while ((line = reader.ReadLine()) != null)
        {
            Console.WriteLine(line);
        }
    }
}
catch (IOException e)
{
    Console.WriteLine($"An error occurred while reading the file: {e.Message}");
}