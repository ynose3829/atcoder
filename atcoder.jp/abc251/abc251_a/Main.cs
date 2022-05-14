using System;
using System.Linq;

namespace a
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine().Trim();
            string s2 = "";
            int cnt = 6/s.Length;

            for(int i=0;i<cnt;i++){
                s2 += s;
            }

            Console.WriteLine(s2);
        }
    }
}
