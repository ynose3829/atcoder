using System;
using System.Linq;

namespace b
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine().Trim();
            bool flg = true;
            bool isUpper = false;
            bool isLower = false;


            for(int i=0; i<s.Length-1;i++){
                for(int j=0; j<s.Length-1;j++){
                    if(s[i] == s[j] && i != j){
                        flg = false;
                    }
                }
            }

            foreach(char c in s){
                isUpper = isUpper || char.IsUpper(c);
                isLower = isLower || char.IsLower(c);
            }



            if(flg && isLower && isUpper){Console.WriteLine("Yes");}
            else{Console.WriteLine("No");}
        }
    }
}
