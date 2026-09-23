using System;
using System.Collections.Generic;
using System.Text;

namespace bai11
{
    public class sv
    {
        public string MSSV { get; set; }
        public string HoTen { get; set; }
        public string diaChi { get; set; }
        public string sinhviennam { get; set; }
        
        public void nhap()
        {
            Console.Write("Nhap MSSV: ");
            MSSV = Console.ReadLine();
            Console.Write("Nhap Ho Ten: ");
            HoTen = Console.ReadLine();
            Console.Write("Nhap dia chi: ");
            diaChi = Console.ReadLine();
            Console.Write("Nhap sinh vien nam: ");
            sinhviennam = Console.ReadLine();
        }
        public void xuat()
        {
            Console.WriteLine("MSSV: {0}", MSSV);
            Console.WriteLine("Ho Ten: {0}", HoTen);
            Console.WriteLine("Dia chi: {0}", diaChi);
            Console.WriteLine("Sinh vien nam: {0}", sinhviennam);
        }
    }
    
}
