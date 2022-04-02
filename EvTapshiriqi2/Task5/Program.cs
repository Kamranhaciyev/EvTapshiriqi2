using System;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 4;
            int b = 1234;
            int c = 44;
            string result = a.ToString() + b.ToString() + c.ToString();
            int numberResult = Convert.ToInt32(result);
            int result2 = numberResult * 44 / 100;
            Console.WriteLine(result2);
        }
    }
}
