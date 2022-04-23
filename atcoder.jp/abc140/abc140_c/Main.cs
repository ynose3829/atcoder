using System;
using System.Linq;
using System.Collections.Generic;

namespace c
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine().Trim());
            int[] a = new int[n];  
            int[] b = Console.ReadLine()
            .Trim().Split(' ').Select(int.Parse).ToArray();
            int sum = 0;

            a[0] = b[0];
            a[a.Length-1] = b[b.Length-1];

            for(int i=1;i<n-1;i++){
                a[i] = Math.Min(b[i-1],b[i]);
            }
            
            foreach(int i in a){
                //Console.WriteLine(i);
                sum += i;
            }
            Console.WriteLine(sum);
            
        }
    }
}
