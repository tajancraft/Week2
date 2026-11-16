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
    Console.WriteLine();
    menuChoice = int.Parse(Console.ReadLine());

    switch (menuChoice)
    {
        case 1:
            Console.WriteLine("Enter Bill Total:");
            double billTotal = double.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Enter Tip Percentage (e.g., 15 for 15%):");
            double tipPercentage = double.Parse(Console.ReadLine());
            Console.WriteLine();

            TipCalculator calculator = new TipCalculator(billTotal, tipPercentage);
            
            Console.WriteLine($"Tip Amount: {calculator.CalculateTip():C}");
            Console.WriteLine($"Grand Total: {calculator.CalculateGrandTotal():C}");
            Console.WriteLine();
            break;

        case 2:
            Console.WriteLine("Exiting...");
            Console.WriteLine();
            break;

        default:
            Console.WriteLine("Invalid choice. Please try again.");
            Console.WriteLine();
            break;
    }
} while (menuChoice != 2);

public class TipCalculator
{
    public double BillTotal { get; set; }
    public double TipPercentage { get; set; }

    public TipCalculator(double billTotal, double tipPercentage)
    {
        BillTotal = billTotal;
        TipPercentage = tipPercentage;
    }

    public double CalculateTip()
    {
        return BillTotal * (TipPercentage / 100);
    }

    public double CalculateGrandTotal()
    {
        return BillTotal + CalculateTip();
    }
}