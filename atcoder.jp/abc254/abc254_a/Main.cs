using System;
using System.Linq;

namespace a
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine().Trim());
            string a = (n % 10).ToString();
            string b = (n / 10 % 10).ToString();

            Console.WriteLine($"{b}{a}");
        }
    }
}
