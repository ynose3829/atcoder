using System;

namespace abc086a
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int a = Int32.Parse(input[0]);
            int b = Int32.Parse(input[1]);

            if((a*b) % 2 == 0) Console.WriteLine("Even");
            if((a*b) % 2 == 1) Console.WriteLine("Odd");
        }
    }
}
