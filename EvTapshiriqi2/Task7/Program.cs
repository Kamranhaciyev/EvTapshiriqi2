using System;

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 12345;
            int b = 23456;
            int result = a + b;
            string result2 = 5.ToString() + result + 5.ToString();
            int numberResult = Convert.ToInt32(result2);
            int result3 = numberResult * 5 / 100;
            Console.WriteLine(result3);
        }
    }
}
