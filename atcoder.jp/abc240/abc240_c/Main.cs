using System;
using System.Linq;
using System.Collections.Generic;

namespace c
{
    class Program
    {
        static void Main(string[] args)
        {
            var tmp = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToArray();
            int n = tmp[0];
            int x = tmp[1];
            int[] a = new int[n];
            int[] b = new int[n];


            for(int i=0;i<n;i++){
                var tmp2 = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToArray();
                a[i] = tmp2[0];
                b[i] = tmp2[1];
            }

            bool[,] dp = new bool[x+1,n+1];
            dp[0,0] = true;

            for(int j=0;j<n;j++){
                for(int i=0;i<x;i++){
                    if(dp[i,j]){
                        if(i+a[j]<=x){
                            dp[i+a[j],j+1] = true;
                        }
                        if(i+b[j] <= x){
                            dp[i+b[j],j+1] = true;
                        }
                    }
                }
            }

            bool ans = dp[x,n];
            if(ans)Console.WriteLine("Yes");
            if(!ans)Console.WriteLine("No");

            
        }
    }
}
