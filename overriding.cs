using System;
public class Bike{
    public virtual void throttle()
    {
        Console.WriteLine("Generic Bike Throttles.");
    }
}

public class SuperBike : Bike{
    public override void throttle()
    {
        Console.WriteLine("SuperBike Throttles.");
    }
}

public class MainClass
{
    public static void Main(String[] args)
    {
    Bike discover = new Bike();
    Bike benelli = new SuperBike();
    discover.throttle();
    benelli.throttle();
    }
}
