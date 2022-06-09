using System;
using System.Collections.Generic;
using System.Linq;

namespace b
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] A = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToArray();
            int[] B = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToArray();

            int match = 0;
            int diff = 0;

            for (int i = 0; i < n; i++)
            {
                if (A[i] == B[i]) match++;
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (A[i] == B[j]) diff++;
                }
            }

            diff = diff - match;



            Console.WriteLine($"{match}");
            Console.WriteLine($"{diff}");

        }
    }
}
