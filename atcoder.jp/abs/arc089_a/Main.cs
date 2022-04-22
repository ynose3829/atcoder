using System;
using System.Linq;

namespace abc086c
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine().Trim());
            int[] T = new int[n];
            int[] X = new int[n];
            int[] Y = new int[n];

            for(int i=0;i<n;i++){
                int[] input = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToArray();
                T[i] = input[0];
                X[i] = input[1];
                Y[i] = input[2];
            }

            Console.WriteLine(solve(n,T,X,Y));
            
        }

        static string solve(int n,int[]T,int[]X,int[]Y){
            int pt = 0;
            int px = 0;
            int py = 0;

            for(int i=0;i<n;i++){
                int d = Math.Abs(px- X[i]) + Math.Abs(py - Y[i]);
                int dt = T[i] - pt;
                if(dt < d) return "No";
                if((dt - d)%2 ==1) return "No";

                pt = T[i];
                px = X[i];
                py = Y[i];

            }
            return "Yes";
        }
    }
}
