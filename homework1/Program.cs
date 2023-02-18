using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        double a;
        
        a = inputValue();
        double b;
        
        b = inputValue();
        double max;
        
        max = 0;
        double min;
        
        min = 0;
        if (a > b)
        {
            max = a;
            min = b;
        }
        else
        {
            max = b;
            min = a;
        }
        Console.WriteLine("min = "+ min);
        Console.WriteLine("max = "+ max);
    }
    
    // .NET can only read single characters or entire lines from the
    // console. The following function safely reads a double value.
    private static double inputValue()
    {
        double result;
        while (!double.TryParse(Console.ReadLine(), out result));
        return result;
    }
}
