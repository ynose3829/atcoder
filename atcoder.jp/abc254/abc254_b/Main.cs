using System;
using System.Linq;
using System.Collections.Generic;

namespace b
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine().Trim());
            List<int>[] A = new List<int>[n];

            for(int i=0;i<n;i++){
                A[i] = new List<int>();
            }

            A[0].Add(1);

            for(int i=1;i<n;i++){
                for(int j=0;j<i+1;j++){
                    if(j == 0 || j==i){
                        A[i].Add(1);
                    }else{
                        A[i].Add(A[i-1][j-1]+A[i-1][j]);
                    }
                }
            }
            
            foreach(var a in A){
                Console.WriteLine(string.Join(" ",a));
            }
            
        }
    }
}
