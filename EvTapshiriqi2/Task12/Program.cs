using System;

namespace Task12
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 123456;
            int b = 234567;
            int c = 345678;
            int d = 456789;
            int result1 = a * 10 / 100;
            int result2 = b * 10 / 100;
            int result3 = c * 10 / 100;
            int result4 = d * 10 / 100;
            int result5 = result1 + result2 + result3 + result4;
            int result6 = a * 15 / 100;
            int result7 = b * 15 / 100;
            int result8 = c * 15 / 100;
            int result9 = d * 15 / 100;
            int result10 = result6 + result7 + result8 + result9;
            int result11 = result5 + result10 * 10 / 100;
            int result12 = result11 * 11 / 100;
            Console.WriteLine(result12);
        }
    }
}
