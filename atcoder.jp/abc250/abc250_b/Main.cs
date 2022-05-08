using System;
using System.Linq;

namespace b
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tmp = Console.ReadLine().Trim().Split(' ')
                .Select(int.Parse).ToArray();
            int n = tmp[0];
            int a = tmp[1];
            int b = tmp[2];
            string[] ans = new string[a*n];


            for(int i=0;i<b*n;i++){
                for(int j=0;j<a*n;j++){
                    if((i/b + j/a) % 2 == 0){
                        ans[j] = ans[j] + ".";
                    }else{
                        ans[j] = ans[j] + "#";
                    }
                }
            }

            for(int i=0;i<a*n;i++){
                Console.WriteLine(ans[i]);    
            }
            
        }
    }
}
