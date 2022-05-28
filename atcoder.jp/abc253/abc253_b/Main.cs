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
            int h = tmp[0];
            int w = tmp[1];
            string[] S = new String[h];

            for(int i=0;i<h;i++){
                S[i] = Console.ReadLine().Trim();
            }

            int[] x = new int[2];
            int[] y = new int[2];
            int cnt = 0;

            for(int i=0;i<h;i++){  
                if(S[i].Contains('o')){
                    int count = S[i].Split('o').Length - 1;
                    if(count == 1){
                        x[cnt] = S[i].IndexOf('o');
                        y[cnt] = i;
                        cnt++;
                    }else if(count == 2){
                        x[0] = S[i].IndexOf('o');
                        x[1] = S[i].LastIndexOf('o');
                        y[0] = i;
                        y[1] = i;
                    }
                }
            }
            //Console.WriteLine("x:{0},y:{1}",x[0],y[0]);
            //Console.WriteLine("x:{0},y:{1}",x[1],y[1]);
            int ans = Math.Abs(x[0] - x[1]) + Math.Abs(y[0] - y[1]);

            Console.WriteLine(ans);
        }
    }
}
