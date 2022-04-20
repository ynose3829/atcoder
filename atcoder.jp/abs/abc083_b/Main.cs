using System;
using System.Linq;

namespace abc083b
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Trim().Split(' ')
                .Select(int.Parse).ToArray();
            int n = input[0];
            int a = input[1];
            int b = input[2];
            int sum = 0;

            for(int i=1;i<n+1;i++){
                int s = i/10000%10 + i/1000%10 + i/100%10 + i/10%10 + i%10;
                if(a <= s && s <= b){
                    sum = sum + i;
                }
            }

            Console.WriteLine(sum);
        }
    }
}
