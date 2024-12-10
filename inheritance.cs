using System;
public class Bike{
    
    public string brand;
    public Bike(string brand)
    {
        this.brand = brand;
    }
}

public class Superbike : Bike{
    public int topspeed;
    public Superbike(string brand, int topspeed) : base(brand)
    {
        this.topspeed = topspeed;
    }
    
    public void BikeInfo()
    {
        Console.WriteLine("Model: " + brand);
        Console.WriteLine("Topspeed in Kms: " + topspeed);
    }
}

public class MainClass
{
    public static void Main(String[] args)
    {
        Superbike benneli = new Superbike("Benelli 600", 320);
        benneli.BikeInfo();
    }
}
