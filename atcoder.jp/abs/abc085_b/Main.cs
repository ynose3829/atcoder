using System;

namespace abc085b
{
    class Program
    {
        static void Main(string[] args)
        {
            int cnt = 1;
            int n = int.Parse(Console.ReadLine().Trim());
            int[] d = new int[n];
            for(int i=0;i<n;i++){
                d[i] = int.Parse(Console.ReadLine().Trim());
            }
            Array.Sort(d);
            Array.Reverse(d);

            for(int i=0;i<n-1;i++){
                if(d[i] > d[i+1]){
                    cnt++;
                }
            }
            Console.WriteLine(cnt);
        }
    }
}
