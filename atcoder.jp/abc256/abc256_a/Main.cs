using System;

namespace a
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());

            double ans = Math.Pow(2,n);

            Console.WriteLine(ans);
        }
    }
}
