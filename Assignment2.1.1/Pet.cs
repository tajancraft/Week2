public class Pet
{
    public string Name { get; set; } 
    public int Age { get; set; }

    public Pet(string name, int age) 
    {
        Name = name;
        Age = age;
    }
}

public class MyDog : Pet
{
    public string Breed { get; set; }
    public MyDog(string name, int age, string breed) : base(name, age)
    {
        Breed = breed; 
    }
    public void Bark()
    {
        Console.WriteLine("Woof!");
    }
}

public class Hound : MyDog
{
    public Hound(string name, int age, string breed) : base(name, age, breed)
    {
    }

    public void Bark()
    {
        Console.WriteLine("Woof! Woof!");
    }
}

public class Terrier : MyDog
{
    public Terrier(string name, int age, string breed) : base(name, age, breed)
    {
    }

    public void Bark()
    {
        Console.WriteLine("Woof! Woof! Woof!");
    }
}

public class GermanShepherd : Hound
{
    public GermanShepherd(string name, int age) : base(name, age, "German Shepherd")
    {
    }

    public void Bark()
    {
        Console.WriteLine("German Shepherd Bark!");
    }
}

public class Beagle : Hound
{
    public Beagle(string name, int age) : base(name, age, "Beagle")
    {
    }

    public void Bark()
    {
        Console.WriteLine("Beagle Bark!");
    }
}

public class WelshTerrier : Terrier
{
    public WelshTerrier(string name, int age) : base(name, age, "Welsh Terrier")
    {
    }

    public void Bark()
    {
        Console.WriteLine("Welsh Terrier Bark!");
    }
}
