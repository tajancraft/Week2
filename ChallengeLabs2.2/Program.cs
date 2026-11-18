/*
Write a C# Sharp program that takes userid and password as input (type string). 
After 3 wrong attempts, user will be rejected.
*/

const string userID = "admin";
const string password = "password123"; 

string inputUserID = "";
string inputPassword = "";

int wrongAttempts = 0;

while (wrongAttempts < 3)
{
    Console.Write("Enter User ID: ");
    inputUserID = Console.ReadLine().ToLower();

    Console.Write("Enter Password: ");
    inputPassword = Console.ReadLine().ToLower();

    if (inputUserID == userID && inputPassword == password)
    {
        Console.WriteLine("Login successful!");
        break;
    }
    else
    {
        wrongAttempts++;
        Console.WriteLine($"Incorrect User ID or Password. {3 - wrongAttempts} attempts remaining.");
        if (wrongAttempts == 3)
        {
            Console.WriteLine("Access denied.");
        }
    }
}

