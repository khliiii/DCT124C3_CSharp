using System;
using System.Collections.Generic;
using System.Text;

namespace Bai1_1
{
    public class sv
    {
        public string name { get; set; }
        public int age { get; set; }

        public void Input()
        {
            Console.Write("Enter name: ");
            name = Console.ReadLine();
            Console.Write("Enter age: ");
            age = int.Parse(Console.ReadLine());
        }
        public void Output()
        {
            Console.WriteLine($"Name: {name}, Age: {age}");
        }
    }
}
