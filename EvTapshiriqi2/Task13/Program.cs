using System;

namespace Task13
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 12345;
            int b = 23456;
            int c = 34567;
            int d = 123;
            int e = 345;
            int result1 = a * 5 / 100;
            int result2 = b * 5 / 100;
            int result3 = c * 5 / 100;
            int result4 = result1 * result2 * result3;
            int result5 = d * 3 / 100;
            int result6 = e * 3 / 100;
            int result7 = result5 + result6;
            int result8 = result4 * 10 / 100;
            int result9 = result7 * 10 / 100;
            int result10 = result8 + result9;
            Console.WriteLine(result10);
        }
    }
}
