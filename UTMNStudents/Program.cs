using System;
public class Program
{

    static int rec(int x)
    {
        if (x == 0)
            return 0;
        return rec(x - 1) + x;
    }
    static int mult(int a, int b, int c) 
    {
        return a * b * c;
    }

    static int sum(int a, int b, int c)
    {
        return a + b + c;
    }

    static void Main(string[] args)
    {
        Console.WriteLine("INFO: Program started");
        Console.WriteLine("HelloWorld");
        Console.WriteLine("x = " + rec(5));
        Console.WriteLine("rec(2) + rec(3) = " + newFeature(rec(2), rec(3)));
        Console.WriteLine("mult(rec(2), rec(3), rec(4)) = " + mult(rec(2), rec(3), rec(4)));
        Console.WriteLine("sum(rec(2), rec(3), rec(4)) = " + sum(rec(2), rec(3), rec(4)));
        Console.WriteLine("INFO: Program finish");
    }

    public static int newFeature(int a, int b)
    {
        return a + b;
    }
    public static void Test()
    {
        return;
    }
}