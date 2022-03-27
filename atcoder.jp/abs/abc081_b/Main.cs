using System;
using System.Linq;

namespace abc081b
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int n = Int32.Parse(input[0]);

            int[] a = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToArray();                

            int cnt = 0;
            while(judgeOdd(a)){
                cnt++;
                a = a.Select(n => n/2).ToArray();
            }

            Console.WriteLine(cnt);
        }

        static bool judgeOdd(int[] ary){
            foreach(int n in ary){
                if(n%2 == 1){
                    return false;
                }
            }
            return true;
        }
    }
}
