/*
hierachy

MyHousing
MyHousing -> MyApartment
MyHousing -> MyHouse
MyHousing -> MyCondo
*/

public class MyHousing
{
    public string Address { get; set; } // Property
    public int SquareFeet { get; set; }
    

    public MyHousing(string address, int squareFeet) // Constructor
    {
        Address = address;
        SquareFeet = squareFeet;
    }
}

public class MyApartment : MyHousing        
{
    public int FloorNumber { get; set; } // Property specific to Apartment

    public MyApartment(string address, int squareFeet, int floorNumber)
        : base(address, squareFeet)
    {
        FloorNumber = floorNumber;
    }
}

public class MyHouse : MyHousing
{
    public int NumberOfFloors { get; set; } // Property specific to House

    public MyHouse(string address, int squareFeet, int numberOfFloors)
        : base(address, squareFeet)
    {
        NumberOfFloors = numberOfFloors;
    }
}

public class MyCondo : MyHousing
{
    public int UnitNumber { get; set; } 

    public MyCondo(string address, int squareFeet, int unitNumber)
        : base(address, squareFeet)
    {
        UnitNumber = unitNumber;
    }
}