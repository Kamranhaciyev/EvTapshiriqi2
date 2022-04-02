using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 123;
            string result = a.ToString() + 7;
            int numberResult = Convert.ToInt32(result);
            int result2 = numberResult * 7 / 100;
            Console.WriteLine(result2);
        }
    }
}
