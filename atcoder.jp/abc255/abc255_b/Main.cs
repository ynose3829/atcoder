using System;
using System.Linq;
using System.Collections.Generic;

namespace b
{
    class Program
    {
        static void Main(string[] args)
        {
            var tmp = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int n = tmp[0];
            int k = tmp[1];
            var A = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var x = new int[n];
            var y = new int[n];

            for(int i=0;i<n;i++){
                var tmp2 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                x[i] = tmp2[0];
                y[i] = tmp2[1];
            }

            double[] nearest = new double[n];

            for(int i=0;i<n;i++){
                nearest[i] = double.MaxValue;
            }

            for(int i=0;i<n;i++){
                foreach(var a in A){
                    double dist = Math.Sqrt(Math.Pow((x[i] - x[a-1]) ,2) + Math.Pow((y[i] - y[a-1]) ,2));
                    nearest[i] = Math.Min(nearest[i],dist);
                }
            }

            Console.WriteLine(nearest.Max());
        }
    }
}
