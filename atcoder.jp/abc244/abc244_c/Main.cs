using System;
using System.Linq;


namespace c
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] T = Enumerable.Range(1,2*n+1).ToArray();
            bool[] dp = Enumerable.Repeat(true,2*n+1).ToArray();
            

            while(true){
                int ans = T.Min();

                while(true){
                    if(dp[ans-1]){
                        Console.WriteLine($"{ans}");
                        dp[ans-1] = false;
                        break;
                    }else{
                        ans +=1;
                    }
                }
                


                Console.Clear();


                int aoki = int.Parse(Console.ReadLine().Trim());
                dp[aoki-1] = false;
                if(aoki == 0) break;
                Console.Clear();
            }
            

        }
    }
}
