using System;
using System.Linq;

namespace a
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] i = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToArray();
            int x = i[6];
            int T = 0;
            int A = 0;


            while(x > 0){
                if(i[0] < x){
                    T = T + i[0] * i[1];
                    x = x - i[0];
                }else {
                    T = T + x * i[1];
                    x = x - x;
                }

                x = x - i[2];
            }

            x = i[6];

            while(x > 0){
                if(i[0] < x){
                    A = A + i[3] * i[4];
                    x = x - i[3];
                }else {
                    A = A + x * i[4];
                    x = x - x;
                }

                x = x - i[5];
            }


            if(T > A) Console.WriteLine("Takahashi");
            if(T < A) Console.WriteLine("Aoki");
            if(T == A) Console.WriteLine("Draw");
        }
    }
}
