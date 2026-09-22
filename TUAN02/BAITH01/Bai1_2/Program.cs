using System;
namespace Bai1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            point p1 = new point();
            point p2 = new point();
            Console.WriteLine("nhap diem 1:");
            p1.Input();
            Console.WriteLine("nhap diem 2:");
            p2.Input();
            Console.WriteLine($"khoang cach: {point.tinhkc(p1, p2)}");
            Console.WriteLine($"khoang cach tu p1 den p2: {p1.tinhkc(p2)}");
            Console.WriteLine($"trung diem: {point.trungdiem(p1, p2)}");
            Console.WriteLine($"trung diem tu p1 den p2: {p1.trungdiem(p2)}");
        }
    }
}