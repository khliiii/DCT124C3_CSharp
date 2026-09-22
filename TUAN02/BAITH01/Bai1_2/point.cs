using System;
using System.Collections.Generic;
using System.Text;

namespace Bai1_2
{
    public class point
    {
        public double x { get; set; }
        public double y { get; set; }
        
        public point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        public point()
        {
            this.x = 0;
            this.y = 0;
        }
        public void Input()
        {
            Console.Write("Enter x: ");
            x = double.Parse(Console.ReadLine());
            Console.Write("Enter y: ");
            y = double.Parse(Console.ReadLine());
        }
        
        public double tinhkc(point p)
        {
            return Math.Sqrt(Math.Pow((p.x - this.x), 2) + Math.Pow((p.y - this.y), 2));
        }
        public static double tinhkc(point p1, point p2)
        {
            return Math.Sqrt(Math.Pow((p2.x - p1.x), 2) + Math.Pow((p2.y - p1.y), 2));
        }

        public point trungdiem(point p)
        {
            return new point((this.x + p.x) / 2, (this.y + p.y) / 2);
        }
        public static point trungdiem(point p1, point p2)
        {
            return new point((p1.x + p2.x) / 2, (p1.y + p2.y) / 2);
        }
        public override string ToString()
        {
            return $"({x}, {y})";
        }
    }
}
