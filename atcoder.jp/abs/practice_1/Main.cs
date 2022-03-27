using System;

namespace practicea
{
    class Program
    {
        static void Main(string[] args)
        {
            var line = System.Console.ReadLine().Split(' ');
            int a = Int32.Parse(line[0]);

            line = System.Console.ReadLine().Split(' ');
            int b = Int32.Parse(line[0]);
            int c = Int32.Parse(line[1]);

            line = System.Console.ReadLine().Split(' ');
            string s = line[0];

            int ans = a + b + c;
            Console.WriteLine(ans.ToString() + " " + s);
        }
    }
}
