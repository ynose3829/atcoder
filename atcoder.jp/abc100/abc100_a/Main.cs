using System;
using System.Linq;

namespace a
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tmp = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToArray();
            int a = tmp[0];
            int b = tmp[1];

            if((a <= 8) && (b <= 8)){
                Console.WriteLine("Yay!");
            }else{
                Console.WriteLine(":(");
            }
           
        }
    }
}
