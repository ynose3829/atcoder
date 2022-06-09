using System;
using System.Linq;

namespace a
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine().Trim());
            string s = Console.ReadLine().Trim();

        Console.WriteLine($"{s[n-1]}");
        }
    }
}
