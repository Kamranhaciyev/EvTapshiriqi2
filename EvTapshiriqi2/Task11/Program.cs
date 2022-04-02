using System;

namespace Task11
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1234;
            int b = 2345;
            int c = 3456;
            int d = 4567;
            int result1 = a + c;
            int result2 = b + d;
            int result3 = c * 3 / 100;
            int result4 = result1 * result2 - result3;
            Console.WriteLine(result4);
        }
    }
}
