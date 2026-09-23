using System;
namespace bai10
{
    class Program
    {
        public static string reverseString(string str)
        {
            char[] charArray = str.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
        public static void Main(string[] args)
        {
            string reversed = reverseString("Hello, World!");
            Console.WriteLine(reversed);
        }
    }
}