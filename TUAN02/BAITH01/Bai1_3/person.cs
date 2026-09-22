using System;
using System.Collections.Generic;
using System.Text;

namespace Bai1_3
{
    public class person
    {
        public string name { get; set; }
        public int yob { get; set; }
        public int yod { get; set; }

        public person()
        {
            name = "";
            yob = 0;
            yod = 0;
        }
        public person(string name, int yob, int yod)
        {
            this.name = name;
            this.yob = yob;
            this.yod = yod;
        }
        public void Input()
        {
            Console.Write("nhap ten: ");
            name = Console.ReadLine();
            Console.Write("nhap nam sinh: ");
            yob = int.Parse(Console.ReadLine());
            Console.Write("nhap nam mat(0 neu con song): ");
            yod = int.Parse(Console.ReadLine());
        }
        public bool isAlive()
        {
            return yod==0;
        }
        public void Output()
        {
            Console.WriteLine($"ten: {name}, nam sinh: {yob}, nam mat: {(yod == 0 ? "con song" : yod.ToString())}");
        }

    }
}
