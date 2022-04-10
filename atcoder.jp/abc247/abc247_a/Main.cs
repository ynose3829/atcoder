using System;

namespace a
{
    class Program
    {
        static void Main(string[] args)
        {
            string s  = Console.ReadLine();
            char[] ch = s.ToCharArray();
            for(int i =1;i < ch.Length ; i++){
                ch[ch.Length - i] = ch[ch.Length - i-1];
            }
            ch[0] = '0';

            s = new string(ch);
            Console.WriteLine(s);
        }
    }
}
