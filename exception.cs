using System;
public class ExceptionDemo{
    public static void Main(String[] args)
    {
        try{
            Console.Write("Enter a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter b: ");
            int b = int.Parse(Console.ReadLine());
            int r = a/b;
            Console.WriteLine($"Result: {r}");
        }
        
        catch(DivideByZeroException ex)
        {
            Console.WriteLine("Error: Divide by zero not allowed" + ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("An unexpected error occurred: " + ex.Message);
        }
        finally
        {
            Console.WriteLine("Program execution completed.");
        }
    }
}
