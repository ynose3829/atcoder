using System;
using System.Linq;
using System.Collections.Generic;

namespace c
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine().Trim());
            long cnt = 0;
            long[,] dp = new long[n + 1, 10];

            //init
            dp[1, 1] = 1;
            dp[1, 9] = 1;
            for (int i = 2; i < 9; i++)
            {
                dp[1, i] = 1;
            }


            //transition
            for (long i = 2; i < n + 1; i++)
            {
                for (long j = 1; j < 10; j++)
                {
                    if (j == 1)
                    {
                        dp[i, j] = dp[i - 1, j] + dp[i - 1, j + 1];
                    }
                    else if (j == 9)
                    {
                        dp[i, j] = dp[i - 1, j - 1] + dp[i - 1, j];
                    }
                    else
                    {
                        dp[i, j] = dp[i - 1, j - 1] + dp[i - 1, j] + dp[i - 1, j + 1];
                    }

                    dp[i, j] = dp[i, j] % 998244353;
                    //Console.WriteLine(dp[i,j]);
                }
            }

            for (int i = 1; i < 10; i++)
            {               
                cnt += dp[n, i];
            }
    
        
            Console.WriteLine(cnt% 998244353);
        }
    }
}
