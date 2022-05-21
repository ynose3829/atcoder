using System;
using System.Linq;
using System.Collections.Generic;

namespace b
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tmp = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToArray();
            int n = tmp[0];
            int k = tmp[1];

            int[] A = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToArray();
            int[] B = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToArray();

            bool flg = false;
            
            int max = 0;
            foreach(int a in A){
                if(max < a) max = a;
            }           

            foreach(int b in B){
                if(A[b-1] == max) flg =true;
            }


            if(flg){
                Console.WriteLine("Yes");
            }else if(!flg){
                Console.WriteLine("No");
            }
        }
    }
}
