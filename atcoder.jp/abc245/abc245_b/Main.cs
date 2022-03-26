using System;
class Program{
  static void Main(string[] args){
    var line = System.Console.ReadLine().Split(' ');
    int in1 = System.Int32.Parse(line[0]);

    int[] in2 = new int[in1];
    line = System.Console.ReadLine().Split(' ');
    for(int i = 0; i<in1 ; i++){
       in2[i] = System.Int32.Parse(line[i]);
    }
    System.Array.Sort(in2);
    bool flg = true;
    int ret = 0;
    int ans = 0;

    while(flg){
        ret = System.Array.BinarySearch(in2,ans);
        if(ret < 0){
            break;
        }
        ans++;
    }
    Console.WriteLine(ans);
  }
}