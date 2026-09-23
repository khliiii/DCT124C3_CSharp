using System;

namespace bai4
{
    class Program
    {
        public static void Main(string[] args)
        {
            float x = 0, y = 0;
            bool daNhap = false;
            int n;

            do
            {
                Console.WriteLine("\n===== MENU =====");
                Console.WriteLine("1. Nhap 2 so thuc x, y");
                Console.WriteLine("2. Tinh tong x + y");
                Console.WriteLine("3. Tinh can bac 2 cua x va y");
                Console.WriteLine("4. Thoat");
                Console.Write("Nhap lua chon: ");

                n = int.Parse(Console.ReadLine());

                switch (n)
                {
                    case 1:
                        Console.Write("Nhap x: ");
                        x = float.Parse(Console.ReadLine());

                        Console.Write("Nhap y: ");
                        y = float.Parse(Console.ReadLine());

                        daNhap = true;
                        Console.WriteLine("Da nhap x = {0}, y = {1}", x, y);
                        break;

                    case 2:
                        if (!daNhap)
                        {
                            Console.WriteLine("Vui long nhap x, y truoc!");
                        }
                        else
                        {
                            Console.WriteLine("Tong x + y = {0}", x + y);
                        }
                        break;

                    case 3:
                        if (!daNhap)
                        {
                            Console.WriteLine("Vui long nhap x, y truoc!");
                        }
                        else
                        {
                            if (x >= 0)
                                Console.WriteLine("Can bac 2 cua x = {0}", Math.Sqrt(x));
                            else
                                Console.WriteLine("Khong the tinh can bac 2 cua x vi x < 0");

                            if (y >= 0)
                                Console.WriteLine("Can bac 2 cua y = {0}", Math.Sqrt(y));
                            else
                                Console.WriteLine("Khong the tinh can bac 2 cua y vi y < 0");
                        }
                        break;

                    case 4:
                        Console.WriteLine("Da thoat chuong trinh.");
                        break;

                    default:
                        Console.WriteLine("Vui long nhap tu 1 den 4!");
                        break;
                }

            } while (n != 4);
        }
    }
}
