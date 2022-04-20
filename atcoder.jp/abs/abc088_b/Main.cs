using System;
using System.Linq;
using System.Collections.Generic;

namespace abc088b
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine().Trim());
            List<int> a  = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToList<int>();
            int alice = 0;
            int bob = 0;
            bool flg = true;

            while(flg){
                alice += a.Max();
                a.Remove(a.Max());

                if(a.Count == 0) break;

                bob += a.Max();
                a.Remove(a.Max());

                if(a.Count == 0) break;
            }


            Console.WriteLine(alice-bob);
        }
    }
}
