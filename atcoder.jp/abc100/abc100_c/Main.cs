using System;
using System.Linq;

namespace c
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine().Trim());
            int[] a = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToArray();
            int cnt = 0;

            for(int i=0;i<n;i++){
                while(a[i] % 2 == 0){
                    a[i] /= 2;
                    cnt++;
                }
            }

            Console.WriteLine(cnt);
        }
    }
}
