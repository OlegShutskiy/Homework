int a, b, c;
a = Convert.ToInt32(Console.ReadLine());
b = Convert.ToInt32(Console.ReadLine());
c = Convert.ToInt32(Console.ReadLine());
int max = 0;
{
    
        if (a >= b && a >= c)
            max = a;
           
        else if (b >= a && b >= c)
            max = b;
        
        else if (c >= a && c >= b)
            max = c;
    
}
        Console.WriteLine("max = "+ max);
