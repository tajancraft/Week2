/*
Design a tip calculator : enter the bill total, tip % and display grand total after adding tip.

Use the format specifiers to display currency, % symbol.
*/

int menuChoice;

do
{
    Console.WriteLine("Tip Calculator Menu:");
    Console.WriteLine();
    Console.WriteLine("1. Calculate Tip");
    Console.WriteLine("2. Exit");
    menuChoice = int.Parse(Console.ReadLine());

    switch (menuChoice)
    {
        case 1:
            Console.WriteLine("Enter Bill Total:");
            double billTotal = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter Tip Percentage (e.g., 15 for 15%):");
            double tipPercentage = double.Parse(Console.ReadLine());

            double tipAmount = billTotal * (tipPercentage / 100);
            double grandTotal = billTotal + tipAmount;

            Console.WriteLine($"Tip Amount: {tipAmount:C}");
            Console.WriteLine($"Grand Total: {grandTotal:C}");
            break;

        case 2:
            Console.WriteLine("Exiting...");
            break;

        default:
            Console.WriteLine("Invalid choice. Please try again.");
            break;
    }
}