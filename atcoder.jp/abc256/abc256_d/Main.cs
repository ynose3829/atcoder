using System;
using System.Linq;
using System.Collections.Generic;

namespace d
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Tuple<int,int>> tupleList = new List<Tuple<int,int>>();
            List<int> R = new List<int>();
            List<int> L = new List<int>();

            for(int i=0;i<n;i++){
                var tmp = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToArray();
                tupleList.Add(Tuple.Create(tmp[0],tmp[1]));
            }

            List<Tuple<int,int>> LR = tupleList.OrderBy(x => x.Item1).ThenBy(x => x.Item2).ToList(); 

            for(int i=0;i<n;i++){
                if(R.Count == 0 || R.Last() < LR[i].Item1 ){
                    L.Add(LR[i].Item1);
                    R.Add(LR[i].Item2);
                }else if(LR[i].Item1 <= R.Last() && R.Last() < LR[i].Item2){
                    R[R.Count -1] = LR[i].Item2;
                }
            }

            for(int i=0;i<R.Count;i++){
                Console.WriteLine($"{L[i]} {R[i]}");
            }
        }
    }
}
