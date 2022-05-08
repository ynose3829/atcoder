using System;
using System.Linq;

namespace a
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tmp = Console.ReadLine().Trim().Split(' ')
                .Select(int.Parse).ToArray();

            int[] tmp2 = Console.ReadLine().Trim().Split(' ')
                .Select(int.Parse).ToArray();

            int h = tmp[0];
            int w = tmp[1];
            int r = tmp2[0];
            int c = tmp2[1];

            int cnt = 0;
            int up = 0;
            int down = 0;
            int left =0;
            int right = 0;


            if(r-1 > 0){
                up = Math.Abs(r - (r-1)) + Math.Abs(c - c);
            }
            if(r+1 <= h){
                down = Math.Abs(r - (r+1)) + Math.Abs(c - c);
            }
            
            if(c-1 > 0){
                left = Math.Abs(r - r) + Math.Abs(c - (c-1));
            }
            
            if(c+1 <= w){
                right = Math.Abs(r - r) + Math.Abs(c - (c+1));
            }
                
                

            if(up == 1) cnt++;
            if(down == 1) cnt++;
            if(right == 1) cnt++;
            if(left == 1) cnt++;
            

            Console.WriteLine(cnt);
        }
    }
}
