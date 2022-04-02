using System;

namespace EvTapshiriqi2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 7;
            int b = 1234;
            int c = 8;
            string result = a.ToString() + b.ToString() + c.ToString();
            int numberResult = Convert.ToInt32(result);
            Console.WriteLine(result);
        }
    }
}
