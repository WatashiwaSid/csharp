using System;
public class Encaps{
    private int value;
    
    public Encaps(int value)
    {
        this.value = value;
    }
    public int GetValue(){
        return value;
    }
    public void SetValue(int value){
        this.value = value;
    }
}

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Encaps oo = new Encaps(10);
        Console.WriteLine("Init Value: " + oo.GetValue());
        oo.SetValue(20);
        Console.WriteLine("Updt Value: " + oo.GetValue());
    }
}
