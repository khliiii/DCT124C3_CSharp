using System;
using System.Collections.Generic;
using System.Text;

namespace bai12
{
    public class nv
    {
        public string ten { get; set; }
        public long mucluong { get; set; }
        public int songayvang { get; set; }

        public void nhap()
        {
            Console.Write("Nhap ten: ");
            ten = Console.ReadLine();
            Console.Write("Nhap muc luong: ");
            mucluong = long.Parse(Console.ReadLine());
            Console.Write("Nhap so ngay vang: ");
            songayvang = int.Parse(Console.ReadLine());
        }
        public long tinhluong()
        {
            return mucluong - (songayvang * 100000);
        }
        public void xuat()
        {
            Console.WriteLine("Ten: {0}", ten);
            Console.WriteLine("Muc luong: {0}", mucluong);
            Console.WriteLine("So ngay vang: {0}", songayvang);
            Console.WriteLine("Luong thuc te: {0}", tinhluong());
        }
    }
}
