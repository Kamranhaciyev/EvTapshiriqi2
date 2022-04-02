using System;

namespace Task14
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 123456;
            int b = 234567;
            int c = 345678;
            int d = 456789;
            int e = 134567;
            int f = 245678;
            int result1 = a + b + c + d + e + f;
            string result2 = a.ToString() + c.ToString();
            int numberResult = Convert.ToInt32(result2);
            Console.WriteLine(numberResult);
        }
    }
}
