using System;
using System.Linq;

namespace a
{
    class Program
    {
        static void Main(string[] args)
        {
            var tmp = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int r = tmp[0];
            int c = tmp[1];
            int[,]  a = new int[2,2];

            for(int i=0;i<2;i++){
                var tmp2 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                a[i,0] = tmp2[0];
                a[i,1] = tmp2[1];
            }

            Console.WriteLine("{0}",a[r-1,c-1]);
        }
    }
}
