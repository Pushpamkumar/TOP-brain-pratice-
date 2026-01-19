using System;

class Program
{
    static void Main()
    {
        int a = 5, b = 10;

        Console.WriteLine($"Before Swap: a = {a}, b = {b}");
        SwapRef(ref a, ref b);
        Console.WriteLine($"After Swap (ref): a = {a}, b = {b}");
    }

    static void SwapRef(ref int x, ref int y)
    {
        x = x + y;
        y = x - y;
        x = x - y;
    }
}
