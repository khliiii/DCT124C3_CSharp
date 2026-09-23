using System;
namespace bai7;
class program
{
    public static void changeplace(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }   
    public static void Main(string[] args)
    {
        int a,b;
        Console.Write("Nhap so nguyen a: ");
        a=int.Parse(Console.ReadLine());
        Console.Write("Nhap so nguyen b: ");
        b= int.Parse(Console.ReadLine());

        changeplace(ref a, ref b);

        Console.WriteLine("Sau khi doi cho, gia tri cua a la: {0}, gia tri cua b la: {1}", a, b);


    }
}