using System;
using System.Linq;

namespace b
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] tmp = Console.ReadLine().Trim().Split(' ').Select(double.Parse).ToArray();
            double d = tmp[0];
            double n = tmp[1];
            
            

            if(n != 100){
                double x = Math.Pow(100,d)*n;
                Console.WriteLine(x);
            }else if(n == 100){
                double x = Math.Pow(100,d)*101;
                Console.WriteLine(x);
            }
            
        }
    }
}
