try
{
    int a = int.Parse(Console.ReadLine());
    int b = int.Parse(Console.ReadLine());
    Console.WriteLine($"ket qua {a} mu {b} la {Math.Pow(a, b)}");
}
catch (FormatException)
{
    Console.WriteLine("Vui long nhap so nguyen");
}