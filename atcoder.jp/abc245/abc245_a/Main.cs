using System;
class Program{
  static void Main(string[] args){
    var line = System.Console.ReadLine().Split(' ');
    int[] ary = new int[4];

    for(var i = 0; i < 4;i++){
        ary[i] = System.Int32.Parse(line[i]);
    }

    if(ary[0] < ary [2]){
        Console.WriteLine("Takahashi");
    }else if(ary[0] > ary [2]){
        Console.WriteLine("Aoki");
    }else if(ary[0] == ary [2]){
        if(ary[1] <= ary [3]){
            Console.WriteLine("Takahashi");
        }else if(ary[1] > ary [3]){
            Console.WriteLine("Aoki");
        }
    }
  }
  
}