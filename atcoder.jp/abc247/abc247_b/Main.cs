using System;
using System.Linq;

namespace b
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            int n = Int32.Parse(Console.ReadLine());
            string[] s = new string[n];
            string[] t = new string[n];
            bool[] sb = new bool[n];
            bool[] tb = new bool[n];
            bool ansS = true;
            bool ansT = true;

            for(int i=0;i<n;i++){
                string[] tmp = Console.ReadLine().Split(' ');
                s[i] = tmp[0];
                t[i] = tmp[1];
            }


            //procedure
            for(int i=0;i<s.Length;i++){
                sb[i] = true;
                for(int j=0; j<s.Length;j++){
                    if(i != j){
                        if(s[i] == s[j] ||s[i] == t[j]){
                            sb[i] =false;
                        }
                    }
                }
            }

            for(int i=0;i<s.Length;i++){
                tb[i] = true;
                for(int j=0; j<s.Length;j++){
                    if(i != j){
                        if(t[i] == t[j] ||t[i] == s[j]){
                            tb[i] =false;
                        }
                    }
                }
            }
          

            //pro2
            foreach(bool tmp in sb){
                ansS = ansS&&tmp;
            }

            foreach(bool tmp in tb){
                ansT = ansT&&tmp;
            }


            //output
            if(ansS || ansT){ 
                Console.WriteLine("Yes");
            }
            else{
                Console.WriteLine("No");
            }
        }
    }
}
