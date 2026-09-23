using System;
namespace bai5;

class program
{
    public static void Main(string[] args)
    {
        int a, b, c;
        Console.Write("Nhap so nguyen a: ");
        a = int.Parse(Console.ReadLine());
        Console.Write("Nhap so nguyen b: ");
        b = int.Parse(Console.ReadLine());
        Console.Write("Nhap so nguyen c: ");
        c = int.Parse(Console.ReadLine());
        int max = sort.giatrilonnhat(a, b, c);
        Console.WriteLine("Gia tri lon nhat trong 3 so {0}, {1}, {2} la: {3}", a, b, c, max);
    }
}