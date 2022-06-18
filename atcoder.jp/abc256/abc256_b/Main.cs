using System;
using System.Linq;

namespace b
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var A = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToArray();
            int P = 0;
            bool[] dp = new bool[4];


            for(int i=0;i<n;i++){
                dp[0] = true;
                for(int j=3;j>=0;j--){
                    if(dp[j]){
                        if(j + A[i] < 4){
                            dp[j+A[i]] = true;
                        }else{
                            P++;
                        }
                        dp[j] = false;
                    }
                }
                
            }

            Console.WriteLine($"{P}");

        }
    }
}
