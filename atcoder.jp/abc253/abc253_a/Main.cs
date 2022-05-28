using System;
using System.Linq;

namespace a
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tmp = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToArray();
            int a = tmp[0];
            int b = tmp[1];
            int c = tmp[2];

            Array.Sort(tmp);
            
            if(b == tmp[1])Console.WriteLine("Yes");
            if(b != tmp[1])Console.WriteLine("No");
        }
    }
}
