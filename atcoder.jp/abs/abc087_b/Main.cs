using System;

namespace abc087b
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Int32.Parse(Console.ReadLine().Trim());
            int b = Int32.Parse(Console.ReadLine().Trim());
            int c = Int32.Parse(Console.ReadLine().Trim());
            int x = Int32.Parse(Console.ReadLine().Trim());
            int cnt = 0;

            for(int i=0;i<a+1;i++){
                for(int j=0;j<b+1;j++){
                    for(int k=0;k<c+1;k++){
                        if(500*i+100*j+50*k == x) cnt++;
                    }
                }
            }
            Console.WriteLine(cnt);
        }
    }
}
