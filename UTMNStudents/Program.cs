using System;
public class Program
{

    static int rec(int x, int i)
    {
        Console.WriteLine("Recursion step # " +i);
        if (x == 0)
            return 0;
        return rec(x - 1, i + 1) + x;
    }
    static void Main(string[] args)
    {
        Console.WriteLine("INFO: Program started");
        Console.WriteLine("123");
        Console.WriteLine("HelloWorld");
        int a = rec(5, 1);
        Console.WriteLine("x = " + a);
        Console.WriteLine("INFO: Program finish");
    }

    public static void Test()
    {
        return;
    }
}