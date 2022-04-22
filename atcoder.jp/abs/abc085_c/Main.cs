using System;
 
class Program
{
    static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Split(" ");
        int n = int.Parse(input[0]);
        int y = int.Parse(input[1]);
 
        for (int i = 0; i <= n; i++)
        {
            for (int j = 0; j <= n - i; j++)
            {
                int k = n - i - j;
                if (y == 10000 * i + 5000 * j + 1000 * k)
                {
                    Console.WriteLine($"{i} {j} {k}");
                    return;
                }
            }
        }
 
        Console.WriteLine("-1 -1 -1");
    }
}