using System;
using System.Linq;

namespace c
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tmp = Console.ReadLine().Trim().Split(' ')
                .Select(int.Parse).ToArray();
            int n = tmp[0];
            int q = tmp[1];
            int[] x = new int[q];
            int[] a = Enumerable.Range(1,n).ToArray();
            int[] pos = Enumerable.Range(-1,n+1).ToArray();
            
            for(int i=0;i<q;i++){
                x[i] = int.Parse(Console.ReadLine().Trim());
            }

            foreach(int v in x){
                int i = pos[v];
                int j = i + 1;
                if(i == n - 1)j = i - 1;
                int y = a[j];

                (a[i],a[j]) = (a[j],a[i]);
                (pos[v],pos[y]) = (pos[y],pos[v]);
            }
            Console.WriteLine(string.Join(" ",a));
        }
    }
}
