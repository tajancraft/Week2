/*
hierachy

Housing
Housing -> Apartment
Housing -> House
Housing -> Condo
*/

public class Housing
{
    public string Address { get; set; } // Property
    public int SquareFeet { get; set; }
    

    public Housing(string address, int squareFeet) // Constructor
    {
        Address = address;
        SquareFeet = squareFeet;
    }
}

public class Apartment : Housing        
{
    public int FloorNumber { get; set; } // Property specific to Apartment

    public Apartment(string address, int squareFeet, int floorNumber)
        : base(address, squareFeet)
    {
        FloorNumber = floorNumber;
    }
}

public class House : Housing
{
    public int NumberOfFloors { get; set; } // Property specific to House

    public House(string address, int squareFeet, int numberOfFloors)
        : base(address, squareFeet)
    {
        NumberOfFloors = numberOfFloors;
    }
}

public class Condo : Housing
{
    public int UnitNumber { get; set; } 

    public Condo(string address, int squareFeet, int unitNumber)
        : base(address, squareFeet)
    {
        UnitNumber = unitNumber;
    }
}