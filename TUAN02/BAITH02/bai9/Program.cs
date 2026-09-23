using System;

namespace bai9;

class Program
{
    public static void chuoidoixung(string str)
    {
        string reversed = "";
        for (int i = str.Length - 1; i >= 0; i--)
        {
            reversed += str[i];
        }
        if (str == reversed)
        {
            Console.WriteLine("Chuoi doi xung");
        }
        else
        {
            Console.WriteLine("Chuoi khong doi xung");
        }
    }
    public static void Main(string[] args)
    {
        string str = Console.ReadLine();
        chuoidoixung(str);

    }
}