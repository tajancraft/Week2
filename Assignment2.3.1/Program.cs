/*
 Write a console application to create a text file and save your basic details 
 like name, age, address ( use dummy data). Read the details from same file and print on console.
 */

using System;
using System.IO;

string filePath = "C:\\Users\\YK\\source\\repos\\MSSA Assignments\\Week2\\Assignment2.3.1\\details.txt";

string name = "Yebin Kim";
int age = 40;
string address = "1234 Main St, Evergreen, USA";

try
{
    using (StreamWriter writer = new StreamWriter(filePath))
    {
        writer.WriteLine($"Name: {name}");
        writer.WriteLine($"Age: {age}");
        writer.WriteLine($"Address: {address}");
    }

    Console.WriteLine($"Details saved to file {filePath} successfully.");
    Console.WriteLine();

    using (StreamReader reader = new StreamReader(filePath))
    {
        Console.WriteLine("Reading details from file:");
        string line;
        while ((line = reader.ReadLine()) != null)
        {
            Console.WriteLine(line);
        }
    }
}
catch (Exception ex)
{
    Console.WriteLine($"An error occurred while writing to the file: {ex.Message}");
}