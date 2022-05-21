using System;
using System.Linq;
using System.Collections.Generic;

namespace d
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tmp = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToArray();
            int n = tmp[0];
            int m = tmp[1];

            List<Tuple<int,int>> T = new List<Tuple<int,int>>();
            for(int i=0;i<m;i++){
                int[] tmp_ab = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToArray();
                T.Add(Tuple.Create(tmp_ab[0],tmp_ab[1]));
            }
            
        
            var newT = T.OrderBy(x => x.Item2);
            long cnt = 0;
            long now = 0;

            foreach(var t in newT){
                if(t.Item1 >= now){
                    cnt++;
                    now = t.Item2;
                }
            }
            
            Console.WriteLine(cnt);
        }
    }
}
