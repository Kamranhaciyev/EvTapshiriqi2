using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 333;
            string result = a.ToString() + a.ToString();
            int numberResult = Convert.ToInt32(result);
            Console.WriteLine(result);
        }
    }
}
