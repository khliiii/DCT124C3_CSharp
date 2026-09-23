using System;
namespace bai8;

public class Program
{
    public static void Swap(int x, int y, int z, out int a, out int b, out int c)
    {
        a = x;
        b = y;
        c = z;

        int temp;

        if (a > b)
        {
            temp = a;
            a = b;
            b = temp;
        }

        if (a > c)
        {
            temp = a;
            a = c;
            c = temp;
        }

        if (b > c)
        {
            temp = b;
            b = c;
            c = temp;
        }
    }

    public static void Main(string[] args)
    {
        int x = 8;
        int y = 3;
        int z = 5;

        int a, b, c;

        Swap(x, y, z, out a, out b, out c);

        Console.WriteLine("a = " + a);
        Console.WriteLine("b = " + b);
        Console.WriteLine("c = " + c);

    }
}