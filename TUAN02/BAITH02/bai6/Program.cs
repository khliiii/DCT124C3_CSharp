using System;
using System.Numerics;
namespace bai6;
class program
{
    public static bool isPrime(int n)
    {
        if (n < 2)
            return false;
        for (int i = 2; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0)
                return false;
        }
        return true;
    }
    public static void Main(string[] args)
    {
        int n=int.Parse(Console.ReadLine());
        if (isPrime(n))
            Console.WriteLine("{0} la so nguyen to", n);
        else
            Console.WriteLine("{0} khong phai la so nguyen to", n);
    }
}