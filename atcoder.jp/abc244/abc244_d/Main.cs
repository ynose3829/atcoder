using System;
using System.Linq;

namespace d
{
    class Program
    {
        static void Main(string[] args)
        {
            string S = Console.ReadLine().Trim();
            string T = Console.ReadLine().Trim();
            bool flg1 = sign(S);
            bool flg2 = sign(T);

            if(flg1 ^ flg2){
                Console.WriteLine("No");
            }else{
                Console.WriteLine("Yes");
            }
            
        }

        static bool sign(string S){
            return S == "R G B" || S == "G B R" || S == "B R G";
        }
    }
}
