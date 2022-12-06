```c#
using System;
using System.Linq;

class Program
{
  public static void Main(string[] args)
  {
    string InputArray = "nznrnfrfntjfmvfwmzdfjlvtqnbhcprsg";
    int p1Marker=4;
    int p2Marker=14;
    solution(p1Marker,InputArray);
    solution(p2Marker,InputArray);
  }

  public static void solution(int marker,string InputArray){
    for (int i = 0; i < InputArray.Length - (marker-1); i++)
    {
      string sub = InputArray.Substring(i, marker);
      if (sub.Distinct().Count() == sub.Count())
      {
        Console.WriteLine(i + marker);
        //Console.WriteLine(sub);
        return;
      }
    }
  } 
}
```
