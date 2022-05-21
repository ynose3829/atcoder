using System;
using System.Linq;

namespace b
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine().Trim();
            string t = Console.ReadLine().Trim();
            int n = s.Length;
            bool flg = false;

            for(int i=0;i<n;i++){
                char tmp = s[n-1];
                string tmp2 =   s.Substring(0,n-1);

                s = tmp.ToString();
                s += tmp2;
                if(s.Contains(t))flg = true;
            }

            if(flg) Console.WriteLine("Yes");
            if(!flg)Console.WriteLine("No");
        }
    }
}
