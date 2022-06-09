using System;
using System.Linq;

namespace a
{
    class Program
    {
        static void Main(string[] args)
        {
            var tmp = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToArray();
            int v = tmp[0];
            int a = tmp[1];
            int b = tmp[2];
            int c = tmp[3];

            int sum = a+b+c;
            int mod = v % sum;

            if(mod < a){
                Console.WriteLine("F");
            }else if(mod < a+b){
                Console.WriteLine("M");
            }else if(mod < sum){
                Console.WriteLine("T");
            }


        }
    }
}
