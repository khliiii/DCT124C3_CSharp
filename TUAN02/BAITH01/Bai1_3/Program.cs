using System;
namespace Bai1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            person p = new person();
            p.Input();
            p.Output();
            Console.WriteLine($"is alive: {p.isAlive()}");
        }
    }
}