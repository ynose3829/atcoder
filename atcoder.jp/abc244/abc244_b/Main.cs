using System;
using System.Linq;

namespace b
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine().Trim());
            string t = Console.ReadLine().Trim();

            (int x, int y) pos = (0, 0);
            (int x, int y) dir = (1, 0);

            foreach (var ch in t)
            {
                if (ch == 'S')
                {
                    pos.x += 1 * dir.x;
                    pos.y += 1 * dir.y;
                    //Console.WriteLine($"{pos.x} {pos.y}");
                }
                else if (ch == 'R')
                {
                    if (dir.x == 0 && dir.y == 1)
                    {
                        dir.x = 1;
                        dir.y = 0;
                    }
                    else if (dir.x == 1 && dir.y == 0)
                    {
                        dir.x = 0;
                        dir.y = -1;
                    }
                    else if (dir.x == 0 && dir.y == -1)
                    {
                        dir.x = -1;
                        dir.y = 0;
                    }
                    else if (dir.x == -1 && dir.y == 0)
                    {
                        dir.x = 0;
                        dir.y = 1;
                    }

                    //Console.WriteLine($"{dir.x} {dir.y}");
                }
            }

            Console.WriteLine($"{pos.x} {pos.y}");
        }
    }
}
