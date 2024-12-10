using System;
public class Circle{
    public double radius;
    
    public Circle(double radius)
    {
        this.radius = radius;
    }
    
    public double Area()
    {
        double area = Math.PI * radius * radius;
        return area;
    }
    
    public double Circum()
    {
        double circum = 2 * Math.PI * radius;
        return circum;
    }
}

public class MainClass{
    public static void Main(String[] args)
    {
        Circle obj = new Circle(5);
        Console.Write("Area of circle: " + obj.Area() + " sqaure units");
    }
}
