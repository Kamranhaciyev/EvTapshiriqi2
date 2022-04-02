using System;

namespace Task9
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 123;
            int b = 234;
            int c = 456;
            int d = 235;
            int e = 678;
            int f = 789;
            int result1 = a * 10 / 100;
            int result2 = b * 10 / 100;
            int result3 = c * 10 / 100;
            int result4 = d * 10 / 100;
            int result5 = e * 10 / 100;
            int result6 = f * 10 / 100;
            int result7 = result1 + result2 + result3 + result4 + result5 + result6;
            int result8 = result7 * 10 / 100;
            Console.WriteLine(result8);

        }
    }
}
