using System;

namespace a
{
    class Program
    {
        static   void Main(string[] args)
        {
            string line = Console.ReadLine();
            char[] cmp = new char[]{'0','1','2','3','4','5','6','7','8','9'};
            char[] num = line.ToCharArray();
            foreach(char tmp in cmp){
                bool flg = true;
                foreach(char ch in num){
                    if(ch == tmp)flg = false;
                }
                if(flg)Console.WriteLine(tmp);
            }

        }
       
    }
}
