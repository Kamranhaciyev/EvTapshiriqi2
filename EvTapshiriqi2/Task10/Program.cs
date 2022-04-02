using System;

namespace Task10
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 9234;
            int b = 3345;
            int c = 1789;
            int result1 = a * 1 / 100;
            int result2 = b * 2 / 100;
            int result3 = c * 3 / 100;
            int result4 = result1 - result2 - result3;
            int result5 = c * 7 / 100;
            int result6 = result4 + result5;
            Console.WriteLine(result6);
        }
    }
}
