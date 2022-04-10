using System;

namespace c
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            int n = Int32.Parse(Console.ReadLine());

            //declare
            string[] s = new string[n];

            //init
            s[0] = "1";

            //proce
            for(int i = 1; i<s.Length;i++){
                s[i] = s[i-1] + " "+ (i+1).ToString() +" " + s[i-1];
            }

            Console.WriteLine(s[n-1]);            
        }
    }
}
