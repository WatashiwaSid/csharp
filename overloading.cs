using System;
public class Overloading{
    public void instance(int a)
    {
        Console.WriteLine("Method instance with 1 argument");
    }
    public void instance(int a, int b)
    {
        Console.WriteLine("Method instance with 2 arguments");
    }
}
public class MainClass{
    public static void Main(String[] __)
    {
        Overloading obj = new Overloading();
        obj.instance(2);
        obj.instance(2,2);
    }
}
