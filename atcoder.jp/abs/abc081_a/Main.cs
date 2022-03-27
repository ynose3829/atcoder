using System;

namespace abc081a
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            char[] c = input[0].ToCharArray();
            int cnt = 0;

            foreach(char s in c){
                if(s=='1'){
                    cnt++;
                }
            }

            Console.WriteLine(cnt);
        }
    }
}
